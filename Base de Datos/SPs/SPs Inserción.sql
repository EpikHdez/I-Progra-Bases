USE CampeonatosDB;
GO

CREATE PROCEDURE CASP_InsertarCampeonato
	@pNombre VARCHAR(100) = NULL,
	@pFechaInicio DATE = NULL,
	@pFechaFin DATE = NULL
AS
BEGIN
	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
		BEGIN TRANSACTION;
			INSERT INTO dbo.Campeonatos (Nombre, FechaInicio, FechaFin)
			VALUES (@pNombre, @pFechaInicio, @pFechaFin);
		COMMIT TRANSACTION;
		
		RETURN SCOPE_IDENTITY();
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK;

		RETURN @@ERROR * -1;
	END CATCH
END
GO

CREATE PROCEDURE CASP_InsertarCarrera
	@pDescripcion VARCHAR(200) = NULL,
	@pLugarPartida VARCHAR(100) = NULL,
	@pLugarLlegada VARCHAR(100) = NULL,
	@pRecorrido VARCHAR(20) = NULL,
	@pFecha DATE = NULL,
	@pHora TIME = NULL,
	@pCosto INT = 0,
	@pCampeonato INT
AS
BEGIN
	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
		BEGIN TRANSACTION
			INSERT INTO dbo.Carreras (Descripcion, LugarPartida, LugarLlegada,
								Recorrido, Fecha, Hora, Costo, FKCampeonato)
			VALUES (@pDescripcion, @pLugarPartida, @pLugarLlegada, @pRecorrido,
					 @pFecha, @pHora, @pCosto, @pCampeonato);
		COMMIT TRANSACTION;

		RETURN 1;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK;
		
		RETURN @@ERROR * -1;
	END CATCH;
END
GO

CREATE PROCEDURE CASP_InsertarCorredor
	@pIdentificacion INT = NULL,
	@pNombre VARCHAR(50) = NULL,
	@pAlias VARCHAR(50) = NULL,
	@pEmail VARCHAR(100) = NULL,
	@pGenero VARCHAR(10) = NULL,
	@pFechaNacimiento DATE = NULL,
	@IDCampeonato INT
AS
BEGIN
	DECLARE @IDCorredor INT;

	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
		BEGIN TRANSACTION
			INSERT INTO dbo.Corredores (Identificacion, Nombre, Alias, Email, Genero, 
								FechaNacimiento, Activo)
			VALUES (@pIdentificacion, @pNombre, @pAlias, @pEmail, @pGenero, @pFechaNacimiento,
				1);

			SET @IDCorredor = SCOPE_IDENTITY();

			INSERT INTO dbo.CampeonatosXCorredores (Numero, TiempoAcumulado, PuntosAcumulados, 
											PuntosSancionAcumulados, FKCampeonato, FKCorredor)
			VALUES (@IDCorredor, '00:00:00', 0, 0, @IDCampeonato, @IDCorredor);
		COMMIT TRANSACTION;

		RETURN @IDCorredor;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK;

		RETURN @@ERROR * -1;
	END CATCH
END
GO

CREATE PROCEDURE CASP_InsertarPosicion
	@pTiempo TIME,
	@pPosicion INT,
	@pCarrera INT,
	@pCorredor INT,
	@pPostIn VARCHAR(50),
	@pPostBy VARCHAR(50)
