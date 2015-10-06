DECLARE @xmlDocument XML, @filePath NVARCHAR(500), @command NVARCHAR(1000), @param NVARCHAR(100);
DECLARE @IDCampeonato INT, @nombre VARCHAR(100), @inicio DATE, @fin DATE;
DECLARE @pIdentificacion INT, @pNombre VARCHAR(50), @pAlias VARCHAR(50), @pEmail VARCHAR(100), 
		@pGenero VARCHAR(10), @pFechaNacimiento DATE;

DECLARE @tabla TABLE(ID INT IDENTITY(1,1), nombre VARCHAR(100), inicio DATE, fin DATE);
DECLARE @TableCO TABLE(ID INT IDENTITY(1,1), identificacion INT, nombre VARCHAR(50),
				alias VARCHAR(50), email VARCHAR(100), genero VARCHAR(10), nacimiento DATE);

SET @filePath = 'C:\Users\Erick\Dropbox\Bases de Datos I\Base de Datos\XMLs\XMLBase.xml';
SET @command = 'SET @xmlDocument = (SELECT * FROM OPENROWSET(BULK ''' +
			@filePath + ''', SINGLE_BLOB) AS data)';
SET @param = '@xmlDocument xml output';

EXEC dbo.sp_executesql
	@command = @command,
	@params = @param,
	@xmlDocument = @xmlDocument output

INSERT INTO @tabla(nombre, inicio, fin)
	SELECT CA.item.value('@Nombre', 'VARCHAR(100)'),
		CA.item.value('@FechaInicio', 'DATE'),
		CA.item.value('@FechaFin', 'DATE')
	FROM @xmlDocument.nodes('Campeonato') AS CA(item);

INSERT INTO @TableCO (identificacion, nombre, alias, email, genero)
	SELECT CO.item.value('@Identificación', 'INT'),
		CO.item.value('@Nombre', 'VARCHAR(50)'),
		CO.item.value('@SobreNombre', 'VARCHAR(50)'),
		CO.item.value('@Email', 'VARCHAR(50)'),
		CO.item.value('@Genero', 'VARCHAR(10)')
	FROM @xmlDocument.nodes('Campeonato/Corredores/Participante') AS CO(item);


DECLARE @lowCA INT, @highCA INT, @lowCO INT, @highCO INT;

SET @lowCA = 1;
SELECT @highCA = MAX(ID) FROM @tabla;

WHILE (@lowCA <= @highCA)
BEGIN
	SELECT @nombre = T.nombre,
		@inicio = T.inicio,
		@fin = T.fin
	FROM @tabla T
	WHERE ID = @lowCA;

	EXEC @IDCampeonato = CASP_InsertarCampeonato
		@nombre, @inicio, @fin;

	SET @lowCA = @lowCA + 1;

	SET @lowCO = 1;
	SELECT @highCO = MAX(ID) FROM @TableCO;

	WHILE @lowCO <= @highCO
	BEGIN
		SELECT @pIdentificacion = T1.identificacion,
		@pNombre = T1.nombre,
		@pAlias = T1.alias,
		@pEmail = T1.email,
		@pGenero = T1.genero,
		@pFechaNacimiento = T1.nacimiento
		FROM @TableCO T1
		WHERE ID = @lowCO;

		EXEC CASP_InsertarCorredor
			@pIdentificacion, @pNombre, @pAlias, @pEmail, @pGenero, @pFechaNacimiento, @IDCampeonato;

		SET @lowCO = @lowCO + 1;
	END
END