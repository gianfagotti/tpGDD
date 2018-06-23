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
	habitacion_codigo numeric(18,0) IDENTITY (1,1) NOT NULL,
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
	reserva_codigoHotel numeric (18,0)
)
GO

CREATE TABLE FAGD.ReservaXHabitacion(
	reserva_codigo numeric(18,0) NOT NULL,
	habitacion_codigo numeric(18,0) NOT NULL
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

CREATE TABLE FAGD.Factura(
 factura_nro numeric(18) NOT NULL,
 factura_codigoEstadia numeric(18),
 factura_codigoHotel numeric (18),
 factura_fecha datetime,
 factura_total numeric(18,2),
 factura_documentoCliente numeric(18),
 factura_estado numeric(1)
 )
GO

CREATE TABLE FAGD.ItemFactura(
 itemFactura_nroFactura numeric(18) NOT NULL,
 itemFactura_codigoEstadia numeric(18),
 itemFactura_codigoConsumible numeric(18),
 itemFactura_consumibleCantidad numeric(5),
 itemFactura_itemTotal numeric (18,2)
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
 cliente_piso varchar(5),
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
consumible_codigo numeric (18) NOT NULL,
consumible_descripcion nvarchar(255),
consumible_precio numeric (18,2) 
)
GO

CREATE TABLE FAGD.ConsumibleXEstadia(
estadia_codigo numeric(18) NOT NULL,
consumible_codigo numeric(18) NOT NULL,
consumible_cantidad numeric(3)
)
GO

CREATE TABLE FAGD.Estadia(
estadia_codigo numeric(18) IDENTITY(1,1) NOT NULL,
estadia_fechaInicio datetime,
estadia_cantNoches numeric(18),
estadia_clienteNroDocumento numeric (18) NOT NULL,
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

ALTER TABLE FAGD.ReservaXHabitacion ADD CONSTRAINT PK_ReservaXHabitacion
PRIMARY KEY CLUSTERED (reserva_codigo, habitacion_codigo)

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

--------------- TEMA FACTURA E ITEM FACTURA--------------
ALTER TABLE FAGD.ConsumibleXEstadia ADD CONSTRAINT FK_ConsumibleXEstadia_Consumible
 FOREIGN KEY (consumible_codigo) REFERENCES FAGD.Consumible(consumible_codigo)
GO

ALTER TABLE FAGD.ConsumibleXEstadia ADD CONSTRAINT FK_ConsumibleXEstadia_Estadia
 FOREIGN KEY (estadia_codigo) REFERENCES FAGD.Estadia(estadia_codigo)
GO

ALTER TABLE FAGD.Factura ADD CONSTRAINT FK_Factura_Cliente
 FOREIGN KEY (factura_documentoCliente) REFERENCES FAGD.Cliente(cliente_nroDocumento)
GO

ALTER TABLE FAGD.Factura ADD CONSTRAINT FK_Factura_Estadia
 FOREIGN KEY (factura_codigoEstadia) REFERENCES FAGD.Estadia(estadia_codigo)
GO

ALTER TABLE FAGD.Factura ADD CONSTRAINT FK_Factura_Hotel
 FOREIGN KEY (factura_codigoHotel) REFERENCES FAGD.Hotel(hotel_codigo)
GO

ALTER TABLE FAGD.ItemFactura ADD CONSTRAINT FK_ItemFactura_Factura
 FOREIGN KEY (itemFactura_nroFactura) REFERENCES FAGD.Factura(factura_nro)
GO

ALTER TABLE FAGD.ItemFactura ADD CONSTRAINT FK_ItemFactura_Estadia
 FOREIGN KEY (itemFactura_codigoEstadia) REFERENCES FAGD.Estadia(estadia_codigo)
GO

ALTER TABLE FAGD.ItemFactura ADD CONSTRAINT FK_ItemFactura_Consumible
 FOREIGN KEY (itemFactura_codigoConsumible) REFERENCES FAGD.Consumible(consumible_codigo)
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

ALTER TABLE FAGD.Reserva ADD CONSTRAINT FK_Reserva_Hotel
 FOREIGN KEY (reserva_codigoHotel) REFERENCES FAGD.Hotel(hotel_codigo)
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

ALTER TABLE FAGD.ReservaXHabitacion ADD CONSTRAINT FK_ReservaXHabitacion_Reserva
 FOREIGN KEY (reserva_codigo) REFERENCES FAGD.Reserva(reserva_codigo)
GO

ALTER TABLE FAGD.ReservaXHabitacion ADD CONSTRAINT FK_ReservaXHabitacion_Habitacion
 FOREIGN KEY (habitacion_codigo) REFERENCES FAGD.Habitacion(habitacion_codigo)
GO

-----------------------	 CREACIÓN DE INSERTS DE MIGRACIÓN   ----------------------- 

INSERT INTO FAGD.Hotel ([hotel_ciudad], [hotel_calle], [hotel_nroCalle], [hotel_cantEstrellas], [hotel_recarga_estrellas])
	SELECT DISTINCT [Hotel_Ciudad],[Hotel_Calle],[Hotel_Nro_Calle],[Hotel_CantEstrella],[Hotel_Recarga_Estrella]
	FROM [GD1C2018].[gd_esquema].[Maestra]
GO

INSERT INTO FAGD.Regimen ([regimen_descripcion],[regimen_precioBase])
		SELECT DISTINCT [Regimen_Descripcion],[Regimen_Precio]
		FROM [GD1C2018].[gd_esquema].[Maestra]
GO

INSERT INTO FAGD.Consumible (consumible_codigo,consumible_descripcion,consumible_precio)
		SELECT DISTINCT Consumible_Codigo,[Consumible_Descripcion],[Consumible_Precio]
		FROM [GD1C2018].[gd_esquema].[Maestra]
		WHERE Consumible_Codigo IS NOT NULL
GO

INSERT INTO FAGD.ErrorCliente ([errorCliente_nroDocumento],[errorCliente_apellido],[errorCliente_nombre],[errorCliente_fechaNac],[errorCliente_mail],[errorCliente_calle],[errorCliente_nroCalle],[errorCliente_piso],[errorCliente_dpto], [errorCliente_nacionalidad], [errorCliente_tipoDocumento], [errorCliente_telefono], [errorCliente_estado], [errorCliente_localidad])
		SELECT DISTINCT A.[Cliente_Pasaporte_Nro],A.[Cliente_Apellido], A.[Cliente_Nombre], A.[Cliente_Fecha_Nac], A.[Cliente_Mail], A.[Cliente_Dom_Calle], A.[Cliente_Nro_Calle],A.[Cliente_Piso],A.[Cliente_Depto],A.[Cliente_Nacionalidad],'Pasaporte', 000, 0, NULL
		FROM gd_esquema.Maestra A JOIN gd_esquema.Maestra B ON (A.[Cliente_Pasaporte_Nro] = B.Cliente_Pasaporte_Nro AND A.Cliente_Apellido <> B.Cliente_Apellido AND A.Cliente_Nombre <> B.Cliente_Nombre)
		ORDER BY Cliente_Pasaporte_Nro, Cliente_Apellido, Cliente_Nombre
GO

INSERT INTO FAGD.Cliente ([cliente_nroDocumento],[cliente_apellido],[cliente_nombre],[cliente_fechaNac],[cliente_mail],[cliente_calle],
		[cliente_nroCalle],[cliente_piso],[cliente_dpto], [cliente_nacionalidad], [cliente_tipoDocumento], [cliente_telefono], [cliente_estado], [cliente_localidad])
		SELECT DISTINCT [Cliente_Pasaporte_Nro],[Cliente_Apellido],[Cliente_Nombre],[Cliente_Fecha_Nac],[Cliente_Mail],[Cliente_Dom_Calle],
		[Cliente_Nro_Calle],[Cliente_Piso],[Cliente_Depto],[Cliente_Nacionalidad],'Pasaporte', 000, 1, NULL
		FROM gd_esquema.Maestra
		WHERE [Cliente_Pasaporte_Nro] NOT IN(SELECT [errorCliente_nroDocumento] FROM FAGD.ErrorCliente)
GO

INSERT INTO FAGD.HabitacionTipo(habitacionTipo_codigo, habitacionTipo_descripcion, habitacionTipo_porcentual)
		SELECT DISTINCT Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual
		FROM gd_esquema.Maestra 
GO

INSERT INTO FAGD.Habitacion(habitacion_codigoHotel, habitacion_nro, habitacion_tipoCodigo, habitacion_piso, habitacion_ubicacion, habitacion_descripcion,habitacion_estado)
	SELECT DISTINCT Hotel.hotel_codigo, Maestra.Habitacion_Numero, Maestra.Habitacion_Tipo_Codigo,  Maestra.Habitacion_Piso, UPPER(Maestra.Habitacion_Frente), UPPER(Maestra.Habitacion_Tipo_Descripcion), 1
	FROM gd_esquema.Maestra Maestra, FAGD.Hotel Hotel
	WHERE Hotel.hotel_calle = Maestra.Hotel_Calle AND Hotel.hotel_nroCalle = Maestra.Hotel_Nro_Calle AND Hotel.hotel_ciudad = Maestra.Hotel_Ciudad AND Hotel.hotel_calle IS NOT NULL
	ORDER BY Hotel.hotel_codigo
GO


INSERT INTO FAGD.Reserva ([reserva_codigo],[reserva_fechaInicio],[reserva_cantNoches],[reserva_codigoRegimen],[reserva_clienteNroDocumento],[reserva_codigoHotel])
		SELECT DISTINCT M.Reserva_codigo, M.Reserva_Fecha_Inicio, M.Reserva_Cant_Noches, R.regimen_codigo, C.cliente_nroDocumento, H.hotel_codigo
		FROM FAGD.Regimen R, FAGD.Hotel H, FAGD.Cliente C, gd_esquema.Maestra M
		WHERE M.Regimen_Descripcion = R.regimen_descripcion and M.Hotel_Calle = H.hotel_calle and M.Hotel_Nro_Calle = H.hotel_nroCalle AND M.Cliente_Pasaporte_Nro = C.cliente_NroDocumento
		ORDER BY M.Reserva_Codigo
GO

INSERT INTO FAGD.ReservaxHabitacion(reserva_codigo, habitacion_codigo)
		SELECT DISTINCT R.reserva_codigo, H.habitacion_codigo
		FROM gd_esquema.Maestra M, FAGD.Habitacion H, FAGD.Reserva R
		WHERE M.Habitacion_Numero = H.habitacion_nro and M.Reserva_Codigo = R.reserva_codigo
		ORDER BY reserva_codigo

INSERT INTO FAGD.Estadia (estadia_fechaInicio, estadia_cantNoches, estadia_clienteNroDocumento, estadia_codigoReserva)
		SELECT DISTINCT M.Estadia_Fecha_Inicio, M.Estadia_Cant_Noches, M.Cliente_Pasaporte_Nro, M.Reserva_Codigo
		FROM gd_esquema.Maestra M, FAGD.Reserva R
		WHERE R.reserva_clienteNroDocumento = M.Cliente_Pasaporte_Nro AND R.reserva_codigo = M.Reserva_Codigo
		AND M.Estadia_Fecha_Inicio IS NOT NULL AND M.Estadia_Cant_Noches IS NOT NULL
		ORDER BY M.Reserva_Codigo
GO


INSERT INTO FAGD.Factura(factura_nro, factura_codigoHotel, factura_codigoEstadia, factura_fecha, factura_total, factura_documentoCliente, factura_estado) 
		SELECT DISTINCT Maestra.Factura_Nro, Hotel.hotel_codigo, Estadia.estadia_codigo, Maestra.Factura_Fecha, Maestra.Factura_Total,  Maestra.Cliente_Pasaporte_Nro, 1
		FROM gd_esquema.Maestra Maestra, FAGD.Estadia Estadia, FAGD.Hotel Hotel
		WHERE Maestra.Factura_Nro IS NOT NULL AND Estadia.estadia_codigoReserva = Maestra.Reserva_codigo AND  Estadia.estadia_clienteNroDocumento = Maestra.Cliente_Pasaporte_Nro AND Hotel.hotel_calle = Maestra.Hotel_Calle AND Hotel.hotel_nroCalle = Maestra.Hotel_Nro_Calle
		ORDER BY Maestra.Factura_Nro
GO

INSERT INTO FAGD.HotelXRegimen (hotel_codigo,regimen_codigo)
		SELECT DISTINCT hotel_codigo, regimen_codigo
		FROM gd_esquema.Maestra Maestra, FAGD.Hotel Hotel, FAGD.Regimen Regimen
		WHERE Hotel.hotel_calle = Maestra.Hotel_Calle AND Hotel.hotel_nroCalle = Maestra.Hotel_Nro_Calle AND Hotel.hotel_ciudad = Maestra.Hotel_Ciudad AND Regimen.regimen_descripcion = Maestra.Regimen_Descripcion AND Regimen.regimen_precioBase = Maestra.Regimen_Precio
		ORDER BY Hotel.hotel_codigo
GO

INSERT INTO FAGD.ConsumibleXEstadia (estadia_codigo, consumible_codigo, consumible_cantidad)
		SELECT DISTINCT E.estadia_codigo, C.consumible_codigo, M.Item_Factura_Cantidad
		FROM gd_esquema.Maestra M, FAGD.Consumible C, FAGD.Estadia E
		WHERE M.Consumible_Codigo =  C.consumible_codigo
		 AND M.Consumible_Descripcion = C.consumible_descripcion
		 AND E.estadia_cantNoches = M.Estadia_Cant_Noches
		 AND E.estadia_codigoReserva = M.Reserva_Codigo 
		 AND E.estadia_fechaInicio = M.Estadia_Fecha_Inicio
ORDER BY E.estadia_codigo
GO

INSERT INTO FAGD.ItemFactura (itemFactura_nroFactura,itemFactura_codigoEstadia,itemFactura_codigoConsumible,itemFactura_consumibleCantidad,itemFactura_itemTotal)
		SELECT DISTINCT F.factura_nro, CxE.estadia_codigo, CxE.consumible_codigo, CxE.consumible_cantidad, (CxE.consumible_cantidad * C.consumible_precio)
		FROM FAGD.ConsumibleXEstadia CxE, FAGD.Consumible C, FAGD.Factura F
		WHERE CxE.estadia_codigo = F.factura_codigoEstadia AND C.consumible_codigo = CxE.consumible_codigo
		ORDER BY F.factura_nro
GO

-------------------------------- ROLES Y FUNCIONALIDADES INICIALES --------------------------------- 

INSERT INTO FAGD.Rol (rol_nombre,rol_estado)	
		values ('administrador',1),('recepcionista',1),('cliente',1)
GO

INSERT INTO FAGD.Funcionalidad(funcionalidad_detalle)
		values ('ABM_Reservas'),('ABM_Estadias'),('ABM_Clientes'),('ABM_Consumibles'),('ABM_Roles'),('ABM_Hoteles'),
		       ('ABM_Habitaciones'),('ABM_Usuarios'),('ABM_Regimenes'),('Estadisticas')
GO

INSERT INTO FAGD.RolXFuncionalidad(rol_codigo,funcionalidad_codigo)
		values (1,1),(1,2),(1,3),(1,4),(1,5),(1,6),(1,7),(1,8),(1,9),(1,10)
GO

INSERT INTO FAGD.RolXFuncionalidad(rol_codigo,funcionalidad_codigo)
		values (2,1),(2,2),(2,3),(2,4)
GO

INSERT INTO FAGD.RolXFuncionalidad(rol_codigo,funcionalidad_codigo)
		values (3,1)
GO

INSERT INTO FAGD.Usuario (usuario_username,usuario_password, usuario_nombre, usuario_apellido, usuario_direccion, usuario_mail, usuario_telefono, usuario_fechaNacimiento, usuario_estado)
		values ('IRAA','123','Ivan','Arnaudo','Calle Falsa 123','ivan.arnaudo@gmail.com','11111111','02/09/96',1)
GO

INSERT INTO FAGD.UsuarioXRol(usuario_username,rol_codigo)
		values('IRAA',1)
GO

INSERT INTO FAGD.UsuarioXHotel(usuario_username,hotel_codigo)
		values('IRAA',1),('IRAA',2),('IRAA',3),('IRAA',4),('IRAA',5),('IRAA',6)
GO





-----------------------	 CREACIÓN DE PROCEDURES PARA LA APLICACIÓN   ----------------------- 


CREATE PROCEDURE FAGD.lista_hotel_maxResCancel @trimestre numeric(18,0), @anio numeric(18,0)
AS	BEGIN
		
	DECLARE @inicioTrimestre DATETIME
	DECLARE @finTrimestre DATETIME
	DECLARE @anioAux CHAR(4)
		SET @anioAux = CAST(@anio AS CHAR(4))
		
		IF (@trimestre = 1)
		BEGIN
			SET @inicioTrimestre = @anioAux+'-01-01'
			SET @finTrimestre = @anioAux+'-03-31'
		END
		ELSE IF (@trimestre = 2)
		BEGIN
			SET @inicioTrimestre = @anioAux+'-04-01'
			SET @finTrimestre = @anioAux+'-06-30'
		END
		ELSE IF (@trimestre = 3)
		BEGIN 
			SET @inicioTrimestre = @anioAux+'-07-01'
			SET @finTrimestre = @anioAux+'-09-30'
		END
		ELSE IF (@trimestre = 4)
		BEGIN 
			SET @inicioTrimestre = @anioAux+'-10-01'
			SET @finTrimestre = @anioAux+'-12-31'
		END
		ELSE
		BEGIN
			SET @inicioTrimestre = @anioAux+'-01-01'
			SET @finTrimestre = @anioAux+'-12-31'
		END

SELECT TOP 5 hotel.hotel_codigo, COUNT(resCancel.reservaCancelada_codigoReserva) AS totalCancelaciones 

FROM FAGD.Hotel hotel, FAGD.Habitacion hab, FAGD.ReservaXHabitacion resXHab,
	 FAGD.Reserva res, FAGD.ReservaCancelada resCancel

WHERE hotel.hotel_codigo = hab.habitacion_codigoHotel AND
	  hab.habitacion_codigo = resXHab.habitacion_codigo AND
	  resXHab.reserva_codigo = res.reserva_codigo AND
	  res.reserva_codigo = resCancel.reservaCancelada_codigoReserva AND
	  res.reserva_codigoHotel = hotel.hotel_codigo AND
	  resCancel.reservaCancelada_fechaCancelacion BETWEEN @inicioTrimestre AND @finTrimestre
GROUP BY hotel.hotel_codigo			
END
GO




---------------------------------------------------------------------------------------------



CREATE PROCEDURE FAGD.lista_hotel_maxConFacturados @trimestre numeric(18,0), @anio numeric(18,0)
AS BEGIN
		
	DECLARE @inicioTrimestre DATETIME
	DECLARE @finTrimestre DATETIME
	DECLARE @anioAux CHAR(4)
		SET @anioAux = CAST(@anio AS CHAR(4))
		
		IF (@trimestre = 1)
		BEGIN
			SET @inicioTrimestre = @anioAux+'-01-01'
			SET @finTrimestre = @anioAux+'-03-31'
		END
		ELSE IF (@trimestre = 2)
		BEGIN
			SET @inicioTrimestre = @anioAux+'-04-01'
			SET @finTrimestre = @anioAux+'-06-30'
		END
		ELSE IF (@trimestre = 3)
		BEGIN 
			SET @inicioTrimestre = @anioAux+'-07-01'
			SET @finTrimestre = @anioAux+'-09-30'
		END
		ELSE IF (@trimestre = 4)
		BEGIN 
			SET @inicioTrimestre = @anioAux+'-10-01'
			SET @finTrimestre = @anioAux+'-12-31'
		END
		ELSE
		BEGIN
			SET @inicioTrimestre = @anioAux+'-01-01'
			SET @finTrimestre = @anioAux+'-12-31'
		END

SELECT TOP 5 hotel.hotel_codigo, COUNT(itemFactura_codigoConsumible) AS Cant_Facturada
FROM FAGD.Factura fact, FAGD.Hotel hotel, FAGD.ItemFactura item
WHERE
     hotel.hotel_codigo = factura_codigoHotel AND
	 fact.factura_nro = itemFactura_nroFactura AND
	 fact.factura_codigoEstadia = itemFactura_codigoEstadia AND
	 fact.factura_fecha BETWEEN @inicioTrimestre AND @finTrimestre
GROUP BY hotel.hotel_codigo
ORDER BY Cant_Facturada desc
END
GO


---------------------------------------------------------------------------------------------------



CREATE PROCEDURE FAGD.lista_hotel_diasFueraServ @trimestre numeric(18,0), @anio numeric(18,0)
AS BEGIN
		
	DECLARE @inicioTrimestre DATETIME
	DECLARE @finTrimestre DATETIME
	DECLARE @anioAux CHAR(4)
		SET @anioAux = CAST(@anio AS CHAR(4))
		
		IF (@trimestre = 1)
		BEGIN
			SET @inicioTrimestre = @anioAux+'-01-01'
			SET @finTrimestre = @anioAux+'-03-31'
		END
		ELSE IF (@trimestre = 2)
		BEGIN
			SET @inicioTrimestre = @anioAux+'-04-01'
			SET @finTrimestre = @anioAux+'-06-30'
		END
		ELSE IF (@trimestre = 3)
		BEGIN 
			SET @inicioTrimestre = @anioAux+'-07-01'
			SET @finTrimestre = @anioAux+'-09-30'
		END
		ELSE IF (@trimestre = 4)
		BEGIN 
			SET @inicioTrimestre = @anioAux+'-10-01'
			SET @finTrimestre = @anioAux+'-12-31'
		END
		ELSE
		BEGIN
			SET @inicioTrimestre = @anioAux+'-01-01'
			SET @finTrimestre = @anioAux+'-12-31'
		END


SELECT TOP 5 bajaTotal.CodigoDelHotel, hotel.hotel_calle ,SUM(bajaTotal.Dias) DiasDeBaja 
FROM
	(SELECT * FROM
			(SELECT hotel.hotel_codigo AS CodigoDelHotel, SUM(DATEDIFF(day,hotelDeBaja.fecha_inicio,hotelDeBaja.fecha_fin)) AS Dias
			 FROM FAGD.BajaHotel hotelDeBaja, FAGD.Hotel hotel
			 WHERE hotelDeBaja.hotel_codigo = hotel.hotel_codigo 
					AND hotelDeBaja.fecha_inicio BETWEEN @inicioTrimestre AND @finTrimestre
					AND hotelDeBaja.fecha_fin < @finTrimestre
			group by hotel.hotel_codigo ) as bajaPrevioAlTrimestre
		
		UNION ALL

	 SELECT * FROM
			(SELECT hotel.hotel_codigo AS CodigoDelHotel, SUM(DATEDIFF(day,hotelDeBaja.fecha_inicio,@finTrimestre)) AS Dias
			FROM FAGD.BajaHotel hotelDeBaja, FAGD.Hotel hotel
			WHERE hotelDeBaja.hotel_codigo = hotel.hotel_codigo
					AND hotelDeBaja.fecha_inicio BETWEEN @inicioTrimestre AND @finTrimestre
					AND hotelDeBaja.fecha_fin > @finTrimestre
			GROUP BY hotel.hotel_codigo) as bajaPosteriorAlTrimestre
		) AS bajaTotal,
		FAGD.Hotel hotel
		WHERE hotel.hotel_codigo = bajaTotal.CodigoDelHotel
		GROUP BY bajaTotal.CodigoDelHotel, hotel.hotel_calle
		ORDER BY DiasDeBaja desc
END
GO


---------------------------------------------------------------------------------------------------



CREATE PROCEDURE FAGD.lista_habitacion_maxVecesOcup @trimestre numeric(18,0), @Anio numeric(18,0) 
AS BEGIN

DECLARE @inicioTrimestre DATETIME
	DECLARE @finTrimestre DATETIME
	DECLARE @anioAux CHAR(4)
		SET @anioAux = CAST(@anio AS CHAR(4))
		
		IF (@trimestre = 1)
		BEGIN
			SET @inicioTrimestre = @anioAux+'-01-01'
			SET @finTrimestre = @anioAux+'-03-31'
		END
		ELSE IF (@trimestre = 2)
		BEGIN
			SET @inicioTrimestre = @anioAux+'-04-01'
			SET @finTrimestre = @anioAux+'-06-30'
		END
		ELSE IF (@trimestre = 3)
		BEGIN 
			SET @inicioTrimestre = @anioAux+'-07-01'
			SET @finTrimestre = @anioAux+'-09-30'
		END
		ELSE IF (@trimestre = 4)
		BEGIN 
			SET @inicioTrimestre = @anioAux+'-10-01'
			SET @finTrimestre = @anioAux+'-12-31'
		END
		ELSE
		BEGIN
			SET @inicioTrimestre = @anioAux+'-01-01'
			SET @finTrimestre = @anioAux+'-12-31'
		END

/*SELECT TOP 5*/

END
GO


---------------------------------------------------------------------------------------------------



CREATE PROCEDURE FAGD.lista_cliente_maxPuntajes @trimestre numeric(18,0), @anio numeric(18,0)
AS	BEGIN
		
	DECLARE @inicioTrimestre DATETIME
	DECLARE @finTrimestre DATETIME
	DECLARE @anioAux CHAR(4)
		SET @anioAux = CAST(@anio AS CHAR(4))
		
		IF (@trimestre = 1)
		BEGIN
			SET @inicioTrimestre = @anioAux+'-01-01'
			SET @finTrimestre = @anioAux+'-03-31'
		END
		ELSE IF (@trimestre = 2)
		BEGIN
			SET @inicioTrimestre = @anioAux+'-04-01'
			SET @finTrimestre = @anioAux+'-06-30'
		END
		ELSE IF (@trimestre = 3)
		BEGIN 
			SET @inicioTrimestre = @anioAux+'-07-01'
			SET @finTrimestre = @anioAux+'-09-30'
		END
		ELSE IF (@trimestre = 4)
		BEGIN 
			SET @inicioTrimestre = @anioAux+'-10-01'
			SET @finTrimestre = @anioAux+'-12-31'
		END
		ELSE
		BEGIN
			SET @inicioTrimestre = @anioAux+'-01-01'
			SET @finTrimestre = @anioAux+'-12-31'
		END


SELECT TOP 5 cli.cliente_nroDocumento, cli.cliente_nombre AS Nombre, cli.cliente_apellido AS Apellido, puntosDeEstadia.Puntos+puntosDeConsumibles.Puntos AS Puntaje
FROM 
(SELECT clie.cliente_nroDocumento, est.estadia_codigo, SUM(fact.factura_total) AS Gasto, SUM(fact.factura_total)/10 AS Puntos
	FROM FAGD.Cliente clie, FAGD.Estadia est, FAGD.Factura fact
	WHERE clie.cliente_nroDocumento = estadia_clienteNroDocumento AND
		  factura_codigoEstadia = est.estadia_codigo AND
		  fact.factura_fecha BETWEEN @inicioTrimestre AND @finTrimestre
	GROUP BY clie.cliente_nroDocumento, est.estadia_codigo
	) AS puntosDeEstadia, 

(SELECT consXEst.estadia_codigo, 
SUM(itemFactura_codigoConsumible*item.itemFactura_consumibleCantidad) AS Gasto, 
SUM(itemFactura_codigoConsumible*item.itemFactura_consumibleCantidad)/10 AS Puntos

	FROM FAGD.ConsumibleXEstadia consXEst, FAGD.Factura fact, FAGD.ItemFactura item
	WHERE consXEst.consumible_codigo = item.itemFactura_codigoConsumible AND
	      consxEst.estadia_codigo = itemFactura_codigoEstadia AND
		  item.itemFactura_nroFactura = fact.factura_nro AND
		  fact.factura_fecha BETWEEN @inicioTrimestre AND @finTrimestre
	GROUP BY consXEst.estadia_codigo
	) AS puntosDeConsumibles,
	
FAGD.Cliente cli, FAGD.Estadia est, FAGD.Reserva res
WHERE cli.cliente_nroDocumento = res.reserva_clienteNroDocumento AND
		est.estadia_codigoReserva = res.reserva_codigo AND 
		puntosDeConsumibles.estadia_codigo = est.estadia_codigo  AND
		puntosDeEstadia.estadia_codigo = est.estadia_codigo 
ORDER BY Puntaje DESC
END
GO


------------------------------------------------------------------------------

create proc FAGD.guardarNuevoCliente 
@nombre nvarchar(255),
@apellido nvarchar(255),
@tipoDocumento nvarchar(255),
@nroDocumento numeric(18),
@mail varchar(50),
@telefono numeric(18),
@calle nvarchar(255),
@nroCalle numeric(18),
@piso varchar(5),
@dpto varchar(5),
@localidad nvarchar(255),
@nacionalidad nvarchar(255),
@fechaNac datetime,
@estado bit

as 
begin
	declare @fechaNacimiento datetime
	set @fechaNacimiento = CONVERT(datetime, @fechaNac, 121)
	declare @respuesta numeric(18)
	begin tran cl
	begin try
		if (not exists(select * from FAGD.Cliente 
						where cliente_mail = @mail))
		begin
			if (@piso = '-')
				set @piso = null
			if (@dpto = '-')
				set @dpto = null
			insert into FAGD.Cliente(cliente_nroDocumento, cliente_apellido, cliente_nombre, cliente_fechaNac, cliente_mail,
									 cliente_nacionalidad, cliente_calle, cliente_nroCalle, cliente_piso, cliente_dpto,
									 cliente_tipoDocumento, cliente_telefono, cliente_localidad, cliente_estado)
			values(@nroDocumento, @apellido, @nombre, @fechaNacimiento, @mail, @nacionalidad, @calle, @nroCalle, @piso, @dpto,
					@tipoDocumento, @telefono, @localidad, @estado)
			set @respuesta = 1;
		end
		else
		begin
			set @respuesta = 2;
		end
		select @respuesta as respuesta
	commit tran cl
	end try
	begin catch
	rollback tran cl
		set @respuesta = 0;
		select @respuesta as respuesta
	end catch
end
GO


create proc FAGD.modificarCliente
@nombre nvarchar(255),
@apellido nvarchar(255),
@tipoDocumento nvarchar(255),
@nroDocumento numeric(18),
@mail varchar(50),
@telefono numeric(18),
@calle nvarchar(255),
@nroCalle numeric(18),
@piso varchar(5),
@dpto varchar(5),
@localidad nvarchar(255),
@nacionalidad nvarchar(255),
@fechaNac datetime,
@estado bit

as
begin
	declare @fechaNacimiento datetime
	set @fechaNacimiento = CONVERT(datetime, @fechaNac, 121)
	declare @respuesta numeric(18)
	begin tran modcl
	begin try
			if (@piso = '-')
				set @piso = null
			if (@dpto = '-')
				set @dpto = null
			
			UPDATE FAGD.Cliente

			set cliente_nombre = @nombre,
			cliente_apellido = @apellido,
			cliente_tipoDocumento = @tipoDocumento,
			cliente_mail = @mail,
			cliente_telefono = @telefono,
			cliente_calle = @calle,
			cliente_nroCalle = @nroCalle,
			cliente_piso = @piso,
			cliente_dpto = @dpto,
			cliente_localidad = @localidad,
			cliente_nacionalidad = @nacionalidad,
			cliente_fechaNac = @fechaNacimiento,
			cliente_estado = @estado

			where cliente_nroDocumento = @nroDocumento;


			set @respuesta = 1;

		select @respuesta as respuesta;
	commit tran modcl
	end try
	begin catch
	rollback tran modcl
		set @respuesta = 0;
		select @respuesta as respuesta;
	end catch

end
GO


				
------------------------------------------------IRAA-------------------------------------------------------

CREATE PROC FAGD.nuevoRol @nombreRol nvarchar (255), @estado bit
AS
BEGIN
	DECLARE @resultado numeric(18)

	BEGIN TRY
		IF (NOT EXISTS(SELECT rol_nombre FROM FAGD.Rol WHERE rol_nombre = @nombreRol))
			BEGIN 
				INSERT INTO FAGD.Rol(rol_nombre,rol_estado)
				VALUES (@nombreRol, @estado)
				SET @resultado=1;
			END
		ELSE 
			BEGIN 
				SET @resultado=0; 
			END
		SELECT @resultado AS resultado
	END TRY
	BEGIN CATCH
		SET @resultado = 2;
		SELECT @resultado AS resultado
	END CATCH 
END
GO


CREATE PROCEDURE FAGD.funcionalidadesDelRol @nombreRol nvarchar (255), @codigoFuncionalidad numeric (18)
AS 
BEGIN
 DECLARE @resultado numeric(18)

 BEGIN TRY
  INSERT INTO FAGD.RolXFuncionalidad (rol_codigo,funcionalidad_codigo)
  VALUES ((SELECT rol_codigo FROM FAGD.Rol WHERE @nombreRol = rol_nombre), @codigoFuncionalidad)
  SET @resultado=1;
 END
 SELECT @resultado AS resultado
 COMMIT tran cl
 END TRY
 BEGIN CATCH
  SET @resultado = 0;
  SELECT @resultado AS resultado
 END CATCH
END