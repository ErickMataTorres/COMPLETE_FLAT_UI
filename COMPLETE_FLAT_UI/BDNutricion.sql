SELECT * FROM TablaConsultar WHERE Nombre_Paciente COLLATE SQL_LATIN1_GENERAL_CP1_CI_AI LIKE '%Jose manuel%' ORDER BY Fecha DESC
INSERT INTO TablaPacientes VALUES(1,'NICA NICA NICA','11111111111',SYSDATETIME(),31,SYSDATETIME(),'NINGUNA','NINGUNO','NINGUNO','SANO','ACTIVA',SYSDATETIME())
DELETE FROM TablaPacientes
SELECT * FROM TablaCitas
SELECT SYSDATETIME()
create database BDNutricion
go
use BDNutricion
go
create table TablaReservarCita
(
	Id int not null primary key,
	Nombre varchar(50) not null,
	Telefono varchar(20) not null,
	Fecha_Nacimiento date not null,
	Edad int not null,
	Fecha varchar(50) not null,
	Enfermedad varchar(100) not null,
	Antecedentes_Familiares varchar(100),
	Medicamento varchar(100),
	Diagnostico varchar(50),
	Actividad_Fisica varchar(100),
	Cita dateTIME,
	Hora VARCHAR(10),
	unique(Cita,Hora)
)
go
alter PROCEDURE spReservarCita
@Id int,
@Nombre varchar(50),
@Telefono varchar(20),
@Fecha_Nacimiento date,
@Edad int,
@Enfermedad varchar(100),
@Antecedentes_Familiares varchar(100),
@Medicamento varchar(100),
@Diagnostico varchar(50),
@Actividad_Fisica varchar(100),
@Cita datetime,
@Hora varchar(10)
as
Begin

	SELECT Id=isnull(MAX(Id+1),1) from TablaReservarCita
	IF NOT EXISTS (SELECT Id from TablaReservarCita where Id=@Id)
		Insert into TablaReservarCita values(@Id,@Nombre,@Telefono,@Fecha_Nacimiento,@Edad,SYSDATETIME(),@Enfermedad,@Antecedentes_Familiares,@Medicamento,@Diagnostico,@Actividad_Fisica,@Cita,@Hora)
	ELSE
		UPDATE TablaReservarCita SET Nombre=@Nombre,Telefono=@Telefono,Fecha_Nacimiento=@Fecha_Nacimiento,Edad=@Edad,Fecha=Fecha,Enfermedad=@Enfermedad,Antecedentes_Familiares=@Antecedentes_Familiares,Medicamento=@Medicamento,Diagnostico=@Diagnostico,Actividad_Fisica=@Actividad_Fisica,Cita=@Cita,Hora=@Hora WHERE Id=@Id
End
CREATE PROCEDURE spEliminarCita
@Id int
as
Begin
	DELETE FROM TablaReservarCita WHERE Id=@Id
END


Insert into TablaConsultar values(1,'a',SYSDATETIME(),22,'nada','nada','2.00','100','2','2','2','2','2','2',1,SYSDATETIME(),'nada')

create table TablaConsultar
(
	IdPaciente int not null  primary key references TablaReservarCita(Id) on delete no action on update no action,
	Nombre_Paciente varchar (50) not null,
	Fecha_Nacimiento date not null,
	Edad int not null,
	Actividad_Fisica varchar(100),
	Diagnostico varchar(50),
	Estatura varchar(100),
	Peso varchar(100) not null,
	Brazo varchar(10) not null,
	Cintura varchar(10) not null,
	Cadera varchar(10) not null,
	Busto varchar(10) not null,
	Estomago varchar(10) not null,
	Complexion varchar(50),
	Dieta int,
	Fecha dateTIME not null,
	Tratamiento varchar(10),
	IMC varchar(100) not null
)

--- Y SI TIENES QUE CONVERTILO?? Es que se supone que ya lo saca en decimal DEJA EN CHART?? ¿Como? ENVES DE DECIMAL QUE SEA CHAR EMMMM
ALTER PROCEDURE spGuardarConsulta
@IdPaciente int,
@Nombre_Paciente varchar(50),
@Fecha_Nacimiento date,
@Edad int,
@Actividad_Fisica varchar(100),
@Diagnostico varchar(50),
@Estatura varchar(100),
@Peso varchar(100),
@Brazo varchar(10),
@Cintura varchar(10),
@Cadera varchar(10),
@Busto varchar(10),
@Estomago varchar(10),
@Complexion varchar(50),
@Dieta int,
--@Fecha datetime,
@Tratamiento varchar(10),
@IMC varchar(100)
AS
BEGIN
	SELECT @IdPaciente=ISNULL(MAX(IdPaciente+1),1) FROM TablaConsultar
	IF NOT EXISTS(SELECT IdPaciente FROM TablaConsultar WHERE IdPaciente=@IdPaciente)
		INSERT INTO TablaConsultar VALUES(@IdPaciente,@Nombre_Paciente,@Fecha_Nacimiento,@Edad,@Actividad_Fisica,@Diagnostico,@Estatura,@Peso,@Brazo,@Cintura,@Cadera,@Busto,@Estomago,@Complexion,@Dieta,SYSDATETIME(),@Tratamiento,@IMC)
	ELSE
		UPDATE TablaConsultar SET Nombre_Paciente=@Nombre_Paciente,Fecha_Nacimiento=@Fecha_Nacimiento,Edad=@Edad,Actividad_Fisica=@Actividad_Fisica,Diagnostico=@Diagnostico,Estatura=@Estatura,Peso=@Peso,Brazo=@Brazo,Cintura=@Cintura,Cadera=@Cadera,Busto=@Busto,Estomago=@Estomago,Complexion=@Complexion,Dieta=@Dieta,Fecha=SYSDATETIME(),Tratamiento=@Tratamiento,IMC=@IMC WHERE IdPaciente=@IdPaciente
