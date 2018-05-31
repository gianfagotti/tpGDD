
USE [GD1C2018]
GO

-----------------------	 CREACIÓN DE SCHEMA   -----------------------

CREATE SCHEMA FAGD AUTHORIZATION dbo
GO

-----------------------	 CREACIÓN DE TABLAS   ----------------------- 

CREATE TABLE FAGD.Hotel (
	hotel_codigo numeric (10,0) IDENTITY (1,1) NOT NULL,
	hotel_cantEstrellas numeric(1,0) NOT NULL,
	hotel_recarga_estrellas numeric(10,2) NOT NULL ,
	hotel_pais varchar(50) NULL,
	hotel_ciudad varchar(50) NOT NULL,
	hotel_calle varchar(50) NOT NULL,
	hotel_nroCalle numeric(18,0) NOT NULL,
	hotel_nombre varchar(50) NULL,
	hotel_fechaDeCreacion datetime  NULL,
	hotel_mail varchar(50) NULL,
	hotel_telefono numeric(18,0) NULL,
	hotel_estado bit NOT NULL default(1)
)
GO

CREATE TABLE FAGD.Habitacion(
	habitacion_codigoHotel numeric (10,0) NOT NULL,
	habitacion_nro numeric (4,0) NOT NULL,
	habitacion_tipoCodigo numeric (10,0) NOT NULL,
	habitacion_piso numeric (3,0) NOT NULL,
	habitacion_ubicacion varchar(10) NOT NULL,
	habitacion_descripcion varchar(255) NULL,
	habitacion_estado bit NOT NULL default(1)
	)
GO


CREATE TABLE FAGD.HabitacionTipo(
	habitacionTipo_codigo numeric(10) NOT NULL,
	habitacionTipo_descripcion varchar(50) NOT NULL,
	habitacionTipo_porcentual numeric(10,2) NOT NULL
)


CREATE TABLE FAGD.Reserva(
	reserva_codigo numeric(10) NOT NULL,
	reserva_fechaRealizada datetime,
	reserva_fechaInicio datetime NOT NULL,
	reserva_fechaFin datetime,
	reserva_cantNoches numeric(5) NOT NULL,
	reserva_estado varchar(50),
	reserva_codigoRegimen numeric(1),
	reserva_clienteNroDocumento numeric(18),
	reserva_nombreUsuario varchar(50),
	reserva_codigoHotel numeric (10,0),
	reserva_nroHabitacion numeric (4,0)
)
GO

CREATE TABLE FAGD.ReservaCancelada(
	reservaCancelada_codigo numeric (10) IDENTITY (1,1) NOT NULL,
	reservaCancelada_motivo varchar(50),
	reservaCancelada_fechaCancelacion datetime,
	reservaCancelada_nombreUsuario varchar(50),
	reservaCancelada_codigoReserva numeric (10)
)
GO

CREATE TABLE FAGD.Regimen(
	regimen_codigo numeric(10) IDENTITY (1,1) NOT NULL,
	regimen_descripcion varchar (50) NOT NULL,
	regimen_precioBase numeric (10,2) NOT NULL,
	regimen_estado bit NOT NULL default(1)
)

CREATE TABLE FAGD.Usuario(
	usuario_username varchar(50),
	usuario_password varchar(50),
	usuario_nombre varchar(50),
	usuario_apellido varchar(50),
	usuario_direccion varchar(50),
	usuario_mail varchar(50) UNIQUE,
	usuario_telefono numeric(18),
	usuario_fechaNacimiento datetime,
	usuario_estado bit NOT NULL default(1)
)
GO

CREATE TABLE FAGD.UsuarioXHotel(
	usuario_username varchar(50),
	hotel_codigo numeric (10)
)
GO

CREATE TABLE FAGD.UsuarioXRol(
	usuario_username varchar(50),
	rol_codigo numeric(10),
)
GO

