USE [GD1C2018];
GO

-----------------------	 CREACIÓN DE SCHEMA   -----------------------
 
CREATE SCHEMA FAGD AUTHORIZATION gdHotel2018
GO

-----------------------	 CREACIÓN DE TABLAS   ----------------------- 
CREATE TABLE FAGD.Hotel(
	hotel_codigo numeric (18,0) IDENTITY (1,1) NOT NULL,
	hotel_cantEstrellas numeric(18,0) NOT NULL,
	hotel_recarga_estrellas numeric(18,0) NOT NULL ,
	hotel_pais nvarchar(255) NULL,
	hotel_ciudad nvarchar(255) NOT NULL,
	hotel_calle nvarchar(255) NOT NULL,
	hotel_nroCalle numeric(18,0) NOT NULL,
	hotel_nombre nvarchar(255) NULL,
	hotel_fechaDeCreacion datetime  NULL,
	hotel_mail nvarchar(255) NULL,
	hotel_telefono numeric(18,0) NULL,
	hotel_estado bit NOT NULL default(1)
)
GO

CREATE TABLE FAGD.HotelXRegimen(
	hotel_codigo numeric (18,0) NOT NULL,
	regimen_codigo numeric (18,0) NOT NULL
)
GO

CREATE TABLE FAGD.Habitacion(
	habitacion_codigo numeric(18,0) NOT NULL,
	habitacion_codigoHotel numeric (18,0) NOT NULL,
	habitacion_nro numeric (18,0) NOT NULL,
	habitacion_tipoCodigo numeric (18,0) NOT NULL,
	habitacion_piso numeric (18,0) NOT NULL,
	habitacion_ubicacion nvarchar(255) NOT NULL,
	habitacion_descripcion nvarchar(255) NULL,
	habitacion_estado bit NOT NULL default(1)
)
GO


CREATE TABLE FAGD.HabitacionTipo(
	habitacionTipo_codigo numeric(18,0) NOT NULL,
	habitacionTipo_descripcion nvarchar(255) NOT NULL,
	habitacionTipo_porcentual numeric(18,2) NOT NULL
)
GO


CREATE TABLE FAGD.Reserva(
	reserva_codigo numeric(18,0) NOT NULL,
	reserva_fechaRealizada datetime,
	reserva_fechaInicio datetime NOT NULL,
	reserva_fechaFin datetime,
	reserva_cantNoches numeric(5) NOT NULL,
	reserva_estado nvarchar(255),
	reserva_codigoRegimen numeric(18),
	reserva_clienteNroDocumento numeric(18,0),
	reserva_nombreUsuario nvarchar(255),
	reserva_codigoHotel numeric (18,0),
	reserva_codigoHabitacion numeric (18,0)
)
GO

CREATE TABLE FAGD.ReservaCancelada(
	reservaCancelada_codigo numeric (18) IDENTITY (1,1) NOT NULL,
	reservaCancelada_motivo nvarchar(255),
	reservaCancelada_fechaCancelacion datetime,
	reservaCancelada_nombreUsuario nvarchar(255) NOT NULL,
	reservaCancelada_codigoReserva numeric (18) NOT NULL
)
GO

CREATE TABLE FAGD.Regimen(
	regimen_codigo numeric(18) IDENTITY (1,1) NOT NULL,
	regimen_descripcion varchar (50) NOT NULL,
	regimen_precioBase numeric (18,2) NOT NULL,
	regimen_estado bit NOT NULL default(1)
)
GO

CREATE TABLE FAGD.Usuario(
	usuario_username nvarchar(255) NOT NULL,
	usuario_password nvarchar(255),
	usuario_nombre nvarchar(255),
	usuario_apellido nvarchar(255),
	usuario_direccion nvarchar(255),
	usuario_mail nvarchar(255) UNIQUE,
	usuario_telefono numeric(18),
	usuario_fechaNacimiento datetime,
	usuario_estado bit NOT NULL default(1)
)
GO

CREATE TABLE FAGD.UsuarioXHotel(
	usuario_username nvarchar(255),
	hotel_codigo numeric (18)
)
GO

CREATE TABLE FAGD.UsuarioXRol(
	usuario_username nvarchar(255),
	rol_codigo numeric(18),
)
GO

