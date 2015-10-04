USE Campeonatos;
GO

CREATE TABLE Campeonato(
ID INT IDENTITY(1, 1) NOT NULL,
Nombre VARCHAR(100),
FechaInicio DATE,
FechaFin DATE
PRIMARY KEY(ID)
);
GO

CREATE TABLE Carreras(
ID INT IDENTITY(1, 1) NOT NULL,
Nombre VARCHAR(100),
Descripcion VARCHAR(200),
Fecha DATE,
FKCampeonato INT,
PRIMARY KEY(ID),
FOREIGN KEY(FKCampeonato) REFERENCES Campeonato(ID)
);
GO

CREATE TABLE Corredores(
ID INT IDENTITY(1, 1) NOT NULL,
Identificacion INT,
Nombre VARCHAR(50),
Alias VARCHAR(50),
Email VARCHAR(100),
Genero VARCHAR(10),
FechaNacimiento DATE,
Activo BIT,
PRIMARY KEY(ID)
);
GO

CREATE TABLE CampeonatoXCorredor(
ID INT IDENTITY(1, 1) NOT NULL,
Numero INT,
TiempoAcumulado FLOAT,
PuntosAcumulados INT,
PuntosSancionAcumulados INT,
FKCampeonato INT,
FKCorredor INT,
PRIMARY KEY(ID),
FOREIGN KEY(FKCampeonato) REFERENCES Campeonato(ID),
FOREIGN KEY(FKCorredor) REFERENCES Corredores(ID)
);
GO

CREATE TABLE TipoSancion(
ID INT IDENTITY(1, 1) NOT NULL,
Nombre VARCHAR(50),
PRIMARY KEY (ID)
);
GO

CREATE TABLE Sanciones(
ID INT IDENTITY(1, 1) NOT NULL,
Puntos INT,
FKCarrera INT,
FKTipoSancion INT,
PRIMARY KEY (ID),
FOREIGN KEY (FKCarrera) REFERENCES Carreras (ID),
FOREIGN KEY (FKTipoSancion) REFERENCES TipoSancion (ID)
);
GO

CREATE TABLE TipoMovimientoSancion(
ID INT IDENTITY(1, 1)NOT NULL,
Nombre VARCHAR(50),
PRIMARY KEY(ID)
);
GO

CREATE TABLE MovimientosPorSancion(
ID INT IDENTITY(1, 1) NOT NULL,
Monto INT,
PostIn VARCHAR(50),
PostBy VARCHAR(50),
PostDate DATE,
FKCampeonatoXCorredor INT,
FKSancion INT,
FKTipoMovimientoSancion INT,
PRIMARY KEY(ID),
FOREIGN KEY (FKCampeonatoXCorredor) REFERENCES CampeonatoXCorredor(ID),
FOREIGN KEY (FKSancion) REFERENCES Sanciones (ID),
FOREIGN KEY(FKTipoMovimientoSancion) REFERENCES TipoMovimientoSancion(ID)
);
GO

CREATE TABLE TipoMovimientoPuntos(
ID INT IDENTITY(1, 1) NOT NULL,
Nombre VARCHAR(50),
PRIMARY KEY(ID)
);
GO

CREATE TABLE Posicion(
ID INT IDENTITY(1, 1) NOT NULL,
Tiempo FLOAT,
FKCarrera INT,
FKCorredor INT,
PRIMARY KEY (ID),
FOREIGN KEY (FKCarrera) REFERENCES Carreras(ID),
FOREIGN KEY (FKCorredor) REFERENCES Corredores(ID)
);
GO

CREATE TABLE MovimientoPuntos(
ID INT IDENTITY(1, 1) NOT NULL,
Monto INT,
PostIn VARCHAR(50),
PostBy VARCHAR(50),
PostDate DATE,
FKPosicion INT,
FKTipoMovimientoPuntos INT,
FKCampeonatoXCorredor INT,
PRIMARY KEY (ID),
FOREIGN KEY (FKPosicion) REFERENCES Posicion (ID),
FOREIGN KEY (FKTipoMovimientoPuntos) REFERENCES TipoMovimientoPuntos(ID),
FOREIGN KEY (FKCampeonatoXCorredor) REFERENCES CampeonatoXCorredor(ID)
);
GO