CREATE TABLE FAGD.Rol(
	rol_codigo numeric(10) IDENTITY (1,1),
	rol_nombre varchar(50),
	rol_estado bit NOT NULL default(1)
)
GO

CREATE TABLE FAGD.RolXFuncionalidad(
	rol_codigo numeric(10),
	funcionalidad_codigo numeric(10)
)
GO

CREATE TABLE FAGD.Funcionalidad(
	funcionalidad_codigo numeric (10) IDENTITY (1,1),
	funcionalidad_detalle varchar (50)
)
GO

CREATE TABLE FAGD.ItemFactura(
 itemFactura_nro numeric(18),
 itemConsumible_codigo numeric(18),
 itemEstadia_codigo numeric(18),
 itemConsumible_cantidad numeric(5),
 itemConsumisiones_total numeric (10,2)
) GO

CREATE TABLE FAGD.Factura(
 factura_nro numeric(18),
 factura_fecha datetime,
 factura_total numeric(10,2),
 factura_estado numeric(1),
 factura_documentoCliente numeric(18)
) GO

CREATE TABLE FAGD.Pago(
 pago_facturaNro numeric(18),
 pago_tipo numeric(2),
 pago_descripcion varchar(50),
 pago_fecha datetime
) GO


CREATE TABLE FAGD.Cliente(
 cliente_nroDocumento numeric(18),
 cliente_apellido varchar(50),
 cliente_nombre varchar(50),
 cliente_fechaNac datetime,
 cliente_mail varchar(50),
 cliente_nacionalidad varchar(50),
 cliente_nroCalle numeric(5),
 cliente_piso numeric(3),
 cliente_dpto varchar(5),
 cliente_tipoDocumento varchar(5),
 cliente_telefono numeric(18),
 cliente_localidad varchar(50),
 cliente_estado bit NOT NULL default(1)
) GO

CREATE TABLE FAGD.ErrorCliente(
 errorCliente_nroDocumento numeric(18),
 errorCliente_apellido varchar(50),
 errorCliente_nombre varchar(50),
 errorCliente_fechaNac datetime,
 errorCliente_mail varchar(50),
 errorCliente_nacionalidad varchar(50),
 errorCliente_nroCalle numeric(5),
 errorCliente_piso numeric(3),
 errorCliente_dpto varchar(5),
 errorCliente_tipoDocumento varchar(5),
 errorCliente_telefono numeric(18),
 errorCliente_localidad varchar(50),
 errorCliente_estado bit NOT NULL default(1)
)
GO

CREATE TABLE FAGD.Consumible(
consumible_codigo numeric (10) IDENTITY (1,1),
consumible_descripcion varchar(50),
consumible_precio numeric (5,2) 
)
GO

CREATE TABLE FAGD.ConsumibleXEstadia(
consumible_codigoConsumible numeric(10),
consumible_cantidad numeric(3),
estadia_codigoEstadia numeric(10)
)
GO

CREATE TABLE FAGD.Estadia(
estadia_codigo numeric(10) IDENTITY(1,1),
estadia_fechaInicio datetime,
estadia_cantNoches numeric (5),
estadia_NroDocumentoCliente numeric (18),
estadia_CodigoReserva numeric (10)
)
GO

---------------------------------- CREACIÓN PRIMARY KEYS ---------------------------------------

ALTER TABLE FAGD.Hotel ADD CONSTRAINT PK_Hotel
	PRIMARY KEY CLUSTERED (hotel_codigo)
GO

ALTER TABLE FAGD.HabitacionTipo ADD CONSTRAINT PK_HabitacionTipo
	PRIMARY KEY CLUSTERED (habitacionTipo_codigo)
GO

ALTER TABLE FAGD.Usuario ADD CONSTRAINT PK_Usuario
	PRIMARY KEY CLUSTERED (usuario_username)
GO

ALTER TABLE FAGD.Rol ADD CONSTRAINT PK_Rol
	PRIMARY KEY CLUSTERED (rol_codigo)