CREATE TABLE FAGD.Rol(
	rol_codigo numeric(18) IDENTITY (1,1) NOT NULL,
	rol_nombre nvarchar(255) NOT NULL,
	rol_estado bit NOT NULL default(1) 
)
GO

CREATE TABLE FAGD.RolXFuncionalidad(
	rol_codigo numeric(18),
	funcionalidad_codigo numeric(18)
)
GO

CREATE TABLE FAGD.Funcionalidad(
	funcionalidad_codigo numeric (18) IDENTITY (1,1) NOT NULL,
	funcionalidad_detalle nvarchar(255)
)
GO

CREATE TABLE FAGD.ItemFactura(
 itemFactura_nro numeric(18) NOT NULL,
 item_codigo numeric(18) NOT NULL,
 itemConsumible_cantidad numeric(5),
 itemConsumisiones_total numeric (18,2)
) 
GO

CREATE TABLE FAGD.Factura(
 factura_nro numeric(18) NOT NULL,
 factura_fecha datetime,
 factura_total numeric(18,2),
 factura_estado numeric(1),
 factura_documentoCliente numeric(18)
)
GO

CREATE TABLE FAGD.Pago(
 pagoFactura_Nro numeric(18) NOT NULL,
 pago_tipo numeric(2),
 pago_descripcion nvarchar(255),
 pago_fecha datetime
) 
GO


CREATE TABLE FAGD.Cliente(
 cliente_nroDocumento numeric(18) NOT NULL,
 cliente_apellido nvarchar(255),
 cliente_nombre nvarchar(255),
 cliente_fechaNac datetime,
 cliente_mail varchar(50),
 cliente_nacionalidad nvarchar(255),
 cliente_calle nvarchar(255),
 cliente_nroCalle numeric(18),
 cliente_piso numeric(18),
 cliente_dpto varchar(5),
 cliente_tipoDocumento nvarchar(255),
 cliente_telefono numeric(18),
 cliente_localidad nvarchar(255),
 cliente_estado bit NOT NULL default(1)
) 
GO

CREATE TABLE FAGD.ErrorCliente(
 errorCliente_nroDocumento numeric(18) NOT NULL,
 errorCliente_apellido nvarchar(255),
 errorCliente_nombre nvarchar(255),
 errorCliente_fechaNac datetime,
 errorCliente_mail nvarchar(255),
 errorCliente_nacionalidad nvarchar(255),
 errorCliente_calle nvarchar(255),
 errorCliente_nroCalle numeric(18),
 errorCliente_piso numeric(18),
 errorCliente_dpto nvarchar(255),
 errorCliente_tipoDocumento nvarchar(255),
 errorCliente_telefono numeric(18),
 errorCliente_localidad nvarchar(255),
 errorCliente_estado bit NOT NULL default(1)
)
GO

CREATE TABLE FAGD.Consumible(
consumible_codigo numeric (18) IDENTITY (1,1) NOT NULL,
consumible_descripcion nvarchar(255),
consumible_precio numeric (18,2) 
)
GO

CREATE TABLE FAGD.ConsumibleXEstadia(
consumible_codigo numeric(18) NOT NULL,
consumible_cantidad numeric(3),
estadia_codigo numeric(18) NOT NULL
)
GO

CREATE TABLE FAGD.Estadia(
estadia_codigo numeric(18) IDENTITY(1,1) NOT NULL,
estadia_fechaInicio datetime,
estadia_cantNoches numeric(18),
estadia_clienteNroDocumento numeric (18),
estadia_codigoReserva numeric(18) NOT NULL
)
GO

