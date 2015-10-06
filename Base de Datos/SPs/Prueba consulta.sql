SELECT CC.Numero, CO.Nombre, CA.Nombre FROM CampeonatosXCorredores CC
INNER JOIN Corredores CO
ON CO.ID = CC.FKCorredor
INNER JOIN Campeonatos CA
ON CA.ID = CC.FKCampeonato
WHERE CC.FKCorredor = 251;
GO

