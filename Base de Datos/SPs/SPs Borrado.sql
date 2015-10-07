USE CampeonatosDB;
GO

--Incompleto
CREATE PROCEDURE CASP_BorrarCampeonato
	@pIDCampeonato INT
AS
BEGIN
	BEGIN TRY
		DECLARE @TCarreras TABLE (ID INT IDENTITY(1, 1), IDCarrera INT);
		DECLARE @TSanciones TABLE (ID INT IDENTITY(1, 1), IDSancion INT);
		DECLARE @TPosicion TABLE (ID INT IDENTITY(1, 1), IDPosicion INT);
		
		INSERT INTO @TCarreras (IDCarrera)
		SELECT CA.ID FROM dbo.Carreras CA
		WHERE CA.FKCampeonato = @pIDCampeonato;

		INSERT INTO @TSanciones (IDSancion)
		SELECT SA.ID FROM dbo.Sanciones SA
		INNER JOIN @TCarreras CA ON SA.FKCarrera = CA.IDCarrera;

		INSERT INTO @TPosicion (IDPosicion)
		SELECT PO.ID FROM dbo.Posiciones PO
		INNER JOIN @TCarreras CA ON PO.FKCarrera = CA.IDCarrera;

		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
		BEGIN TRANSACTION
			UPDATE dbo.Campeonatos
			SET Activo = 0
			WHERE ID = @pIDCampeonato;

			UPDATE dbo.Carreras
			SET Activo = 0
			WHERE FKCampeonato = @pIDCampeonato;

			UPDATE dbo.Sanciones
			SET Activo = 0 FROM dbo.Sanciones SA
			INNER JOIN @TCarreras CA ON SA.FKCarrera = CA.IDCarrera;

			UPDATE dbo.Posiciones
			SET Activo = 0 FROM dbo.Posiciones PO
			INNER JOIN @TCarreras CA ON PO.FKCarrera = CA.IDCarrera;

			UPDATE dbo.MovimientosPorSancion
			SET Activo = 0 FROM  dbo.MovimientosPorSancion MPS
			INNER JOIN @TSanciones SA ON MPS.FKSancion = SA.IDSancion;

			UPDATE dbo.MovimientosPuntos
			SET Activo = 0 FROM dbo.MovimientosPuntos MP
			INNER JOIN @TPosicion PO ON MP.FKPosicion = PO.IDPosicion;

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

CREATE PROCEDURE CASP_BorrarCarrera
	@pIDCarrera INT
AS
BEGIN
	BEGIN TRY
		DECLARE @SancionesCarrera TABLE (IDSancion INT);
		DECLARE @PosicionesCarrera TABLE (IDPosicion INT);

		INSERT INTO @SancionesCarrera (IDSancion)
		SELECT S.ID FROM Sanciones S
		WHERE FKCarrera = @pIDCarrera;

		INSERT INTO @PosicionesCarrera (IDPosicion)
		SELECT P.ID FROM Posiciones P
		WHERE FKCarrera = @pIDCarrera;

		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
		BEGIN TRANSACTION
			DELETE MS FROM dbo.MovimientosPorSancion MS
			INNER JOIN @SancionesCarrera SC
			ON MS.FKSancion = SC.IDSancion;

			DELETE FROM dbo.Sanciones
			WHERE FKCarrera = @pIDCarrera;

			DELETE MP FROM dbo.MovimientosPuntos MP
			INNER JOIN @PosicionesCarrera PC
			ON MP.FKPosicion = PC.IDPosicion;

			DELETE FROM dbo.Posiciones
			WHERE FKCarrera = @pIDCarrera;

			DELETE FROM dbo.Carreras
			WHERE ID = @pIDCarrera;
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

CREATE PROCEDURE CASP_BorrarCorredor
	@pIDCorredor INT
AS
BEGIN
	BEGIN TRY
		DECLARE @SancionesCorredor TABLE (IDSancion INT);

		INSERT INTO @SancionesCorredor (IDSancion)
		SELECT M.FKSancion FROM dbo.MovimientosPorSancion M
		WHERE FKCampeonatoXCorredor = @pIDCorredor;

		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
		BEGIN TRANSACTION
			DELETE FROM dbo.MovimientosPorSancion
			WHERE FKCampeonatoXCorredor = @pIDCorredor;

			DELETE S1 FROM dbo.Sanciones S1
			INNER JOIN @SancionesCorredor S2
			ON S1.ID = S2.IDSancion;

			DELETE FROM dbo.MovimientosPuntos
			WHERE FKCampeonatoXCorredor = @pIDCorredor;

			DELETE FROM dbo.Posiciones
			where FKCorredor = @pIDCorredor;

			DELETE FROM dbo.CampeonatosXCorredores
			WHERE ID = @pIDCorredor;

			DELETE FROM dbo.Corredores
			WHERE ID = @pIDCorredor;
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

CREATE PROCEDURE CASP_BorrarSancion
	@pIDSancion INT
AS
BEGIN
	BEGIN TRY
		DECLARE @puntos INT;

		SELECT @puntos = S.Puntos 
		FROM Sanciones S
		WHERE S.ID = @pIDSancion;

		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
		BEGIN TRANSACTION
			DELETE FROM dbo.MovimientosPorSancion
			WHERE FKSancion = @pIDSancion;

			DELETE FROM dbo.Sanciones
			WHERE ID = @pIDSancion;

			UPDATE dbo.CampeonatosXCorredores
			SET PuntosSancionAcumulados = PuntosSancionAcumulados - @puntos;
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

CREATE PROCEDURE CASP_BorrarTipoSancion
	@pIDTipoSancion INT
AS
BEGIN
	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
		BEGIN TRANSACTION
			DELETE FROM dbo.TipoSancion
			WHERE ID = @pIDTipoSancion;
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

CREATE PROCEDURE CASP_BorrarTipoMovimientoSancion
	@pIDTipoMovimientoSancion INT
AS
BEGIN
	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
		BEGIN TRANSACTION
			DELETE FROM dbo.TipoMovimientoSancion
			WHERE ID = @pIDTipoMovimientoSancion;
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

CREATE PROCEDURE CASP_BorrarTipoMovimientoPuntos
	@pIDTipoMovimientoPuntos INT
AS
BEGIN
	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
		BEGIN TRANSACTION
			DELETE FROM dbo.TipoMovimientoPuntos
			WHERE ID = @pIDTipoMovimientoPuntos;
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