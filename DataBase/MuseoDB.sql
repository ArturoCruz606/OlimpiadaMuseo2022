DROP DATABASE IF EXISTS MuseoDB;
CREATE DATABASE IF NOT EXISTS MuseoDB;
USE MuseoDB;

CREATE TABLE Visitante (
	DNI INT NOT NULL,
    Nombre VARCHAR(45) NOT NULL,
    Apellido VARCHAR(45) NOT NULL,
    Nacimiento DATE NOT NULL,
    CONSTRAINT PK_Visitante PRIMARY KEY (DNI)
);

CREATE TABLE Guia (
    DNI INT NOT NULL,
    Nombre VARCHAR(45) NOT NULL,
    Apellido VARCHAR(45) NOT NULL,
    Nacimiento DATE NOT NULL,
    CONSTRAINT PK_Guia PRIMARY KEY (DNI)
);

CREATE TABLE Exposicion (
    ID_Exposicion INT NOT NULL,
    ID_Sala INT,
    Nombre VARCHAR(45),
    Tipo VARCHAR(45),
    CONSTRAINT PK_Exposicion PRIMARY KEY (ID_Exposicion),
    CONSTRAINT FK_Exposicion_Sala FOREIGN KEY (ID_Sala) REFERENCES Sala (ID_Sala)
);

CREATE TABLE Sala (
	ID_Sala INT NOT NULL AUTO_INCREMENT,
    Nombre VARCHAR(45),
    ID_Exposicion INT,
    CONSTRAINT PK_Sala PRIMARY KEY (ID_Sala ASC),
    CONSTRAINT FK_Sala_Exposicion FOREIGN KEY (ID_Exposicion) REFERENCES Exposicion (ID_Exposicion)
);

CREATE TABLE Visita (
    ID_Visita INT NOT NULL AUTO_INCREMENT,
    DNI_Guia INT,
    DNI_Visitante INT,
    ID_Sala INT,
    Fecha_Hora DATETIME,
    CONSTRAINT PK_Visita PRIMARY KEY (ID_Visita),
    CONSTRAINT FK_Visita_Guia FOREIGN KEY (DNI_Guia) REFERENCES Guia (DNI),
    CONSTRAINT FK_Visita_Visitante FOREIGN KEY (DNI_Visitante) REFERENCES Visita (DNI)
);

CREATE TABLE Turno (
    ID_Turno INT NOT NULL AUTO_INCREMENT,
    ID_Visita INT,
    DNI_Visitante INT,
    FechaHora DATETIME,
    CONSTRAINT PK_Turno PRIMARY KEY (ID_Turno),
    CONSTRAINT FK_Turno_Visita FOREIGN KEY (ID_Visita) REFERENCES Visita (ID_Visita),
    CONSTRAINT FK_Turno_Visitante FOREIGN KEY (DNI_Visitante) REFERENCES Visitante (DNI_Visitante) 
);

CREATE TABLE Fundador (
    DNI INT NOT NULL,
    Nombre VARCHAR(45) NOT NULL,
    Apellido VARCHAR(45) NOT NULL,
    Nacimiento DATE NOT NULL,
    CONSTRAINT PK_Guia PRIMARY KEY (DNI)
);

CREATE TABLE Museo (
    ID_Museo INT NOT NULL AUTO_INCREMENT,
    ID_Sala INT,
    DNI_Fundador INT,
    Nombre VARCHAR (45),
    Fundacion DATE,
    Direccion VARCHAR(45),
    CONSTRAINT PK_Museo PRIMARY KEY (ID_Museo),
    CONSTRAINT FK_Museo_Sala FOREIGN KEY (ID_Sala) REFERENCES Sala (ID_Sala), 
    CONSTRAINT FK_Museo_Fundador FOREIGN KEY (DNI_Fundador) REFERENCES Fundador (DNI)
);

CREATE TABLE Plano (
    ID_Plano INT NOT NULL AUTO_INCREMENT,
    ID_Museo INT,
    Nombre VARCHAR (45),
    Descripcion VARCHAR (80),
    CONSTRAINT PK_Plano PRIMARY KEY (ID_Plano),
    CONSTRAINT FK_Plano_Museo FOREIGN KEY (ID_Museo) REFERENCES Museo (ID_Museo) 
);