DECLARE @command NVARCHAR(500), @xmlPath NVARCHAR(300);
DECLARE @lowCO INT, @highCO INT, @lowCA INT, @highCA INT;
DECLARE @xmlDocument XML;

DECLARE @IDCampeonato INT, @nombreCampeonato VARCHAR(100), @FechaI DATE, @FechaF DATE;

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
FROM @xmlDocument.nodes('Campeonato') AS CA(Campeonato);

EXEC @IDCampeonato = 
	@nombreCampeonato, @FechaI, @FechaF;