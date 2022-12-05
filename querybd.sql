--create database PasaportesDB
--go


--use PasaportesDB
--go

create table Impuestos(
ImpuestoID int primary key identity(1,1),
ImpuestoDescripcion varchar(50) ,
ImpuestoCodigo varchar(50),
ImpuestoEstado int foreign key references Estado(EstadoID))

create table Oficinas(
OficinaID int primary key identity(1,1),
OficinaNombre varchar(50),
OficinaTelefono varchar(12),
OficinaDireccion varchar(max),
OficinaEstado int foreign key references Estado(EstadoID))

create table Estado(
EstadoID int primary key identity(1,1),
EstadoNombre varchar(50),
EstadoTipo varchar(50),
EstadoCodigo varchar(50))

create table Pagos(
PagoID int primary key identity(1,1),
PagoMonto decimal (18,2),
PagoRecibo varchar(100),
PagoFecha datetime,
PagoReferencia varchar(100),
PagoMetodo varchar(100),
PagoCreacion datetime,
PagoImagen image,
PagoEstado int foreign key references Estado(EstadoID))

create table Usuarios(
UsuarioID int primary key identity(1,1),
UsuarioLogin varchar(50),
UsuarioPassword varchar(8000),
UsuarioHash varchar (100),
UsuarioSalt varchar (100),
UsuarioNombre varchar(50),
UsuarioApellido varchar(50),
UsuarioCedula varchar(13),
UsuarioCorreo varchar(100),
UsuarioSexo varchar(1),
UsuarioTelefono varchar(12),
UsuarioCelular varchar(12),
UsuarioFechaCreacion datetime,
UsuarioEstadoID int foreign key references Estado(EstadoID),
UsuarioRolID int foreign key references Roles(RolID),
PasaporteID int references Pasaportes(PasaporteID))

create table Pasaportes(
PasaporteID int primary key identity(1,1),
PasaporteDescripcion varchar(100),
PasaporteCodigo varchar(20),
PasaporteNombre varchar(50),
PasaporteApellido varchar(50),
PasaporteCedula varchar(13),
PasaporteCorreo varchar(100),
PasaporteDireccion varchar(400),
PasaporteFechaCreacion datetime,
PasaporteSolicitudID int foreign key references Solicitudes(SolicitudID), 
PasaporteEstadoID int foreign key references Estado(EstadoID),
PasaporteImage image)

create table Roles(
RolID int primary key identity(1,1),
RolNombre varchar(50),
RolDescripcion varchar(50))

create table Solicitudes(
SolicitudID int primary key identity(1,1),
SolicitudNombre varchar (50),
SolicitudFecha datetime,
SolicitudFechaCreacion datetime,
SolicitudFechaModificacion datetime,
SolicitudEstado int foreign key references Estado(EstadoID))

create table LogsSolicitudes(
LogID int primary key identity (1,1),
LogDescripcion varchar(50),
LogFecha datetime,
LogSolicitudesID int foreign key references Solicitudes(SolicitudID))