CREATE DATABASE CampeonatosDB;
GO

USE CampeonatosDB;
GO

CREATE TABLE Campeonatos(
ID INT IDENTITY(1, 1) NOT NULL,
Nombre VARCHAR(100),
FechaInicio DATE,
FechaFin DATE,
Activo BIT DEFAULT 1,
PRIMARY KEY(ID)
);
GO

CREATE TABLE Carreras(
ID INT IDENTITY(1, 1) NOT NULL,
Descripcion VARCHAR(200),
LugarPartida VARCHAR(100),
LugarLlegada VARCHAR(100),
Recorrido FLOAT,
Fecha DATE,
Hora TIME,
Costo INT,
FKCampeonato INT,
Activo BIT DEFAULT 1,
PRIMARY KEY(ID),
FOREIGN KEY(FKCampeonato) REFERENCES Campeonatos(ID)
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
Activo BIT DEFAULT 1,
PRIMARY KEY(ID)
);
GO

CREATE TABLE CampeonatosXCorredores(
ID INT IDENTITY(1, 1) NOT NULL,
Numero INT,
TiempoAcumulado TIME,
PuntosAcumulados INT,
PuntosSancionAcumulados INT,
FKCampeonato INT,
FKCorredor INT,
Activo BIT DEFAULT 1,
PRIMARY KEY(ID),
FOREIGN KEY(FKCampeonato) REFERENCES Campeonatos(ID),
FOREIGN KEY(FKCorredor) REFERENCES Corredores(ID)
);
GO

CREATE TABLE TipoSancion(
ID INT IDENTITY(1, 1) NOT NULL,
Nombre VARCHAR(50),
Activo BIT DEFAULT 1,
PRIMARY KEY (ID)
);
GO

CREATE TABLE Sanciones(
ID INT IDENTITY(1, 1) NOT NULL,
Puntos INT,
FKCarrera INT,
FKTipoSancion INT,
Activo BIT DEFAULT 1,
PRIMARY KEY (ID),
FOREIGN KEY (FKCarrera) REFERENCES Carreras (ID),
FOREIGN KEY (FKTipoSancion) REFERENCES TipoSancion (ID)
);
GO

CREATE TABLE TipoMovimientoSancion(
ID INT IDENTITY(1, 1)NOT NULL,
Nombre VARCHAR(50),
Activo BIT DEFAULT 1,
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
Activo BIT DEFAULT 1,
PRIMARY KEY(ID),
FOREIGN KEY (FKCampeonatoXCorredor) REFERENCES CampeonatosXCorredores(ID),
FOREIGN KEY (FKSancion) REFERENCES Sanciones (ID),
FOREIGN KEY(FKTipoMovimientoSancion) REFERENCES TipoMovimientoSancion(ID)
);
GO

CREATE TABLE TipoMovimientoPuntos(
ID INT IDENTITY(1, 1) NOT NULL,
Nombre VARCHAR(50),
Activo BIT DEFAULT 1,
PRIMARY KEY(ID)
);
GO

CREATE TABLE Posiciones(
ID INT IDENTITY(1, 1) NOT NULL,
Posicion INT,
Tiempo TIME,
FKCarrera INT,
FKCorredor INT,
Activo BIT DEFAULT 1,
PRIMARY KEY (ID),
FOREIGN KEY (FKCarrera) REFERENCES Carreras(ID),
FOREIGN KEY (FKCorredor) REFERENCES Corredores(ID)
);
GO

CREATE TABLE MovimientosPuntos(
ID INT IDENTITY(1, 1) NOT NULL,
Monto INT,
PostIn VARCHAR(50),
PostBy VARCHAR(50),
PostDate DATE,
FKPosicion INT,
FKTipoMovimientoPuntos INT,
FKCampeonatoXCorredor INT,
Activo BIT DEFAULT 1,
PRIMARY KEY (ID),
FOREIGN KEY (FKPosicion) REFERENCES Posiciones(ID),
FOREIGN KEY (FKTipoMovimientoPuntos) REFERENCES TipoMovimientoPuntos(ID),
FOREIGN KEY (FKCampeonatoXCorredor) REFERENCES CampeonatosXCorredores(ID)
);
GO