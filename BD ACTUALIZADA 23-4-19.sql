CREATE DATABASE Proyecto_A
GO
USE Proyecto_A
GO

CREATE TABLE Usuarios
(
	Usuario CHAR(20) UNIQUE NOT NULL,
	Contraseña VARCHAR(20) NOT NULL,
	TipoUsuario VARCHAR(20) NOT NULL
)

CREATE TABLE Grados(
	IdGrados CHAR(20) PRIMARY KEY NOT NULL,
	NombreGrado VARCHAR(20)
)

CREATE TABLE Docentes
(
	IdDocente CHAR(20) PRIMARY KEY NOT NULL,
	Nombres VARCHAR(30) NOT NULL,
	Apellidos VARCHAR(30) NOT NULL,
	FechaNacimiento DATE NOT NULL,
	Dui VARCHAR(10) NOT NULL,
	Telefono VARCHAR(9) NOT NULL,
	Direccion TEXT NOT NULL,
	GradoResponsable CHAR(20) NOT NULL
)

CREATE TABLE Alumnos(
	IdAlumno CHAR(20) PRIMARY KEY,
	Nombres VARCHAR(30) NOT NULL,
	Apellidos VARCHAR(30) NOT NULL,
	FechaNacimiento DATE NOT NULL,
	NombreResponsable VARCHAR(30) NOT NULL,
	DuiResponsable VARCHAR(10) NOT NULL,
	Telefono VARCHAR(9) NOT NULL,
	Direccion TEXT NOT NULL,
	IdGrado CHAR(20)
)

CREATE TABLE Materias(
	IdMateria CHAR(20) PRIMARY KEY NOT NULL,
	NombreMateria VARCHAR(30) NOT NULL,
)

create table Notas
(
IdAlumno char(20) not null,
IdGrados CHAR(20) NOT NULL,
IdMateria CHAR(20) NOT NULL,
nota1 decimal not null,
nota2 decimal not null,
nota3 decimal not null,
promedio decimal not null,
constraint fk_Alumnos foreign key (IdAlumno) references Alumnos (IdAlumno),
constraint fk_Grados foreign key (IdGrados) references Grados (IdGrados),
constraint fk_Materia foreign key (IdMateria) references Materias (IdMateria) 
)


ALTER TABLE Alumnos
ADD CONSTRAINT FK_Alumno_Grado
FOREIGN KEY(IdGrado) REFERENCES Grados(IdGrados)
ON DELETE CASCADE
ON UPDATE CASCADE

ALTER TABLE Docentes
ADD CONSTRAINT FK_Docentes_Grado
FOREIGN KEY(GradoResponsable) REFERENCES Grados(IdGrados)
ON DELETE CASCADE 
ON UPDATE CASCADE


GO

CREATE PROCEDURE IdAlumno (@nombre varchar,@apellido varchar,@cadena varchar(20) OUTPUT)
AS
DECLARE @años INT
DECLARE @correlativo INT
SET @correlativo = (SELECT COUNT(*)+1 FROM Alumnos)
IF(@correlativo IS NULL)
BEGIN
SET @correlativo=1
END
SET @años= Right(Cast(Year(GETDATE()) As Char(4)),2)
SET @cadena = CONCAT('ES-',@nombre,@apellido,CONVERT(varchar,@años),CONVERT(varchar,@correlativo))
GO

--Procedimiento almacenado de Docentes

CREATE PROCEDURE IdDocente (@nombre varchar, @apellido varchar, @cadena varchar(20) OUTPUT)
AS
DECLARE @años INT
DECLARE @correlativo INT
SET @correlativo = (Select COUNT(*)+1 FROM Usuarios)
IF(@correlativo is null)
begin
set @correlativo=1
END
set @años= RIGHT(Cast(Year(GETDATE()) As Char(4)),2)
Set @cadena = CONCAT(@nombre,@apellido, CONVERT(varchar,@años),convert(varchar,@correlativo))
GO


INSERT INTO Grados VALUES ('PG1901','Primer Grado')
INSERT INTO Grados VALUES ('SG1902','Segundo Grado')
INSERT INTO Grados VALUES ('TG1903','Tercer Grado')
INSERT INTO Grados VALUES ('CG1904','Cuarto Grado')
INSERT INTO Grados VALUES ('QG1905','Quinto Grado')
INSERT INTO Grados VALUES ('SG1906','Sexto Grado')
GO

insert into Materias Values ('MAT19','Matematicas')
insert into Materias values ('LEN19','Lenguaje')
insert into Materias values ('CIE19','Ciencias')
insert into Materias values ('SOC19','Sociales')


CREATE PROCEDURE IngresoDocentes 
@Codigo CHAR(20),
@Nombres varchar(30),
@apellidos varchar(30),
@fech_N date,
@dui varchar (10),
@telefono varchar(9),
@direccion text,
@grado char(20)
as 
insert into Docentes VALUES (@Codigo,@Nombres, @apellidos, @fech_N, @dui, @telefono, @direccion, @grado)
go

INSERT INTO Usuarios VALUES ('Admin','1234','Director(a)')

Select * from Docentes

select * from Usuarios

select * from Grados

select * from Materias

SELECT * FROM Alumnos

Select * from Notas

select * from notas where IdAlumno = 'ES-BG191'
select Nombres + ' ' + Apellidos as NombreCompleto from Alumnos

select Nombres + ' ' + Apellidos as NombreCompleto from Alumnos where IdGrado = 'PG1901'
use Proyecto_A
select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria

select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria = 'MAT19' and D.IdGrados = 'SG1902'

Select Nombres + ' ' + Apellidos as Nombre_Completo, IdAlumno from Alumnos where IdGrado = 'PG1901'
Select Nombres, IdAlumno from Alumnos where IdGrado = 'PG1901'

select A.IdAlumno as Codigo, A.Nombres as Nombres, A.Apellidos AS Apellidos, A.FechaNacimiento as Fecha_de_nacimiento, A.NombreResponsable as Responsable, A.DuiResponsable as Dui_Responsable, A.Telefono as Telefono, A.Direccion as Direccion, B.NombreGrado as Grado from Alumnos as A inner join Grados as B on A.IdGrado = B.IdGrados where B.IdGrados = 'PG1901'