AS
BEGIN
	BEGIN TRY
		DECLARE @IDPosicion INT, @puntos INT, @nuevoTiempo TIME;
		DECLARE @IDCampeonato INT, @IDCampeonatoXCorredor INT;

		SELECT @IDCampeonato = CA.FKCampeonato
		FROM dbo.Carreras CA
		WHERE CA.ID = @pCarrera;

		SELECT @IDCampeonatoXCorredor = CC.ID
		FROM dbo.CampeonatosXCorredores CC
		WHERE CC.FKCorredor = @pCorredor AND CC.FKCampeonato = @IDCampeonato;

		SELECT @nuevoTiempo = DATEADD(ms, SUM(DATEDIFF(ms, '00:00:00.000', CC.TiempoAcumulado)), '00:00:00.000') 
		FROM CampeonatosXCorredoreS CC
		WHERE CC.ID = @IDCampeonatoXCorredor;

		IF @pPosicion < 20
			SET @puntos = ABS(@pPosicion - 21);
		ELSE
			SET @puntos = 0;

		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
		BEGIN TRANSACTION
			INSERT INTO dbo.Posiciones (Tiempo, Posicion, FKCarrera, FKCorredor)
			VALUES (@pTiempo, @pPosicion, @pCarrera, @pCorredor);

			SET @IDPosicion = SCOPE_IDENTITY();

			INSERT INTO dbo.MovimientosPuntos (Monto, PostIn, PostBy, PostDate, FKPosicion,
											FKTipoMovimientoPuntos, FKCampeonatoXCorredor)
			VALUES (@puntos, @pPostIn, @pPostBy, GETDATE(), @IDPosicion,
					1, @IDCampeonatoXCorredor);

			UPDATE CampeonatosXCorredores
			SET TiempoAcumulado = @nuevoTiempo,
				PuntosAcumulados = (PuntosAcumulados + @puntos);
		COMMIT TRANSACTION;

		RETURN 1;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK;

		RETURN @@ERROR * -1;
	END CATCH
END
GO

CREATE PROCEDURE CASP_InsertarSancion
	@pPuntos INT,
	@pCarrera INT,
	@pTipoSancion INT,
	@pTipoMovimientoSancion INT,
	@pNumeroCorredor INT,
	@pPostIn VARCHAR(50),
	@pPostBy VARCHAR(50)
AS
BEGIN
	DECLARE @IDSancion INT;

	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
		BEGIN TRANSACTION
			INSERT INTO dbo.Sanciones (Puntos, FKCarrera, FKTipoSancion)
			VALUES (@pPuntos, @pCarrera, @pTipoSancion);

			SET @IDSancion = SCOPE_IDENTITY();

			INSERT INTO dbo.MovimientosPorSancion (Monto, PostIn, PostBy, PostDate, FKSancion,
												FKTipoMovimientoSancion, FKCampeonatoXCorredor)
			VALUES (@pPuntos, @pPostIn, @pPostBy, GETDATE(), @IDSancion, @pTipoMovimientoSancion,
					@pNumeroCorredor);

			UPDATE dbo.CampeonatosXCorredores
			SET PuntosSancionAcumulados = (PuntosSancionAcumulados + @pPuntos)
			WHERE ID = @pNumeroCorredor;
		COMMIT TRANSACTION;

		RETURN 1;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK;

		RETURN @@ERROR * -1;
	END CATCH
END
GO

CREATE PROCEDURE SP_InsertarTipoSancion
	@pNombre VARCHAR(50)
AS
BEGIN
	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
		BEGIN TRANSACTION
			INSERT INTO dbo.TipoSancion (Nombre)
			VALUES (@pNombre);
		COMMIT TRANSACTION;

		RETURN 1;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK;

		RETURN @@ERROR * -1;
	END CATCH
END
GO

CREATE PROCEDURE SP_InsertarTipoMovimientoSancion
	@pNombre VARCHAR(50)
AS
BEGIN
	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
		BEGIN TRANSACTION
			INSERT INTO dbo.TipoMovimientoSancion(Nombre)
			VALUES (@pNombre);
		COMMIT TRANSACTION;

		RETURN 1;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK;

		RETURN @@ERROR * -1;
	END CATCH
END
GO

CREATE PROCEDURE SP_InsertarTipoMovimientoPuntos
	@pNombre VARCHAR(50)
AS
BEGIN
	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
		BEGIN TRANSACTION
			INSERT INTO dbo.TipoMovimientoPuntos(Nombre)
			VALUES (@pNombre);
		COMMIT TRANSACTION;

		RETURN 1;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK;

		RETURN @@ERROR * -1;
	END CATCH
END
GO