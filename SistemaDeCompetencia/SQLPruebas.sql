insert into pais(nombrePais) values ('ARGENTINA');

insert into Provincia(nombreProvincia,PaisId) values ('BUENOS AIRES',1),('SANTA FE',1),('CORDOBA',1);

INSERT INTO Localidad(nombreLocalidad,ProvinciaId) VALUES ('GLEW',1),('BURZACO',1),('ADROGUE',1),
('SANTA FE',2),('RUFINO',2),('SAN CARLOS',2);

INSERT INTO Direccion(calle,numero,LocalidadId) VALUES ('MENDEZ',4890,1);

INSERT INTO TipoDocumento(NombreTipo) VALUES ('DNI');

INSERT INTO Usuario(Nombre,Apellido,NumeroDocumento,TipoDocumentoId,DireccionId)VALUES 
              ('JOSE','PEREZ',33333333,1,1);
INSERT INTO Login(correoElectronico,Contraseña,UsuarioId) VALUES ('A@GMAIL.COM','123',1);
INSERT INTO Deporte(Nombre) VALUES ('FUTBOL'),('VOLEY'),('TENIS'),('NATACION');
INSERT into LugarDeRealizacion(Nombre,UsuarioId)VALUES ('CLUB GUADALUPE',1),('SOCIEDAD ITALIANA',1),('LIVERPOOL',1)
, ('REGATA',1);
INSERT into Disponibilidad(Disponible,LugarId) VALUES (3,2),(15,3),(9,4),(10,1);
INSERT into DeporteLugar(LugarId ,DeporteId ) VALUES (2,4),(3,2),(4,3),(1,1); 
insert into DeporteLugar(LugarId ,DeporteId ) VALUES (2,2);
insert into DeporteLugar(LugarId ,DeporteId ) VALUES (3,1);

delete from Disponibilidad;
SELECT * FROM Deporte;
SELECT  *FROM LugarDeRealizacion ;

select * from Participante;
select * from Fecha;
select * from competencia;
select * from Fixture;

SET IDENTITY_INSERT Fixture ON
GO
INSERT INTO Fixture(FixtureId )
VALUES ( 1)
GO
/* Turn Identity Insert OFF  */
SET IDENTITY_INSERT Fixture OFF
GO

SET IDENTITY_INSERT Fecha ON
GO
insert into Fecha(FechaId,FechaCompentencia,FixtureId) values (1,'FECHA1',1),(2,'FECHA2',1),(3,'FECHA3',1);
go
/* Turn Identity Insert OFF  */
SET IDENTITY_INSERT Fecha OFF
GO
insert into Enfrentamiento(ParticipanteXId,ParticipanteYId,FechaId) values(1,2,1),(3,4,1),(1,3,2),(2,4,2),(1,4,3),(2,3,3);    


SET IDENTITY_INSERT Competencia ON
GO
insert into Competencia(CompetenciaId,Nombre,FixtureId,DeporteId,PermisoDeEmpate,UsuarioId,FormaDePuntuacionId) values (2,'LIBERTADORES',1,1,0,1,1);
go
/* Turn Identity Insert OFF  */
SET IDENTITY_INSERT competencia OFF
GO

select *from Competencia;
select *from deporte;
select *from fixture;
select *from fecha;
select *from Enfrentamiento;
select * from FormaDePuntuacion;
delete from fixture ;
select * from participante;