END
CREATE PROCEDURE spCargarCita
@Id INT
AS
BEGIN
IF EXISTS(SELECT Id FROM TablaReservarCita WHERE Id=@Id)
	IF EXISTS(SELECT IdPaciente FROM TablaConsultar WHERE IdPaciente=@Id AND Tratamiento!=NULL)
		SELECT * FROM TablaConsultar WHERE IdPaciente=@Id
	ELSE
		SELECT * FROM TablaReservarCita WHERE Id=@Id
END
--No modifica? SII MIRA

Select * from TablaConsultar

CREATE TABLE TablaHistorial
(
IdPaciente int not null,
Nombre_Paciente varchar(50),
Edad int,
Estatura varchar(10),
Peso varchar(10),
Brazo varchar(10),
Cintura varchar(10),
Cadera varchar(10),
Busto varchar(10),
Estomago varchar(10),
Fecha datetime not null,
Complexion varchar(50),
IMC varchar(100),
PRIMARY KEY(IdPaciente, Fecha)
)
create trigger Historial_AIU
ON TablaConsultar
AFTER INSERT,UPDATE
AS
BEGIN	
	Declare @Historial int
	select top(1) @Historial= IdPaciente from TablaConsultar order by Fecha desc
	Insert into TablaHistorial(IdPaciente,Nombre_Paciente,Edad,Estatura,Peso,Brazo,Cintura,Cadera,Busto,Estomago,Fecha,Complexion,IMC)Select IdPaciente,Nombre_Paciente,Edad,Estatura,Peso,Brazo,Cintura,Cadera,Busto,Estomago,Fecha,Complexion,IMC from TablaConsultar where IdPaciente=@Historial
END


	Insert into TablaHistorial(IdPaciente,Nombre_Paciente,Edad,Estatura,Peso,Brazo,Cintura,Cadera,Busto,Estomago,Fecha,Complexion) Select top(1)IdPaciente,Nombre_Paciente,Edad,Estatura,Peso,Brazo,Cintura,Cadera,Busto,Estomago,Fecha,Complexion from TablaConsultar order by Fecha


select * from TablaHistorial where IdPaciente=1 order by Fecha desc

Select * from TablaHistorial where IdPaciente=2


INSERT INTO TablaConsultar values(3,'b',SYSDATETIME(),22,'Nada','Nada',2.01,113,'40','80','120','120','50','Robusta',1,SYSDATETIME(),'erick',(Estatura^2)/Peso)

UPDATE [dbo].[TablaConsultar]
   SET [IdPaciente] = 1
      ,[Nombre_Paciente] = 'a'
      ,[Fecha_Nacimiento] = SYSDATETIME()
      ,[Edad] = 22
      ,[Actividad_Fisica] = 'nada'
      ,[Diagnostico] = 'nada'
      ,[Estatura] = '2.01'
      ,[Peso] = '113'
      ,[Brazo] = '1'
      ,[Cintura] = '1'
      ,[Cadera] = '1'
      ,[Busto] = '1'
      ,[Estomago] ='1'
      ,[Complexion] = 'Robusta'
      ,[Dieta] = 1
      ,[Fecha] = SYSDATETIME()
      ,[Tratamiento] ='Ninguno'
 WHERE IdPaciente=1

delete from TablaHistorial
delete from TablaConsultar

Create table TablaCitas
(
IdPaciente int,
Nombre varchar(50) not null,
Cita date,
Hora varchar(10),
unique(Cita,Hora)
)
Select * from TablaCitas
CREATE TRIGGER TR_TablaCitas_IDU
ON TablaReservarCita
AFTER INSERT,DELETE,UPDATE
AS
BEGIN
		Delete from TablaCitas
		IF EXISTS(SELECT Id FROM TablaReservarCita)
			INSERT INTO TablaCitas Select Id,Nombre,Cita,Hora from TablaReservarCita
END