GO

ALTER TABLE FAGD.Funcionalidad ADD CONSTRAINT PK_Funcionalidad
	PRIMARY KEY CLUSTERED (funcionalidad_codigo)
GO

ALTER TABLE FAGD.ReservaCancelada ADD CONSTRAINT PK_Reserva_cancelada
	PRIMARY KEY CLUSTERED (reservaCancelada_codigo)
GO

ALTER TABLE FAGD.Reserva ADD CONSTRAINT PK_Reserva
	PRIMARY KEY CLUSTERED (reserva_codigo)
GO

ALTER TABLE FAGD.Habitacion ADD CONSTRAINT PK_Habitacion
	PRIMARY KEY CLUSTERED (habitacion_codigo)
GO

ALTER TABLE FAGD.Regimen ADD CONSTRAINT PK_Regimen
	PRIMARY KEY CLUSTERED (regimen_codigo)
GO

ALTER TABLE FAGD.ItemFactura ADD CONSTRAINT PK_ItemFactura
 PRIMARY KEY CLUSTERED (itemFactura_nro,itemConsumible_codigo,itemEstadia_codigo)
GO

ALTER TABLE FAGD.Factura ADD CONSTRAINT PK_Factura
 PRIMARY KEY CLUSTERED (itemFactura_nro)
GO

ALTER TABLE FAGD.Cliente ADD CONSTRAINT PK_Cliente
 PRIMARY KEY CLUSTERED (cliente_nroDocumento)
GO

ALTER TABLE FAGD.Pago ADD CONSTRAINT PK_Pago
 PRIMARY KEY CLUSTERED (pagoFactura_nro)
GO

ALTER TABLE FAGD.Estadia ADD CONSTRAINT PK_Estadia
 PRIMARY KEY CLUSTERED (estadia_codigo)
GO

ALTER TABLE FAGD.Consumible ADD CONSTRAINT PK_Consumible
 PRIMARY KEY CLUSTERED (consumible_codigo)
GO

ALTER TABLE FAGD.ConsumibleXEstadia ADD CONSTRAINT PK_ConsumibleXEstadia
 PRIMARY KEY CLUSTERED (consumible_codigo,estadia_codigo)
GO


---------------------------------- CREACIÓN FOREIGN KEYS ---------------------------------------

ALTER TABLE FAGD.Hotel ADD CONSTRAINT FK_Hotel
 FOREIGN KEY (hotel_regimen) REFERENCES FAGD.Regimen(regimen_codigo)
GO

ALTER TABLE FAGD.RolXFuncionalidad ADD CONSTRAINT FK_RolXFuncionalidad
 FOREIGN KEY (rol_codigo) REFERENCES FAGD.Rol(rol_codigo)
GO

ALTER TABLE FAGD.RolXFuncionalidad ADD CONSTRAINT FK_RolXFuncionalidad_1
 FOREIGN KEY (funcionalidad_codigo) REFERENCES FAGD.Funcionalidad(funcionalidad_codigo)
GO

ALTER TABLE FAGD.UsuarioXRol ADD CONSTRAINT FK_UsuarioXRol
 FOREIGN KEY (usuario_username) REFERENCES FAGD.Usuario(usuario_username)
GO

ALTER TABLE FAGD.UsuarioXRol ADD CONSTRAINT FK_UsuarioXRol_1
 FOREIGN KEY (rol_codigo) REFERENCES FAGD.Rol(rol_codigo)
GO

ALTER TABLE FAGD.UsuarioXHotel ADD CONSTRAINT FK_UsuarioXHotel
 FOREIGN KEY (usuario_username) REFERENCES FAGD.Usuario(usuario_username)
GO

ALTER TABLE FAGD.UsuarioXHotel ADD CONSTRAINT FK_UsuarioXHotel_1
 FOREIGN KEY (hotel_codigo) REFERENCES FAGD.Codigo(hotel_codigo)
GO