CREATE TABLE FAGD.BajaHotel(
id_baja numeric(18) IDENTITY(1,1) NOT NULL,
hotel_codigo numeric (18,0),
fecha_inicio datetime,
fecha_fin datetime
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
 PRIMARY KEY CLUSTERED (itemFactura_nro,item_codigo)
GO

ALTER TABLE FAGD.Factura ADD CONSTRAINT PK_Factura
 PRIMARY KEY CLUSTERED (factura_nro)
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

ALTER TABLE FAGD.BajaHotel ADD CONSTRAINT PK_BajaHotel
 PRIMARY KEY CLUSTERED (id_baja)
GO


---------------------------------- CREACIÓN FOREIGN KEYS ---------------------------------------

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
 FOREIGN KEY (hotel_codigo) REFERENCES FAGD.Hotel(hotel_codigo)
GO

ALTER TABLE FAGD.ItemFactura ADD CONSTRAINT FK_ItemFactura_Factura
 FOREIGN KEY (itemFactura_nro) REFERENCES FAGD.Factura(factura_nro)
GO

ALTER TABLE FAGD.ItemFactura ADD CONSTRAINT FK_ItemFactura_Estadia
 FOREIGN KEY (item_codigo) REFERENCES FAGD.Estadia(estadia_codigo)
GO

ALTER TABLE FAGD.ItemFactura ADD CONSTRAINT FK_ItemFactura_ConsumibleXEstadia
 FOREIGN KEY (item_codigo) REFERENCES FAGD.ConsumibleXEstadia(consumible_codigo,estadia_codigo)
GO

ALTER TABLE FAGD.Factura ADD CONSTRAINT FK_Factura_Cliente
 FOREIGN KEY (factura_documentoCliente) REFERENCES FAGD.Cliente(cliente_nroDocumento)
GO

ALTER TABLE FAGD.Pago ADD CONSTRAINT FK_Pago_Factura
 FOREIGN KEY (pagoFactura_nro) REFERENCES FAGD.Factura(factura_nro)
GO

ALTER TABLE FAGD.Estadia ADD CONSTRAINT FK_Estadia_Cliente
 FOREIGN KEY (estadia_clienteNroDocumento) REFERENCES FAGD.Cliente(cliente_nroDocumento)
GO

ALTER TABLE FAGD.Estadia ADD CONSTRAINT FK_Estadia_Reserva
 FOREIGN KEY (estadia_codigoReserva) REFERENCES FAGD.Reserva(reserva_codigo)
GO

ALTER TABLE FAGD.ConsumibleXEstadia ADD CONSTRAINT FK_ConsumibleXEstadia_Consumible
 FOREIGN KEY (consumible_codigo) REFERENCES FAGD.Consumible(consumible_codigo)
GO

ALTER TABLE FAGD.ConsumibleXEstadia ADD CONSTRAINT FK_ConsumibleXEstadia_Estadia
 FOREIGN KEY (estadia_codigo) REFERENCES FAGD.Estadia(estadia_codigo)
GO

ALTER TABLE FAGD.ReservaCancelada ADD CONSTRAINT FK_ReservaCancelada_Usuario
 FOREIGN KEY (reservaCancelada_nombreUsuario) REFERENCES FAGD.Usuario(usuario_username)
GO

ALTER TABLE FAGD.ReservaCancelada ADD CONSTRAINT FK_ReservaCancelada_Reserva
 FOREIGN KEY (reservaCancelada_codigoReserva) REFERENCES FAGD.Reserva(reserva_codigo)
GO

ALTER TABLE FAGD.Habitacion ADD CONSTRAINT FK_Habitacion_Habitacion_tipo
 FOREIGN KEY (habitacion_tipoCodigo) REFERENCES FAGD.HabitacionTipo(habitacionTipo_codigo)
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
 FOREIGN KEY (reserva_codigoHabitacion) REFERENCES FAGD.Habitacion(habitacion_codigo)
GO

ALTER TABLE FAGD.BajaHotel ADD CONSTRAINT FK_BajaHotel_Hotel
 FOREIGN KEY (hotel_codigo) REFERENCES FAGD.Hotel(hotel_codigo)
GO

ALTER TABLE FAGD.HotelXRegimen ADD CONSTRAINT FK_HotelXRegimen_Hotel
 FOREIGN KEY (hotel_codigo) REFERENCES FAGD.Hotel(hotel_codigo)
GO

ALTER TABLE FAGD.HotelXRegimen ADD CONSTRAINT FK_HotelXRegimen_Regimen
 FOREIGN KEY (regimen_codigo) REFERENCES FAGD.Regimen(regimen_codigo)
GO

-----------------------	 CREACIÓN DE INSERTS DE MIGRACIÓN   ----------------------- 









