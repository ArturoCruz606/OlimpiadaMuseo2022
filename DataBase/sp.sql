CREATE PROCEDURE altaExposicion	( ID_Sala INT,Nombre VARCHAR(45))
BEGIN
	INSERT INTO Exposicion	( ID_Sala,Nombre )
					VALUES ( unaSala, unNombre);
END

CREATE PROCEDURE altaObra	( DNI_Artista INT,ID_Exposicion INT,Nombre VARCHAR(45),
                                Descripcion VARCHAR(80),Tipo VARCHAR(45))
BEGIN
	INSERT INTO Obra ( DNI_Artista ,ID_Exposicion ,Nombre ,
                                Descripcion ,Tipo)                         
					VALUES ( unArtista,unaExposicion,unNombre,
                                unaDescripcion,unTipo )
END

CREATE PROCEDURE altaArtista( Nombre VARCHAR(45),Apellido VARCHAR(45),Nacimiento DATE)
BEGIN
	INSERT INTO Artista( Nombre,Apellido,Nacimiento)                         
					VALUES (  unNombre,unApellido,unNacimiento) 
END

CREATE PROCEDURE altaSala( ID_Museo INT, Nombre VARCHAR(45))
BEGIN
	INSERT INTO Sala(Museo , Nombre)                        
					VALUES (unMuseo, unNombre) 
END

CREATE PROCEDURE altaTurno( ID_Visita INT,DNI_Visitante INT,FechaHora DATETIME)
BEGIN
	INSERT INTO Turno( Visita,Visitante,FechaHora)                  
					VALUES (unaVisita,UnVisitante,UnaFechaHora) 
END





