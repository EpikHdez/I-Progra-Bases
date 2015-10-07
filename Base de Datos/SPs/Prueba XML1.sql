DECLARE @command NVARCHAR(500), @xmlPath NVARCHAR(300);
DECLARE @lowCO INT, @highCO INT, @lowCA INT, @highCA INT;
DECLARE @xmlDocument XML;

DECLARE @ID INT, @nombreCampeonato VARCHAR(100), @FechaI DATE, @FechaF DATE;
DECLARE @Identificacion INT, @Nombre VARCHAR(50), @Alias VARCHAR(50), @Email VARCHAR(100),
		@Genero VARCHAR(10), @FechaNacimiento DATE;
DECLARE @Corredores TABLE(ID INT IDENTITY(1,1), Identificacion INT, Nombre VARCHAR(50),
					Alias VARCHAR(50), Email VARCHAR(100), Genero VARCHAR(10), FechaNacimiento DATE); 

SET @xmlPath = N'C:\Users\Erick\Dropbox\Bases de Datos I\Base de Datos\XMLs\XMLBases.xml';

SET @command = N'SET @xmlDocument = (SELECT * FROM OPENROWSET(BULK ''' +
	@xmlPath + ''', SINGLE_BLOB) AS data)';

EXEC dbo.sp_executesql
	@command = @command,
	@params = N'@xmlDocument xml output',
	@xmlDocument = @xmlDocument output

SELECT @nombreCampeonato = campeonato.value('@Nombre', 'VARCHAR(100)'),
		@FechaI = Campeonato.value('@FechaInicio', 'DATE'),
		@FechaF = Campeonato.value('@FechaFin', 'DATE')
FROM @xmlDocument.nodes('Campeonato') AS CC(Campeonato);

EXEC @ID = dbo.CASP_InsertarCampeonato
	@nombreCampeonato, @FechaI, @FechaF;


INSERT INTO @Corredores (Identificacion, Nombre, Alias, Email, Genero, FechaNacimiento)
SELECT Corredor.value('@Identificacion', 'INT'),
		Corredor.value('@Nombre', 'VARCHAR(50)'),
		Corredor.value('@SobreNombre', 'VARCHAR(50)'),
		Corredor.value('@Email', 'VARCHAR(100)'),
		Corredor.value('@Genero', 'VARCHAR(10)'),
		Corredor.value('@FechaNacimiento', 'DATE')
FROM @xmlDocument.nodes('Campeonato/Corredores/Participante') AS CO(Corredor);

SET @lowCO = 1;
SELECT @highCO = MAX(ID) FROM @Corredores;

WHILE @lowCO <= @highCO
BEGIN
	SELECT @Identificacion = Identificacion,
			@Nombre = Nombre,
			@Alias = Alias,
			@Email = Email,
			@Genero = Genero,
			@FechaNacimiento = FechaNacimiento
	FROM @Corredores WHERE ID = @lowCO;

	--EXEC dbo.CASP_InsertarCorredor 
END