ALTER TABLE FAGD.ItemFactura ADD CONSTRAINT FK_ItemFactura_Factura
 FOREIGN KEY (itemFactura_nro) REFERENCES FAGD.Factura(factura_nro)
GO

ALTER TABLE FAGD.ItemFactura ADD CONSTRAINT FK_ItemFactura_Estadia
 FOREIGN KEY (itemEstadia_codigo) REFERENCES FAGD.Estadia(estadia_codigo)
GO

ALTER TABLE FAGD.ItemFactura ADD CONSTRAINT FK_ItemFactura_ConsumibleXEstadia
 FOREIGN KEY (itemConsumible_codigo,itemConsumible_cantidad) REFERENCES FAGD.Consumible_x_Estadia(consumible_codigo,consumible_cantidad)
GO

ALTER TABLE FAGD.Factura ADD CONSTRAINT FK_Factura_Cliente
 FOREIGN KEY (factura_documentoCliente) REFERENCES FAGD.Cliente(cliente_nroDocumento)
GO

ALTER TABLE FAGD.Pago ADD CONSTRAINT FK_Pago_Factura
 FOREIGN KEY (pagoFactura_nro) REFERENCES FAGD.Factura(factura_nro)
GO

ALTER TABLE FAGD.Estadia ADD CONSTRAINT FK_Estadia_Cliente
 FOREIGN KEY (estadiaCliente_nroDocumento) REFERENCES FAGD.Cliente(cliente_nroDocumento)
GO

ALTER TABLE FAGD.Estadia ADD CONSTRAINT FK_Estadia_Reserva
 FOREIGN KEY (estadiaReserva_codigo) REFERENCES FAGD.Reserva(reserva_codigo)
GO

ALTER TABLE FAGD.ConsumiblexEstadia ADD CONSTRAINT FK_ConsumibleXEstadia_Consumible
 FOREIGN KEY (consumible_codigo) REFERENCES FAGD.Consumible(consumible_codigo)
GO

ALTER TABLE FAGD.Reserva_cancelada ADD CONSTRAINT FK_Reserva_cancelada_Usuario
 FOREIGN KEY (reservaCancelada_nombreUsuario) REFERENCES FAGD.Usuario(usuario_username)
GO

ALTER TABLE FAGD.Reserva_cancelada ADD CONSTRAINT FK_Reserva_cancelada_Reserva
 FOREIGN KEY (reservaCancelada_codigoReserva) REFERENCES FAGD.Reserva(reserva_codigo)
GO

ALTER TABLE FAGD.Habitacion ADD CONSTRAINT FK_Habitacion_Habitacion_tipo
 FOREIGN KEY (habitacionTipo_codigo) REFERENCES FAGD.HabitacionTipo(habitacionTipo_codigo)
GO

ALTER TABLE FAGD.Habitacion ADD CONSTRAINT FK_Habitacion_Hotel
 FOREIGN KEY (habitacion_codigoHotel) REFERENCES FAGD.Hotel(hotel_codigo)
GO

ALTER TABLE FAGD.Reserva ADD CONSTRAINT FK_Reserva_Cliente
 FOREIGN KEY (reserva_clienteNroDocumento) REFERENCES FAGD.Cliente(cliente_nroDocumento)
GO

ALTER TABLE FAGD.Reserva ADD CONSTRAINT FK_Reserva_Regimen
 FOREIGN KEY (reserva_codigoRegimen) REFERENCES FAGD.Regimen(regimen_codigo)
GO

ALTER TABLE FAGD.Reserva ADD CONSTRAINT FK_Reserva_Usuario
 FOREIGN KEY (reserva_nombreUsuario) REFERENCES FAGD.Usuario(usuario_username)
GO

ALTER TABLE FAGD.Reserva ADD CONSTRAINT FK_Reserva_Habitacion
 FOREIGN KEY (reserva_nroHabitacion) REFERENCES FAGD.Habitacion(habitacion_codigo)
GO