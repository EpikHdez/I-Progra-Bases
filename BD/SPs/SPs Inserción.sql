USE Campeonatos;
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
			INSERT INTO dbo.Campeonato (Nombre, FechaInicio, FechaFin)
			VALUES (@pNombre, @pFechaInicio, @pFechaFin);
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 1
			ROLLBACK;

		RETURN @@ERROR * -1;
	END CATCH
END
GO

CREATE PROCEDURE CASP_InsertarCarrera
	@pNombre VARCHAR(50) = NULL,
	@pDescripcion VARCHAR(200) = NULL,
	@pFecha DATE = NULL,
	@pCampeonato INT
AS
BEGIN
	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
		BEGIN TRANSACTION
			INSERT INTO dbo.Carreras (Nombre, Descripcion, Fecha, FKCampeonato)
			VALUES (@pNombre, @pDescripcion, @pFecha, @pCampeonato);
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 1
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
	@CampeonatoRegistrado VARCHAR(100)
AS
BEGIN
	DECLARE @IDCorredor INT, @IDCampeonato INT;
	SELECT @IDCampeonato = ID FROM Campeonato WHERE Nombre = @CampeonatoRegistrado;

	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
		BEGIN TRANSACTION
			INSERT INTO dbo.Corredores (Identificacion, Nombre, Alias, Email, Genero, FechaNacimiento)
			VALUES (@pIdentificacion, @pNombre, @pAlias, @pEmail, @pGenero, @pFechaNacimiento);

			SET @IDCorredor = SCOPE_IDENTITY();

			INSERT INTO dbo.CampeonatoXCorredor (Numero, TiempoAcumulado, PuntosAcumulados, PuntosSancionAcumulados,
											FKCampeonato, FKCorredor)
			VALUES (@IDCorredor, 0.0, 0, 0, @IDCampeonato, @IDCorredor);
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 1
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
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 1
			ROLLBACK;

		RETURN @@ERROR * -1;
	END CATCH
END
GO

CREATE PROCEDURE SP_InsertarTipoSancion
	@pNombre VARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.TipoSancion (Nombre)
	VALUES (@pNombre);
END
GO

CREATE PROCEDURE SP_InsertarTipoMovimientoSancion
	@pNombre VARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.TipoMovimientoSancion (Nombre)
	VALUES (@pNombre);
END
GO

CREATE PROCEDURE SP_InsertarTipoMovimientoPuntos
	@pNombre VARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.TipoMovimientoPuntos (Nombre)
	VALUES (@pNombre);
END