Select * from TablaCitas
CREATE TABLE TablaDieta
(
IdDieta int not null,
Dia varchar(30),
TipoDeComida varchar(20),
Contenido varchar(1000),
primary key(IdDieta,Dia,TipoDeComida)
)
Select Dia, TipoDeComida, Contenido from TablaDieta where TipoDeComida='Desayuno'

CREATE TABLE TablaRecetas
(
IdReceta INT NOT NULL,
Tipo VARCHAR(20) NOT NULL,
Nombre VARCHAR(100) NOT NULL,
Contenido VARCHAR(1000) NOT NULL,
PRIMARY KEY(IdReceta)
)
CREATE TABLE TablaTiposDietas
(
Id int not null primary key,
Nombre varchar(100) not null
)
CREATE PROCEDURE spGuardarReceta
@IdReceta int,
@Tipo varchar(20),
@Nombre varchar(100),
@Contenido varchar(1000)
AS
BEGIN
SELECT @IdReceta=ISNULL(MAX(IdReceta+1),1) FROM TablaRecetas WHERE Tipo=@Tipo
IF NOT EXISTS(SELECT IdReceta FROM TablaRecetas WHERE IdReceta=@IdReceta)
	INSERT INTO TablaRecetas VALUES(@IdReceta,@Tipo,@Nombre,@Contenido)
ELSE
	UPDATE TablaRecetas SET Nombre=@Nombre,Contenido=@Contenido WHERE Tipo=@Tipo AND IdReceta=@IdReceta
END



alter procedure ConsultaPivot
@IdDieta int
as
Begin
Select * from
(
Select Dia,TipoDeComida,Contenido from TablaDieta where IdDieta=1
)S
pivot(
max(Contenido)
for[TipoDeComida] in ([Desayuno],[Comida],[Cena])
)P
End


CREATE PROCEDURE spValidaCita
@Cita DATE,
@Hora VARCHAR(10)
AS
BEGIN
	SELECT * FROM TablaCitas WHERE Cita=@Cita AND Hora=@Hora
END

ALTER PROCEDURE spConsultaHistorialTexto
@Texto VARCHAR(100),
@Desde DATE,
@Hasta DATE,
@Opcion INT
AS
BEGIN
	IF @Opcion=1
		SELECT * FROM TablaHistorial WHERE Nombre_Paciente COLLATE SQL_LATIN1_GENERAL_CP1_CI_AI LIKE '%'+@Texto+'%' ORDER BY Fecha DESC
	ELSE
		SELECT * FROM TablaHistorial WHERE Fecha BETWEEN @Desde AND @Hasta AND Nombre_Paciente COLLATE SQL_LATIN1_GENERAL_CP1_CI_AI LIKE '%'+@Texto+'%' ORDER BY Fecha DESC
END

ALTER PROCEDURE spGuardarDieta
@IdDieta INT,
@Dia VARCHAR(30),
@Desayuno VARCHAR(1000),
@Comida VARCHAR(1000),
@Cena VARCHAR(1000)
AS
BEGIN
	IF NOT EXISTS(SELECT IdDieta FROM TablaDietaPivot WHERE IdDieta=@IdDieta AND Dia=@Dia)
		INSERT INTO TablaDietaPivot VALUES (@IdDieta,@Dia,@Desayuno,@Comida,@Cena)
	ELSE
		UPDATE TablaDietaPivot SET  Dia=@Dia,Desayuno=@Desayuno,Comida=@Comida,Cena=@Cena WHERE IdDieta=@IdDieta AND Dia=@Dia
END

CREATE TABLE TablaDietaPivot
(
IdDieta INT,
Dia VARCHAR(30),
Desayuno VARCHAR(1000),
Comida VARCHAR(1000),
Cena VARCHAR(1000)
)

alter procedure ConsultaPivot
@IdDieta int
as
Begin
Select * from
(
Select Dia,TipoDeComida,Contenido from TablaDieta where IdDieta=1
)S
pivot(
max(Contenido)
for[TipoDeComida] in ([Desayuno],[Comida],[Cena])
)P
End


CREATE TRIGGER TR_TablaDietaPivot_IDU
ON TablaDietaPivot
AFTER INSERT,DELETE,UPDATE
AS
BEGIN
Select * from
(
Select IdDieta,Dia,Contenido,TipoDeComida from TablaDieta
)S
pivot(
max(Contenido)
for[TipoDeComida] in ([Desayuno],[Comida],[Cena])
)P
UNPIVOT(
	Contenido
	for [TipoDeComida] in([Desayuno],[Comida],[Cena])
)U
END

ALTER PROCEDURE spCargarCita
@Id INT
AS
BEGIN
IF NOT EXISTS(SELECT IdPaciente FROM TablaConsultar WHERE IdPaciente=@Id)
	SELECT * FROM TablaReservarCita WHERE Id=@Id
ELSE
	SELECT * FROM TablaConsultar WHERE IdPaciente=@Id
END