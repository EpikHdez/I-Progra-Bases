USE CampeonatosDB;
GO

--Incompleto
CREATE PROCEDURE CASP_BorrarCampeonato
	@pIDCampeonato INT
AS
BEGIN
	BEGIN TRY
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
		BEGIN TRANSACTION
			DELETE FROM dbo.Carreras
			WHERE FKCampeonato = @pIDCampeonato;

			DELETE FROM dbo.Campeonatos
			WHERE ID = @pIDCampeonato;
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