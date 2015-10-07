CREATE PROCEDURE CASP_ObtenerCampeonatos
AS
BEGIN
	SELECT C.ID, C.Nombre, C.FechaInicio, C.FechaFin
	FROM Campeonatos C;
END
GO

CREATE PROCEDURE CASP_ObtenerCarrerasPorCampeonato
	@pIDCampeonato INT
AS
BEGIN
	SELECT C.ID, C.Descripcion, C.LugarPartida, C.LugarLLegada, C.Recorrido, C.Fecha, C.Hora, C.Costo
	FROM dbo.Carreras C
	WHERE C.FKCampeonato = @pIDCampeonato;
END
GO

CREATE PROCEDURE CASP_ObtenerTodasCarreras
AS
BEGIN
	SELECT C.ID, CA.Nombre, C.Descripcion, C.LugarPartida, C.LugarLLegada, C.Recorrido, C.Fecha, C.Hora, C.Costo
	FROM dbo.Carreras C 
	INNER JOIN Campeonatos CA
	ON CA.ID = C.FKCampeonato
END