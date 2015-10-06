USE CampeonatosDB;
GO

CREATE PROCEDURE CASP_CargarDatosBasicos
	@xmlPath NVARCHAR(300)
AS
BEGIN
	BEGIN TRY
		DECLARE @command NVARCHAR(500), @param NVARCHAR(50);
		DECLARE @xmlDocument XML;

		SET @command = 'SET @xmlDocument = (SELECT * FROM OPENROWSET(BULK ''' +
			@xmlPath + ''', SINGLE_BLOB) AS data)';

		EXEC dbo.sp_executesql
			@command = @command,
			@params = N'@xmlDocument xml output',
			@xmlDocument = @xmlDocument output

		EXEC dbo.CAS_InsertarCampeonato
			SELECT @pNombre = Campeonato.value('@Nombre', 'VARCHAR(100)'),
					@pFechaInicio = Campeonato.value('@FechaInicio', 'DATE'),
					@pFechaFin = Campeonato.value('@FechaFin', 'DATE')
			FROM @xmlDocument.nodes('Campeonato') AS CA(Campeonato);
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK;

		RETURN @@ERROR * -1;
	END CATCH
END