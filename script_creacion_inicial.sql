USE [GD1C2018];
GO

-----------------------	 CREACI�N DE SCHEMA   -----------------------
 
CREATE SCHEMA FAGD AUTHORIZATION gdHotel2018
GO

-----------------------	 CREACI�N DE TABLAS   ----------------------- 
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
	habitacionTipo_cantHuespedes numeric(18),
	habitacionTipo_porcentual numeric(18,2) NOT NULL
)
GO

CREATE TABLE FAGD.Estado(
	estado_codigo numeric(18,0) identity(1,1) NOT NULL,
	estado_descripcion nvarchar(40) NOT NULL,
)
GO

CREATE TABLE FAGD.Reserva(
	reserva_codigo numeric(18,0) IDENTITY(10001,1) NOT NULL,
	reserva_fechaRealizada datetime,
	reserva_fechaInicio datetime NOT NULL,
	reserva_fechaFin datetime,
	reserva_cantNoches numeric(5) NOT NULL,
	reserva_estado numeric(18),
	reserva_codigoRegimen numeric(18),
	reserva_clienteCodigo numeric(18,0),
	reserva_errorCliente numeric(18,0),
	reserva_nombreUsuario nvarchar(255),
	reserva_codigoHotel numeric (18,0),
	reserva_cantHuespedes numeric(18,0),
	reserva_costoTotal numeric(18,0)
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
	usuario_tipoDoc nvarchar (255),
	usuario_nroDoc numeric(18),
	usuario_estado bit NOT NULL default(1)
)
GO

CREATE TABLE FAGD.UsuarioXRolXHotel(
	usuario_username nvarchar(255) NOT NULL,
	rol_codigo numeric(18) NOT NULL,
	hotel_codigo numeric(18) NOT NULL
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

CREATE TABLE FAGD.Tarjeta(
   tarjeta_codigo numeric(18) IDENTITY(1,1) NOT NULL,
   tarjeta_numero numeric(18) NOT NULL,
   tarjeta_banco nvarchar(255),
   tarjeta_entidadFinanciera nvarchar(255),
   tarjeta_titular nvarchar(255)
)
GO

CREATE TABLE FAGD.Factura(
 factura_nro numeric(18,0) IDENTITY(2796745,1) NOT NULL,
 factura_codigoEstadia numeric(18) NOT NULL,
 factura_fecha datetime,
 factura_total numeric(18,2),
 factura_modalidadPago numeric(18),
 factura_tarjeta numeric(18),
 factura_clienteCodigo numeric(18),
 factura_errorCliente numeric(18),
 factura_estado numeric(1)
 )
GO

CREATE TABLE FAGD.ItemFactura(
 itemFactura_codigo numeric(18,0) IDENTITY(1,1) NOT NULL,
 itemFactura_nroFactura numeric(18,0) NOT NULL,
 itemFactura_itemMonto numeric (18,0) NOT NULL,
 itemFactura_cantidad numeric(18) NOT NULL,
 itemFactura_descripcion nvarchar(255) NOT NULL
) 
GO

CREATE TABLE FAGD.ModalidadPago(
 modalidadPago_codigo numeric(18) IDENTITY(1,1) NOT NULL,
 modalidadPago_descripcion nvarchar(255) NOT NULL
) 
GO


CREATE TABLE FAGD.Cliente(
 cliente_codigo numeric(18) IDENTITY (1,1) NOT NULL,
 cliente_nroDocumento numeric(18) NOT NULL,
 cliente_apellido nvarchar(255),
 cliente_nombre nvarchar(255),
 cliente_fechaNac datetime,
 cliente_mail varchar(50) UNIQUE,
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
 errorCliente_codigo numeric(18,0) IDENTITY(1,1) NOT NULL,
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
habitacion_codigo numeric(18) NOT NULL,
itemFactura_codigo numeric(18) NOT NULL,
)
GO

CREATE TABLE FAGD.Estadia(
estadia_codigo numeric(18) IDENTITY(1,1) NOT NULL,
estadia_fechaInicio datetime,
estadia_fechaFin datetime,
estadia_cantNoches numeric(18,0) NOT NULL,
estadia_diasSobrantes numeric (18,0),
estadia_precioNoche numeric(18,0) NOT NULL,
estadia_codigoReserva numeric(18) NOT NULL,
estadia_usuarioRegistrador nvarchar(255),
estadia_usuarioFinalizador nvarchar(255),
)
GO

CREATE TABLE FAGD.ClienteXEstadia(
cliente_codigo numeric(18,0),
errorCliente_codigo numeric(18,0),
estadia_codigo numeric(18,0) NOT NULL,
habitacion_codigo numeric(18,0)
)
GO

CREATE TABLE FAGD.BajaHotel(
id_baja numeric(18) IDENTITY(1,1) NOT NULL,
hotel_codigo numeric (18,0),
fecha_inicio datetime,
fecha_fin datetime,
motivo nvarchar(255)
)
GO
---------------------------------- CREACI�N PRIMARY KEYS ---------------------------------------

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

ALTER TABLE FAGD.Estado ADD CONSTRAINT PK_Estado
	PRIMARY KEY CLUSTERED (estado_codigo)
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

ALTER TABLE FAGD.ItemFactura ADD CONSTRAINT PK_ItemFactura
 PRIMARY KEY CLUSTERED (itemFactura_codigo)
GO

ALTER TABLE FAGD.Cliente ADD CONSTRAINT PK_Cliente
 PRIMARY KEY CLUSTERED (cliente_codigo)
GO

ALTER TABLE FAGD.ModalidadPago ADD CONSTRAINT PK_ModalidadPago
 PRIMARY KEY CLUSTERED (modalidadPago_codigo)
GO

ALTER TABLE FAGD.Estadia ADD CONSTRAINT PK_Estadia
 PRIMARY KEY CLUSTERED (estadia_codigo)
GO

ALTER TABLE FAGD.Consumible ADD CONSTRAINT PK_Consumible
 PRIMARY KEY CLUSTERED (consumible_codigo)
GO

ALTER TABLE FAGD.BajaHotel ADD CONSTRAINT PK_BajaHotel
 PRIMARY KEY CLUSTERED (id_baja)
GO

ALTER TABLE FAGD.ErrorCliente ADD CONSTRAINT PK_ErrorCliente
 PRIMARY KEY CLUSTERED (errorCliente_codigo)
GO

ALTER TABLE FAGD.Tarjeta ADD CONSTRAINT PK_Tarjeta
 PRIMARY KEY CLUSTERED (tarjeta_codigo)
GO


---------------------------------- CREACI�N FOREIGN KEYS ---------------------------------------

ALTER TABLE FAGD.RolXFuncionalidad ADD CONSTRAINT FK_RolXFuncionalidad
 FOREIGN KEY (rol_codigo) REFERENCES FAGD.Rol(rol_codigo)
GO

ALTER TABLE FAGD.RolXFuncionalidad ADD CONSTRAINT FK_RolXFuncionalidad_1
 FOREIGN KEY (funcionalidad_codigo) REFERENCES FAGD.Funcionalidad(funcionalidad_codigo)
GO

ALTER TABLE FAGD.UsuarioXRolXHotel ADD CONSTRAINT FK_UsuarioXRolXHotel
 FOREIGN KEY (usuario_username) REFERENCES FAGD.Usuario(usuario_username)
GO

ALTER TABLE FAGD.UsuarioXRolXHotel ADD CONSTRAINT FK_UsuarioXRolXHotel_1
 FOREIGN KEY (rol_codigo) REFERENCES FAGD.Rol(rol_codigo)
GO

ALTER TABLE FAGD.UsuarioXRolXHotel ADD CONSTRAINT FK_UsuarioXRolXHotel_2
 FOREIGN KEY (hotel_codigo) REFERENCES FAGD.Hotel(hotel_codigo)
GO


ALTER TABLE FAGD.ConsumibleXEstadia ADD CONSTRAINT FK_ConsumibleXEstadia_Consumible
 FOREIGN KEY (consumible_codigo) REFERENCES FAGD.Consumible(consumible_codigo)
GO

ALTER TABLE FAGD.ConsumibleXEstadia ADD CONSTRAINT FK_ConsumibleXEstadia_Estadia
 FOREIGN KEY (estadia_codigo) REFERENCES FAGD.Estadia(estadia_codigo)
GO

ALTER TABLE FAGD.ConsumibleXEstadia ADD CONSTRAINT FK_ConsumibleXEstadia_Habitacion
 FOREIGN KEY (habitacion_codigo) REFERENCES FAGD.Habitacion(habitacion_codigo)
GO

ALTER TABLE FAGD.ConsumibleXEstadia ADD CONSTRAINT FK_ConsumibleXEstadia_ItemFactura
 FOREIGN KEY (itemFactura_codigo) REFERENCES FAGD.ItemFactura(itemFactura_codigo)
GO

ALTER TABLE FAGD.Factura ADD CONSTRAINT FK_Factura_Cliente
 FOREIGN KEY (factura_clienteCodigo) REFERENCES FAGD.Cliente(cliente_codigo)
GO

ALTER TABLE FAGD.Factura ADD CONSTRAINT FK_Factura_ErrorCliente
 FOREIGN KEY (factura_errorCliente) REFERENCES FAGD.ErrorCliente(errorCliente_codigo)
GO

ALTER TABLE FAGD.Factura ADD CONSTRAINT FK_Factura_Estadia
 FOREIGN KEY (factura_codigoEstadia) REFERENCES FAGD.Estadia(estadia_codigo)
GO

ALTER TABLE FAGD.Factura ADD CONSTRAINT FK_Factura_ModalidadPago
 FOREIGN KEY (factura_modalidadPago) REFERENCES FAGD.ModalidadPago(modalidadPago_codigo)
GO

ALTER TABLE FAGD.Factura ADD CONSTRAINT FK_Factura_Tarjeta
 FOREIGN KEY (factura_tarjeta) REFERENCES FAGD.Tarjeta(tarjeta_codigo)
GO

ALTER TABLE FAGD.ItemFactura ADD CONSTRAINT FK_ItemFactura_Factura
 FOREIGN KEY (itemFactura_nroFactura) REFERENCES FAGD.Factura(factura_nro)
GO

ALTER TABLE FAGD.Estadia ADD CONSTRAINT FK_Estadia_Reserva
 FOREIGN KEY (estadia_codigoReserva) REFERENCES FAGD.Reserva(reserva_codigo)
GO

ALTER TABLE FAGD.Estadia ADD CONSTRAINT FK_Estadia_UsuarioReg
 FOREIGN KEY (estadia_usuarioRegistrador) REFERENCES FAGD.Usuario(usuario_username)
GO

ALTER TABLE FAGD.Estadia ADD CONSTRAINT FK_Estadia_UsuarioFin
 FOREIGN KEY (estadia_usuarioFinalizador) REFERENCES FAGD.Usuario(usuario_username)
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
 FOREIGN KEY (reserva_clienteCodigo) REFERENCES FAGD.Cliente(cliente_codigo)
GO

ALTER TABLE FAGD.Reserva ADD CONSTRAINT FK_Reserva_Estado
 FOREIGN KEY (reserva_estado) REFERENCES FAGD.Estado(estado_codigo)
GO

ALTER TABLE FAGD.Reserva ADD CONSTRAINT FK_Reserva_ErrorCliente
 FOREIGN KEY (reserva_errorCliente) REFERENCES FAGD.ErrorCliente(errorCliente_codigo)
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

ALTER TABLE FAGD.ReservaXHabitacion ADD CONSTRAINT UNIQUE_ResxH
UNIQUE (reserva_codigo,habitacion_codigo)
GO

ALTER TABLE FAGD.ClienteXEstadia ADD CONSTRAINT FK_ClienteXEstadia_Cliente 
 FOREIGN KEY(cliente_codigo) REFERENCES FAGD.Cliente(cliente_codigo)
GO

ALTER TABLE FAGD.ClienteXEstadia ADD CONSTRAINT FK_ClienteXEstadia_ErrorCliente 
 FOREIGN KEY(errorCliente_codigo) REFERENCES FAGD.ErrorCliente(errorCliente_codigo)
GO

ALTER TABLE FAGD.ClienteXEstadia ADD CONSTRAINT UNIQUE_CliexEst 
UNIQUE (cliente_codigo,estadia_codigo)
GO

ALTER TABLE FAGD.ClienteXEstadia ADD CONSTRAINT FK_ClienteXEstadia_Habitacion 
 FOREIGN KEY(habitacion_codigo) REFERENCES FAGD.Habitacion(habitacion_codigo)
GO

ALTER TABLE FAGD.ClienteXEstadia ADD CONSTRAINT FK_ClienteXEstadia_Estadia
 FOREIGN KEY(estadia_codigo) REFERENCES FAGD.Estadia(estadia_codigo)
GO

-----------------------  CREACI�N DE FUNCIONES PARA LA APLICACI�N   ------------------------

CREATE FUNCTION FAGD.calcularDiasSobrantesEstadia (@finRes datetime, @salidaEs datetime)

RETURNS numeric(18,0)
AS BEGIN

DECLARE @sobranDias numeric(18,0)
	SET @sobranDias = DATEDIFF(day,@salidaEs,@finRes)

	RETURN @sobranDias

END
GO

-------------------------------------------------------------------------------------------


CREATE FUNCTION FAGD.calcularCostosConsumible (@estadia numeric(18,0))

RETURNS numeric(18,2)
AS BEGIN

DECLARE @costoConsumiblesTotal numeric(18,0)
	SET @costoConsumiblesTotal = (SELECT CostosConsumibles.Costo 
	FROM (SELECT consXEst.estadia_codigo Estadia, SUM(cons.consumible_precio) Costo
		   FROM FAGD.ConsumibleXEstadia consXEst, FAGD.Consumible cons
				WHERE consXEst.consumible_codigo = cons.consumible_codigo
			GROUP BY consXEst.estadia_codigo) AS CostosConsumibles
				WHERE CostosConsumibles.Estadia = @estadia
				)
	IF(@costoConsumiblesTotal IS NULL)
	BEGIN
	SET @costoConsumiblesTotal=0
	END
RETURN @costoConsumiblesTotal
END	
GO

-------------------------------------------------------------------------------------------

CREATE FUNCTION FAGD.calcularCostosEstadia (@estadia numeric(18,0))

	RETURNS numeric(18,2)
AS BEGIN
	DECLARE @total numeric(18,0)

	set @total = (SELECT CostosEstadias.CostoEstadia 
				FROM (SELECT E.estadia_codigo Estadia, SUM(R.reserva_costoTotal) CostoEstadia
				       FROM FAGD.Estadia E, FAGD.Reserva R
					WHERE E.estadia_codigoReserva = R.reserva_codigo
							group by E.estadia_codigo) as CostosEstadias
				WHERE CostosEstadias.Estadia = @estadia
				)
RETURN @total
END	
GO


------------------------------------------------------------------------------------------
/* Función que me devuelve 0 si la habitación esta disponible entre esas fechas. Caso contrario me devuelve de 1 a 5 dependiendo el caso */
create function FAGD.habitacionDisponible
( @desde datetime, @hasta datetime,@codigo numeric(18,0))

	RETURNS bit
as
begin
-- Verifico si la fecha de inicio de la reserva, esta entre las pedidas
if(exists 
	(select RH.habitacion_codigo	
	from FAGD.ReservaXHabitacion RH, FAGD.Reserva R
	where 
	R.reserva_fechaInicio > @desde and	
	R.reserva_fechaInicio < @hasta and
	R.reserva_codigo = RH.reserva_codigo and 
	RH.habitacion_codigo = @codigo  and 
	R.reserva_codigo not in (select reservaCancelada_codigoReserva from FAGD.ReservaCancelada C) ) )
begin
return 1
end
-- Verifico si la fecha hasta de la reserva, esta entre las pedidas
if(exists 
	(select RH.habitacion_codigo	
	from FAGD.ReservaXHabitacion RH, FAGD.Reserva R
	where 
	R.reserva_fechaFin > @desde and	
	R.reserva_fechaFin < @hasta and
	R.reserva_codigo = RH.reserva_codigo and 
	RH.habitacion_codigo = @codigo  and 
	R.reserva_codigo not in (select reservaCancelada_codigoReserva from FAGD.ReservaCancelada C) ) )
begin
return 2
end
-- Verifico si la fecha de inicio de la reserva pedida, esta entre las fechas de la reserva
if(exists 
	(select RH.habitacion_codigo	
	from FAGD.ReservaXHabitacion RH, FAGD.Reserva R
	where 
	R.reserva_fechaInicio < @desde and	
	R.reserva_fechaFin > @desde and
	R.reserva_codigo = RH.reserva_codigo and 
	RH.habitacion_codigo = @codigo  and 
	R.reserva_codigo not in (select reservaCancelada_codigoReserva from FAGD.ReservaCancelada C) ) )
begin
return 3
end
-- Verifico si la fecha hasta de la reserva pedida, esta entre las fechas de la reserva
if(exists 
	(select RH.habitacion_codigo	
	from FAGD.ReservaXHabitacion RH, FAGD.Reserva R
	where 
	R.reserva_fechaInicio < @hasta and	
	R.reserva_fechaFin > @hasta and
	R.reserva_codigo = RH.reserva_codigo and 
	RH.habitacion_codigo = @codigo  and 
	R.reserva_codigo not in (select reservaCancelada_codigoReserva from FAGD.ReservaCancelada C) ) )
begin
return 4
end
-- Verifico si las fechas son iguales
if(exists 
	(select RH.habitacion_codigo	
	from FAGD.ReservaXHabitacion RH, FAGD.Reserva R
	where 
	R.reserva_fechaInicio = @desde and	
	R.reserva_fechaFin = @hasta and
	R.reserva_codigo = RH.reserva_codigo and 
	RH.habitacion_codigo = @codigo  and 
	R.reserva_codigo not in (select reservaCancelada_codigoReserva from FAGD.ReservaCancelada C) ) )
begin
return 5
end

return 0

end
go

-----------------------	 CREACI�N DE INSERTS DE MIGRACI�N   ----------------------- 

INSERT INTO FAGD.Estado (estado_descripcion)
VALUES ('RESERVA CORRECTA');
	
INSERT INTO FAGD.Estado (estado_descripcion)
VALUES ('RESERVA MODIFICADA');

INSERT INTO FAGD.Estado (estado_descripcion)
VALUES('RESERVA CANCELADA POR RECEPCION');

INSERT INTO FAGD.Estado (estado_descripcion)
VALUES ('RESERVA CANCELADA POR CLIENTE');

INSERT INTO FAGD.Estado (estado_descripcion)
VALUES ('RESERVA CANCELADA POR NO-SHOW');

INSERT INTO FAGD.Estado (estado_descripcion)
VALUES ('RESERVA EFECTIVIZADA');	

INSERT INTO FAGD.Estado (estado_descripcion)
VALUES ('RESERVA CANCELADA DESDE TABLA MAESTRA');	


INSERT INTO FAGD.modalidadPago (modalidadPago_descripcion)
	VALUES ('EFECTIVO');
	
INSERT INTO FAGD.modalidadPago (modalidadPago_descripcion)
	VALUES ('TARJETA DE CREDITO');

INSERT INTO FAGD.modalidadPago (modalidadPago_descripcion)
	VALUES ('TARJETA DE DEBITO');

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

INSERT INTO FAGD.ErrorCliente ([errorCliente_nroDocumento],[errorCliente_apellido],[errorCliente_nombre],[errorCliente_fechaNac],[errorCliente_mail],[errorCliente_calle],[errorCliente_nroCalle],[errorCliente_piso],[errorCliente_dpto], [errorCliente_nacionalidad], [errorCliente_tipoDocumento], [errorCliente_telefono], [errorCliente_estado], [errorCliente_localidad])
  SELECT DISTINCT A.[Cliente_Pasaporte_Nro],A.[Cliente_Apellido], A.[Cliente_Nombre], A.[Cliente_Fecha_Nac], A.[Cliente_Mail], A.[Cliente_Dom_Calle], A.[Cliente_Nro_Calle],A.[Cliente_Piso],A.[Cliente_Depto],A.[Cliente_Nacionalidad],'Pasaporte', 000, 0, NULL
  FROM gd_esquema.Maestra A JOIN gd_esquema.Maestra B ON (A.[Cliente_Mail] = B.[Cliente_Mail] AND (A.Cliente_Apellido <> B.Cliente_Apellido OR A.Cliente_Nombre <> B.Cliente_Nombre OR A.[Cliente_Pasaporte_Nro] <> B.Cliente_Pasaporte_Nro) AND A.[Cliente_Mail] NOT IN (SELECT errorCliente_mail FROM FAGD.ErrorCliente))
  ORDER BY Cliente_Mail
GO

INSERT INTO FAGD.Cliente ([cliente_nroDocumento],[cliente_apellido],[cliente_nombre],[cliente_fechaNac],[cliente_mail],[cliente_calle],
  [cliente_nroCalle],[cliente_piso],[cliente_dpto], [cliente_nacionalidad], [cliente_tipoDocumento], [cliente_telefono], [cliente_estado], [cliente_localidad])
  SELECT DISTINCT [Cliente_Pasaporte_Nro],[Cliente_Apellido],[Cliente_Nombre],[Cliente_Fecha_Nac],[Cliente_Mail],[Cliente_Dom_Calle],
  [Cliente_Nro_Calle],[Cliente_Piso],[Cliente_Depto],[Cliente_Nacionalidad],'Pasaporte', 000, 1, NULL
  FROM gd_esquema.Maestra
  WHERE [Cliente_Pasaporte_Nro] NOT IN(SELECT [errorCliente_nroDocumento] FROM FAGD.ErrorCliente)
    AND [Cliente_Mail] NOT IN (SELECT [errorCliente_mail] FROM FAGD.ErrorCliente)
GO

INSERT INTO FAGD.HabitacionTipo(habitacionTipo_codigo, habitacionTipo_descripcion, habitacionTipo_porcentual)
		SELECT DISTINCT Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual
		FROM gd_esquema.Maestra 
GO

UPDATE FAGD.HabitacionTipo
	set habitacionTipo_cantHuespedes = case when habitacionTipo_descripcion = 'Base Simple' Then 1
							when habitacionTipo_descripcion = 'Base Doble' Then 2
							when habitacionTipo_descripcion = 'Base Triple' Then 3
							when habitacionTipo_descripcion = 'Base Cuadruple' Then 4
							else 5 end
GO

INSERT INTO FAGD.Habitacion(habitacion_codigoHotel, habitacion_nro, habitacion_tipoCodigo, habitacion_piso, habitacion_ubicacion, habitacion_descripcion,habitacion_estado)
	SELECT DISTINCT Hotel.hotel_codigo, Maestra.Habitacion_Numero, Maestra.Habitacion_Tipo_Codigo,  Maestra.Habitacion_Piso, UPPER(Maestra.Habitacion_Frente), UPPER(Maestra.Habitacion_Tipo_Descripcion), 1
	FROM gd_esquema.Maestra Maestra, FAGD.Hotel Hotel
	WHERE Hotel.hotel_calle = Maestra.Hotel_Calle AND Hotel.hotel_nroCalle = Maestra.Hotel_Nro_Calle AND Hotel.hotel_ciudad = Maestra.Hotel_Ciudad AND Hotel.hotel_calle IS NOT NULL
	ORDER BY Hotel.hotel_codigo
GO

SET IDENTITY_INSERT FAGD.Reserva ON

INSERT INTO FAGD.Reserva ([reserva_codigo],[reserva_fechaInicio],[reserva_cantNoches],[reserva_codigoRegimen],[reserva_clienteCodigo],[reserva_codigoHotel])
  SELECT DISTINCT M.Reserva_codigo, M.Reserva_Fecha_Inicio, M.Reserva_Cant_Noches, R.regimen_codigo, C.cliente_codigo, H.hotel_codigo
  FROM FAGD.Regimen R, FAGD.Hotel H, FAGD.Cliente C, gd_esquema.Maestra M
  WHERE M.Regimen_Descripcion = R.regimen_descripcion AND 
        M.Cliente_Mail = C.cliente_mail AND
     M.Cliente_Apellido = C.cliente_apellido AND
     M.Cliente_Nombre = C.cliente_nombre AND
     M.Hotel_Calle = H.hotel_calle AND 
     M.Hotel_Nro_Calle = H.hotel_nroCalle AND 
     M.Cliente_Pasaporte_Nro = C.cliente_nroDocumento
  ORDER BY M.Reserva_Codigo

INSERT INTO FAGD.Reserva ([reserva_codigo],[reserva_fechaInicio],[reserva_cantNoches],[reserva_codigoRegimen],[reserva_errorCliente],[reserva_codigoHotel])
  SELECT DISTINCT M.Reserva_codigo, M.Reserva_Fecha_Inicio, M.Reserva_Cant_Noches, R.regimen_codigo, clieE.errorCliente_codigo, H.hotel_codigo
  FROM FAGD.Regimen R, FAGD.Hotel H, FAGD.errorCliente clieE, gd_esquema.Maestra M
  WHERE M.Regimen_Descripcion = R.regimen_descripcion AND
        M.Cliente_Mail = clieE.errorCliente_mail AND
     M.Cliente_Apellido = clieE.errorCliente_apellido AND
     M.Cliente_Nombre = clieE.errorCliente_nombre AND 
     M.Hotel_Calle = H.hotel_calle AND 
     M.Hotel_Nro_Calle = H.hotel_nroCalle AND 
     M.Cliente_Pasaporte_Nro = clieE.errorCliente_nroDocumento
  ORDER BY M.Reserva_Codigo

SET IDENTITY_INSERT FAGD.Reserva OFF

GO

UPDATE FAGD.Reserva
	SET reserva_fechaFin = (reserva_fechaInicio+reserva_cantNoches)


UPDATE FAGD.Reserva
	SET reserva_estado = CASE WHEN (reserva_codigo IN (SELECT DISTINCT M.Reserva_Codigo FROM gd_esquema.Maestra M
						WHERE 	reserva_codigo = M.Reserva_Codigo AND M.Factura_Nro IS NOT NULL AND M.Estadia_Fecha_Inicio IS NOT NULL
						AND M.Estadia_Fecha_Inicio < (SELECT GETDATE())))
						THEN
							(SELECT estado_codigo FROM FAGD.Estado
						WHERE 	estado_descripcion = 'RESERVA CANCELADA POR NO-SHOW')
							  WHEN (reserva_codigo IN (SELECT DISTINCT M.Reserva_Codigo FROM gd_esquema.Maestra M
						WHERE 	reserva_codigo = M.Reserva_Codigo AND M.Factura_Nro IS NOT NULL AND M.Estadia_Fecha_Inicio IS NOT NULL
						AND M.Estadia_Fecha_Inicio > (SELECT GETDATE())))
					    THEN
							(SELECT estado_codigo FROM FAGD.Estado
						WHERE 	estado_descripcion = 'RESERVA CORRECTA')
                 ELSE
					   (SELECT estado_codigo FROM FAGD.Estado
					    WHERE 	estado_descripcion = 'RESERVA CANCELADA DESDE TABLA MAESTRA')
				END
				GO

INSERT INTO FAGD.ReservaxHabitacion(reserva_codigo, habitacion_codigo)
		SELECT DISTINCT R.reserva_codigo, ha.habitacion_codigo
		FROM gd_esquema.Maestra M, FAGD.Habitacion ha, FAGD.Reserva R, FAGD.Hotel ho
		WHERE  M.Hotel_Calle = ho.hotel_calle AND
		       M.Hotel_Ciudad = ho.hotel_ciudad AND
			   M.Hotel_Nro_Calle = ho.hotel_nroCalle AND
			   M.Hotel_CantEstrella = ho.hotel_cantEstrellas AND
			   M.Habitacion_Numero = ha.habitacion_nro AND
		       M.Habitacion_Piso = ha.habitacion_piso AND
		       ha.habitacion_codigoHotel = ho.hotel_codigo AND
			   M.Reserva_Codigo = R.reserva_codigo
		ORDER BY reserva_codigo



UPDATE FAGD.Reserva
	SET reserva_cantHuespedes = 
	(SELECT tipoHa.habitacionTipo_cantHuespedes 
	FROM FAGD.HabitacionTipo tipoHa, FAGD.Habitacion ha, FAGD.ReservaXHabitacion resxh, FAGD.Hotel ho
					WHERE Reserva.reserva_codigo = resxh.reserva_codigo AND
					resxh.habitacion_codigo = ha.habitacion_codigo AND
					ha.habitacion_tipoCodigo = tipoHa.habitacionTipo_codigo AND
					ha.habitacion_codigoHotel = ho.hotel_codigo)
	

UPDATE FAGD.Reserva
	SET reserva_costoTotal = ((SELECT regimen_precioBase FROM FAGD.Regimen R WHERE reserva_codigoRegimen = R.regimen_codigo) * 
					(SELECT habitacionTipo_porcentual FROM FAGD.HabitacionTipo tipoHa, FAGD.Habitacion ha, FAGD.ReservaXHabitacion resxh
					WHERE Reserva.reserva_codigo = resxh.reserva_codigo AND
					resxh.habitacion_codigo = ha.habitacion_codigo AND
					ha.habitacion_tipoCodigo = tipoHa.habitacionTipo_codigo) +

					((SELECT ho.hotel_cantEstrellas FROM FAGD.Hotel ho, FAGD.Habitacion ha, FAGD.ReservaXHabitacion resxh
					WHERE Reserva.reserva_codigo = resxh.reserva_codigo AND
					resxh.habitacion_codigo = ha.habitacion_codigo AND
					ho.hotel_codigo = ha.habitacion_codigoHotel) * 
					
					((SELECT ho.hotel_recarga_estrellas FROM FAGD.Hotel ho,FAGD.Habitacion ha, FAGD.ReservaXHabitacion resxh
					WHERE Reserva.reserva_codigo = resxh.reserva_codigo AND
					resxh.habitacion_codigo = ha.habitacion_codigo AND
					ho.hotel_codigo = ha.habitacion_codigoHotel)))) * reserva_cantNoches

GO


INSERT INTO FAGD.Estadia (estadia_fechaInicio, estadia_fechaFin, estadia_cantNoches, estadia_precioNoche, estadia_diasSobrantes, estadia_codigoReserva)
		SELECT DISTINCT 
		M.Estadia_Fecha_Inicio, 
		M.Estadia_Fecha_Inicio + M.Estadia_Cant_Noches, 
		M.Estadia_Cant_Noches, R.reserva_costoTotal / R.reserva_cantNoches,
		FAGD.calcularDiasSobrantesEstadia(R.reserva_fechaFin, M.Estadia_Fecha_Inicio + M.Estadia_Cant_Noches), 
		M.Reserva_Codigo

		FROM gd_esquema.Maestra M, FAGD.Reserva R
		WHERE R.reserva_codigo = M.Reserva_Codigo AND
		M.Estadia_Fecha_Inicio IS NOT NULL AND 
		M.Estadia_Cant_Noches IS NOT NULL
		ORDER BY M.Reserva_Codigo
GO



----------



INSERT INTO FAGD.HotelXRegimen (hotel_codigo,regimen_codigo)
		SELECT DISTINCT hotel_codigo, regimen_codigo
		FROM gd_esquema.Maestra Maestra, FAGD.Hotel Hotel, FAGD.Regimen Regimen
		WHERE Hotel.hotel_calle = Maestra.Hotel_Calle AND Hotel.hotel_nroCalle = Maestra.Hotel_Nro_Calle AND Hotel.hotel_ciudad = Maestra.Hotel_Ciudad AND Regimen.regimen_descripcion = Maestra.Regimen_Descripcion AND Regimen.regimen_precioBase = Maestra.Regimen_Precio
		ORDER BY Hotel.hotel_codigo
GO



--Todo lo de factura por aca
--Facturas cliente ok

SET IDENTITY_INSERT FAGD.Factura ON

INSERT INTO FAGD.Factura(factura_nro, factura_codigoEstadia, factura_fecha, factura_total, factura_clienteCodigo, factura_estado) 
		SELECT DISTINCT Maestra.Factura_Nro, Estadia.estadia_codigo, Maestra.Factura_Fecha, Maestra.Factura_Total,  C.cliente_codigo, 1
		FROM gd_esquema.Maestra Maestra, FAGD.Estadia Estadia, FAGD.Cliente C, FAGD.Reserva R, FAGD.ModalidadPago mp
		WHERE Maestra.Factura_Nro IS NOT NULL AND 
		Maestra.Reserva_codigo = R.reserva_codigo AND
		Estadia.estadia_codigoReserva =  R.reserva_codigo AND
		C.cliente_codigo = R.reserva_clienteCodigo
		ORDER BY Maestra.Factura_Nro

SET IDENTITY_INSERT FAGD.Factura OFF


--Facturas clienteError

SET IDENTITY_INSERT FAGD.Factura ON

INSERT INTO FAGD.Factura(factura_nro, factura_codigoEstadia, factura_fecha, factura_total, factura_clienteCodigo, factura_estado) 
		SELECT DISTINCT Maestra.Factura_Nro, Estadia.estadia_codigo, Maestra.Factura_Fecha, Maestra.Factura_Total,  clieE.errorCliente_codigo, 1
		FROM gd_esquema.Maestra Maestra, FAGD.Estadia Estadia, FAGD.ErrorCliente clieE, FAGD.Reserva R
		WHERE Maestra.Factura_Nro IS NOT NULL AND
		Maestra.Reserva_codigo = R.reserva_codigo AND
		Estadia.estadia_codigoReserva = R.reserva_codigo AND
		clieE.errorCliente_codigo = R.reserva_errorCliente
		ORDER BY Maestra.Factura_Nro

SET IDENTITY_INSERT FAGD.Factura OFF
GO



--Migracion ITEM FACTURAS
--Si es una estadia
INSERT INTO FAGD.ItemFactura (itemFactura_nroFactura, itemFactura_cantidad, itemFactura_itemMonto, itemFactura_descripcion)
SELECT m.Factura_Nro, m.Item_Factura_Cantidad, m.Item_Factura_Monto*m.Reserva_Cant_Noches, 'Estadia'
	FROM  gd_esquema.Maestra m, FAGD.Factura F
	WHERE m.Consumible_Codigo IS NULL AND
	      m.Factura_Nro = F.factura_nro


-- Si es un consumible

INSERT INTO FAGD.ItemFactura (itemFactura_nroFactura, itemFactura_cantidad, itemFactura_itemMonto, itemFactura_descripcion)
SELECT m.Factura_Nro, SUM(m.Item_Factura_Cantidad), SUM(m.Item_Factura_Cantidad*C.consumible_precio), m.Consumible_Descripcion
	FROM gd_esquema.Maestra m, FAGD.Factura F, FAGD.Consumible C
	WHERE m.Consumible_Codigo IS NOT NULL AND
	      m.Factura_Nro = F.factura_nro AND
		  m.Consumible_Codigo = C.consumible_codigo AND
		  m.Consumible_Descripcion = C.consumible_descripcion AND
		  m.Consumible_Precio = C.consumible_precio
	GROUP BY m.Factura_Nro, m.Consumible_Descripcion
	ORDER BY m.Factura_Nro ASC

GO

INSERT INTO FAGD.ConsumibleXEstadia (estadia_codigo, consumible_codigo, habitacion_codigo, itemFactura_codigo)
		SELECT DISTINCT E.estadia_codigo, M.Consumible_Codigo, ha.habitacion_codigo, i.itemFactura_codigo
		FROM gd_esquema.Maestra M, FAGD.Estadia E, FAGD.Habitacion ha, FAGD.ReservaXHabitacion resxh, FAGD.ItemFactura i
		WHERE M.Consumible_Codigo IS NOT NULL AND
		 M.Reserva_Codigo = resxh.reserva_codigo AND
		 M.Reserva_Codigo = E.estadia_codigoReserva AND
         resxh.habitacion_codigo = ha.habitacion_codigo AND
		 M.Factura_Nro = i.itemFactura_nroFactura AND
		 i.itemFactura_descripcion = m.Consumible_Descripcion
ORDER BY E.estadia_codigo
GO

-----------------------------CLIENTE X ESTADIA---------------------------------------------------

INSERT INTO FAGD.ClienteXEstadia (cliente_codigo,errorCliente_codigo,estadia_codigo)
	(SELECT DISTINCT cli.cliente_codigo, NULL, est.estadia_codigo FROM gd_esquema.Maestra m, FAGD.Cliente cli, FAGD.Estadia est
	 WHERE  m.Estadia_Fecha_Inicio IS NOT NULL AND
			m.Cliente_Pasaporte_Nro = cli.cliente_nroDocumento AND
			m.Cliente_Apellido = cli.cliente_apellido AND
			m.Cliente_Nombre = cli.cliente_nombre AND
			m.Estadia_Fecha_Inicio = est.estadia_fechaInicio AND
			m.Estadia_Cant_Noches = est.estadia_cantNoches AND
			m.Reserva_Codigo = est.estadia_codigoReserva
	UNION ALL
	 SELECT DISTINCT NULL, cliE.errorCliente_codigo, est.estadia_codigo
		FROM gd_esquema.Maestra m, FAGD.ErrorCliente cliE, FAGD.Estadia est
	 WHERE  m.Estadia_Fecha_Inicio IS NOT NULL AND
			m.Cliente_Pasaporte_Nro = cliE.errorCliente_nroDocumento AND
			m.Cliente_Apellido = cliE.errorCliente_apellido AND
			m.Cliente_Nombre = cliE.errorCliente_nombre AND
			m.Estadia_Fecha_Inicio = est.estadia_fechaInicio AND
			m.Estadia_Cant_Noches = est.estadia_cantNoches AND
			m.Reserva_Codigo = est.estadia_codigoReserva
	)
GO

UPDATE FAGD.ClienteXEstadia
SET habitacion_codigo = (SELECT DISTINCT ha.habitacion_codigo FROM FAGD.Estadia est, FAGD.Habitacion ha,gd_esquema.Maestra m, FAGD.Hotel ho
	  WHERE ClienteXEstadia.estadia_codigo = est.estadia_codigo AND
			est.estadia_codigoReserva = m.Reserva_Codigo AND
			ho.hotel_nroCalle = M.Hotel_Nro_Calle AND
			ha.habitacion_codigoHotel = ho.hotel_codigo AND
			ha.habitacion_nro = M.Habitacion_Numero AND
			ha.habitacion_piso = M.Habitacion_Piso)


-------------------------------- ROLES Y FUNCIONALIDADES INICIALES --------------------------------- 

INSERT INTO FAGD.Rol (rol_nombre,rol_estado)	
		values ('Administrador General',1),('Administrador',1),('Recepcionista',1),('Cliente',1)
GO

INSERT INTO FAGD.Funcionalidad(funcionalidad_detalle)
		values ('ABM_Reservas'),('ABM_Estadias'),('ABM_Clientes'),('ABM_Consumibles'),('ABM_Roles'),('ABM_Hoteles'),
		       ('ABM_Habitaciones'),('ABM_Usuarios'),('ABM_Regimenes'),('Estadisticas')
GO

/*Funcionalidades del administrador general*/
INSERT INTO FAGD.RolXFuncionalidad(rol_codigo,funcionalidad_codigo)  
		values (1,1),(1,2),(1,3),(1,4),(1,5),(1,6),(1,7),(1,8),(1,9),(1,10)
GO

/*Funcionalidades del administrador*/
INSERT INTO FAGD.RolXFuncionalidad(rol_codigo,funcionalidad_codigo)  
		values (2,4),(2,5),(2,6),(2,7),(2,8),(2,9),(2,10)
GO

/*Funcionalidades del recepcionista*/
INSERT INTO FAGD.RolXFuncionalidad(rol_codigo,funcionalidad_codigo)
		values (3,1),(3,2),(3,3),(3,4)
GO

/*Funcionalidades del cliente*/
INSERT INTO FAGD.RolXFuncionalidad(rol_codigo,funcionalidad_codigo)
		values (4,1)
GO

/*Creación del Usuario 'admin'*/
INSERT INTO FAGD.Usuario (usuario_username,usuario_password,usuario_estado)
		values ('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',1)
GO

INSERT INTO FAGD.Usuario (usuario_username,usuario_estado, usuario_mail)
		values ('GUEST', 1, '')
GO

INSERT INTO FAGD.UsuarioXRolXHotel(usuario_username,rol_codigo,hotel_codigo)
	   SELECT 'admin',1,hotel_codigo FROM FAGD.Hotel
GO

INSERT INTO FAGD.UsuarioXRolXHotel(usuario_username, rol_codigo, hotel_codigo)
		select distinct U.usuario_username, R.rol_codigo, H.hotel_codigo from FAGD.Rol R, FAGD.Usuario U, FAGD.Hotel H
			where R.rol_nombre = 'Cliente' and U.usuario_username = 'GUEST';
GO




-----------------------	 CREACI�N DE PROCEDURES PARA LA APLICACI�N   ----------------------- 


-----------------------	  PROCEDIMIENTOS PARA LISTADO ESTADÍSTICO    -----------------------

/*
Este procedimiento filtra y ordena 5 hoteles con mayor cantidad de reservas canceladas, contabilizando la cantidad de registros que aparecen en la tablaReservaCancelada
que se relacionen con reservas que poseen habitaciones que pertenecen al hotel en cuestión.
*/

CREATE PROCEDURE FAGD.ListadoHotelesMayorCantidadReservasCanceladas @trimestreInicio DATETIME, @trimestreFin DATETIME
AS	BEGIN
		
	DECLARE @inicioTrimestre DATETIME
	DECLARE @finTrimestre DATETIME
	
	SET @inicioTrimestre = CONVERT(DATETIME,@trimestreInicio,121)
	SET @finTrimestre = CONVERT(DATETIME,@trimestreFin,121)

SELECT TOP 5 hotel.hotel_codigo AS CodigoDelHotel, COUNT(resCancel.reservaCancelada_codigoReserva) AS TotalCancelaciones 

FROM FAGD.Hotel hotel, FAGD.Habitacion hab, FAGD.ReservaXHabitacion resXHab,
	 FAGD.Reserva res, FAGD.ReservaCancelada resCancel

WHERE hotel.hotel_codigo = hab.habitacion_codigoHotel AND
	  hab.habitacion_codigo = resXHab.habitacion_codigo AND
	  resXHab.reserva_codigo = res.reserva_codigo AND
	  res.reserva_codigo = resCancel.reservaCancelada_codigoReserva AND
	  res.reserva_codigoHotel = hotel.hotel_codigo AND
	  resCancel.reservaCancelada_fechaCancelacion BETWEEN @inicioTrimestre AND @finTrimestre
GROUP BY hotel.hotel_codigo	
ORDER BY TotalCancelaciones DESC		
END
GO


---------------------------------------------------------------------------------------------------

/*
Este procedimiento filtra y ordena 5 hoteles con mayor cantidad de consumibles facturados, limitados por inicio y fin de un trimestre en un año en particular.
Se busca todas las facturas que pertenezcan a estadias que transcurren gracias a reservas de habitaciones de cada uno de los hoteles 
y se contabiliza la cantidad de registros que dicha tabla resultado genera.
*/

CREATE PROCEDURE FAGD.ListadoHotelesMayorCantidadConsumFacturados @trimestreInicio DATETIME, @trimestreFin DATETIME
AS BEGIN
		
	DECLARE @inicioTrimestre DATETIME
	DECLARE @finTrimestre DATETIME

	SET @inicioTrimestre = CONVERT(DATETIME,@trimestreInicio,121)
	SET @finTrimestre = CONVERT(DATETIME,@trimestreFin,121)

SELECT TOP 5 hotel.hotel_codigo AS CodigoDelHotel, COUNT(C.consumible_codigo) AS CantidadFacturada
FROM FAGD.Consumible C, FAGD.ConsumibleXEstadia consxEst, FAGD.Factura F, FAGD.Reserva R, FAGD.ReservaXHabitacion resxh, FAGD.Hotel hotel, FAGD.Habitacion ha, FAGD. Estadia E
WHERE
     F.factura_codigoEstadia = E.estadia_codigo AND
	 consXEst.estadia_codigo = E.estadia_codigo AND
	 consXEst.consumible_codigo = C.consumible_codigo AND
	 E.estadia_codigoReserva = R.reserva_codigo AND
	 R.reserva_codigo = resxh.reserva_codigo AND
	 resxh.habitacion_codigo = ha.habitacion_codigo AND
	 ha.habitacion_codigoHotel = hotel.hotel_codigo AND
	 F.factura_fecha BETWEEN @inicioTrimestre AND @finTrimestre
GROUP BY hotel.hotel_codigo
ORDER BY CantidadFacturada desc
END
GO

---------------------------------------------------------------------------------------------------


/*
Este procedimiento filtra y ordena 5 hoteles con mayor cantidad de días de baja, limitado por trimestre inicio y fin en un año en particular. 
Se busca al hotel para determinar si su codigo figura en la tabla BajaHotel y en base a si pertenece se contabilizan la cantidad de dias que el hotel
permanecio de baja. Si casualmente la baja del hotel concluye posteriormente al trimestre, solo se contabilizan estrictamente los dias desde que comienza hasta
que el trimestre finaliza, y de no suceder esto, se contabilizan todos los que transcurran hasta que la fecha de finalizacion de la baja lo indique.
*/

CREATE PROCEDURE FAGD.ListadoHotelesMayorCantidadDiasDeBaja @trimestreInicio DATETIME, @trimestreFin DATETIME
AS BEGIN
		
	DECLARE @inicioTrimestre DATETIME
	DECLARE @finTrimestre DATETIME

	SET @inicioTrimestre = CONVERT(DATETIME,@trimestreInicio,121)
	SET @finTrimestre = CONVERT(DATETIME,@trimestreFin,121)

SELECT TOP 5 bajaTotal.CodigoDelHotel AS CodigoDelHotel, hotel.hotel_calle ,SUM(bajaTotal.Dias) AS DiasDeBaja 
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

/*
Este procedimiento filtra y ordena 5 habitaciones con mayor cantidad de días de uso, limitado por trimestre inicio y fin en un año en particular. Se localiza en la tabla
ReservaXHabitacion que relaciona las habitaciones con las reservas que las involucra y se cerciora que dicha reserva ha sido efectivizada, es decir
un codigo estadia se ha generado a partir de ella. Finalmente se cuentan la cantidad de veces que aparece el codigo de cada habitacion para
revisar cuantas veces se efectivizo una estadia para esa habitacion y se suma la cantidad de noches  del campo reserva para determinar exactamente 
cuantos dias dicha habitacion fue utilizada.
*/

CREATE PROCEDURE FAGD.ListadoHabitacionesMasVecesUtilizadas @trimestreInicio DATETIME, @trimestreFin DATETIME 
AS BEGIN

	DECLARE @inicioTrimestre DATETIME
	DECLARE @finTrimestre DATETIME
	
	SET @inicioTrimestre = CONVERT(DATETIME,@trimestreInicio,121)
	SET @finTrimestre = CONVERT(DATETIME,@trimestreFin,121)

SELECT DISTINCT TOP 5  ha.habitacion_codigo AS CodigoDeLaHabitacion, ha.habitacion_codigoHotel AS CodigoDelHotel, consultaOcupacionHab.cantidadDias AS CantidadDeDiasUsada, consultaOcupacionHab.cantidadEstadias AS VecesOcupada

FROM
	(SELECT  ha.habitacion_codigo, ha.habitacion_codigoHotel, SUM(res.reserva_cantNoches) AS cantidadDias, COUNT(resXHab.habitacion_codigo) AS cantidadEstadias
	  FROM FAGD.ReservaXHabitacion resXHab, FAGD.Habitacion ha, FAGD.Reserva res, FAGD.Hotel hotel, FAGD.Estadia est
	  WHERE resXHab.habitacion_codigo = ha.habitacion_codigo AND
		    resXHab.reserva_codigo = res.reserva_codigo AND
		    res.reserva_codigoHotel = hotel.hotel_codigo AND
		    est.estadia_codigoReserva = res.reserva_codigo AND
			est.estadia_fechaInicio >= @inicioTrimestre AND
			est.estadia_fechaFin <= @finTrimestre
      GROUP BY ha.habitacion_codigo, ha.habitacion_codigoHotel) AS consultaOcupacionHab,
		

	FAGD.Hotel hotel, FAGD.Habitacion ha,	FAGD.Estadia est

WHERE consultaOcupacionHab.habitacion_codigoHotel = hotel.hotel_codigo AND
	  ha.habitacion_codigo = consultaOcupacionHab.habitacion_codigo
ORDER BY cantidadDias DESC
	
END
GO

---------------------------------------------------------------------------------------------------

/*
Este procedimiento filtra y ordena 5 clientes con mayor puntaje segun un trimestre, limitado por trimestre inicio y fin en un año en particular. A partir de esto se filtran aquellos 
item facturas de una factura que corresponden a una estadia en la que ese cliente participo y se contabilizan tanto si son gastos de alojamientos, como si son 
consumibles, seleccionados en consultas separadas pero adicionados al final.
*/

CREATE PROCEDURE FAGD.ListadoClientesConMayoresPuntajes @trimestreInicio DATETIME, @trimestreFin DATETIME
AS	BEGIN
		
	DECLARE @inicioTrimestre DATETIME
	DECLARE @finTrimestre DATETIME
	
	SET @inicioTrimestre = CONVERT(DATETIME,@trimestreInicio,121)
	SET @finTrimestre = CONVERT(DATETIME,@trimestreFin,121)

SELECT TOP 5 cli.cliente_codigo, cli.cliente_nombre AS Nombre, cli.cliente_apellido AS Apellido, CAST(puntosPorLaEstadia.Puntos+puntosPorConsumibles.Puntos AS decimal(18,2)) AS Puntaje
FROM 
(SELECT clie.cliente_codigo, est.estadia_codigo, SUM(fact.factura_total) AS Gasto, SUM(fact.factura_total)/10 AS Puntos
	FROM FAGD.Cliente clie, FAGD.ClienteXEstadia clieXEst, FAGD.Estadia est, FAGD.Factura fact
	WHERE clie.cliente_codigo = clieXEst.cliente_codigo AND
          clieXEst.estadia_codigo = est.estadia_codigo AND
		  factura_codigoEstadia = est.estadia_codigo AND
		  fact.factura_fecha BETWEEN @inicioTrimestre AND @finTrimestre
	GROUP BY clie.cliente_codigo, est.estadia_codigo) AS puntosPorLaEstadia, 

(SELECT consXEst.estadia_codigo,  SUM(I.itemFactura_itemMonto) AS Gasto,  SUM(I.itemFactura_itemMonto)/10 AS Puntos
	FROM FAGD.ConsumibleXEstadia consXEst, FAGD.Factura F, FAGD.ItemFactura I
	WHERE consXEst.itemFactura_codigo = I.itemFactura_codigo AND
		  I.itemFactura_nroFactura = F.factura_nro AND
		  I.itemFactura_descripcion <> 'Estadia' AND
		  F.factura_fecha BETWEEN @inicioTrimestre AND @finTrimestre
	GROUP BY consXEst.estadia_codigo) AS puntosPorConsumibles,
	
FAGD.Cliente cli, FAGD.Estadia est, FAGD.Reserva res
WHERE cli.cliente_codigo = res.reserva_clienteCodigo AND
		est.estadia_codigoReserva = res.reserva_codigo AND 
		puntosPorConsumibles.estadia_codigo = est.estadia_codigo  AND
		puntosPorLaEstadia.estadia_codigo = est.estadia_codigo 
ORDER BY Puntaje DESC
END
GO


---------------------------------------------------------------------------------------------------

/*
Actualiza los valores en el estado de reserva a partir de la fecha de configuracion actual del sistema, siendo cancelada por no show si
ya paso la fecha de inicio pactada o correcta si todavia esta por venir. Adicionalmente se suman los inserts a reservaCancelada para aquellas reservas
que si han expirado. Aclaracion: se borra de la tabla cancelada estos registros cargados excepcionalmente por no show de fecha config al principio del 
procedure por cuestiones de performance.
*/

CREATE PROCEDURE FAGD.SetearEstadosReservaSegunConfig @fechaDelConfig DATETIME
AS BEGIN

DECLARE @respuestaTran numeric(18,0),
        @estadoExpirado numeric(18,0),
		@estadoVigente numeric(18,0),
        @fechaArchivo DATETIME

SET @fechaArchivo = CONVERT(DATETIME,@fechaDelConfig,121)

BEGIN TRAN ta
BEGIN TRY

DELETE FROM FAGD.ReservaCancelada WHERE reservaCancelada_motivo = 'Cancelada por no-show al inicio del sistema'

SET @estadoExpirado = (SELECT estado_codigo FROM FAGD.Estado WHERE estado_descripcion = 'RESERVA CANCELADA POR NO-SHOW')
UPDATE FAGD.Reserva
SET reserva_estado = @estadoExpirado WHERE reserva_codigo IN (SELECT DISTINCT R.reserva_codigo FROM FAGD.Reserva R
		WHERE R.reserva_fechaInicio < @fechaArchivo AND (R.reserva_estado = 1 OR R.reserva_estado = 5))


SET @estadoVigente = (SELECT estado_codigo FROM FAGD.Estado WHERE estado_descripcion = 'RESERVA CORRECTA')
UPDATE FAGD.Reserva
SET reserva_estado = @estadoVigente WHERE reserva_codigo IN (SELECT DISTINCT R.reserva_codigo FROM FAGD.Reserva R
		WHERE R.reserva_fechaInicio >= @fechaArchivo AND (R.reserva_estado = 1 OR R.reserva_estado = 5))

INSERT INTO FAGD.ReservaCancelada(reservaCancelada_nombreUsuario,reservaCancelada_codigoReserva,reservaCancelada_motivo,reservaCancelada_fechaCancelacion)
			SELECT DISTINCT 'GUEST',reserva_codigo,'Cancelada por no-show al inicio del sistema',reserva_fechaInicio 
			FROM FAGD.Reserva WHERE	reserva_estado = @estadoExpirado
						
				
 SET @respuestaTran = 1
	SELECT @respuestaTran
COMMIT TRAN ta
END TRY
BEGIN CATCH
ROLLBACK TRAN ta
SET @respuestaTran=0
SELECT @respuestaTran
END CATCH
END
GO


---------------------------------------------------------------------------------------------------

/*
Realiza el checkin de una reserva, actualizando el estado a efectivizada (6), y cargando los valores de cantidad de noches y el precio de noche preCalculados
gracias a los campos de reserva que serán aprovechados en la inserción del nuevo registro de Estadía.
*/

CREATE PROCEDURE FAGD.CheckinParaEstadia @reservaNro numeric(18,0), @username nvarchar(255), @fechaInicio DATETIME
AS BEGIN



DECLARE @respuestaTran numeric(18,0),
		@precioNoche numeric(18,0),
		@cantNoches numeric(18,0),
		@fechaIngreso DATETIME,
		@estadoEfectivo numeric(18,0),
		@fechaPactadaDeEgreso DATETIME

SET @fechaIngreso = CONVERT(DATETIME,@fechaInicio,121)

BEGIN TRAN transacc
BEGIN TRY

	SET @estadoEfectivo = (SELECT estado_codigo FROM FAGD.Estado WHERE estado_descripcion = 'RESERVA EFECTIVIZADA')
    SET @cantNoches = (SELECT reserva_cantNoches FROM FAGD.Reserva WHERE reserva_codigo = @reservaNro)
    SET @precioNoche = (SELECT (reserva_costoTotal)/@cantNoches FROM FAGD.Reserva WHERE reserva_codigo = @reservaNro)
	SET @fechaPactadaDeEgreso = (SELECT reserva_fechaFin FROM FAGD.Reserva where reserva_codigo = @reservaNro)
  	INSERT INTO FAGD.Estadia(estadia_codigoReserva, estadia_fechaInicio, estadia_fechaFin, estadia_usuarioRegistrador, estadia_precioNoche, estadia_cantNoches)
	VALUES(@reservaNro,@fechaIngreso,@fechaPactadaDeEgreso ,@username,@precioNoche,@cantNoches);

  	UPDATE FAGD.Reserva SET reserva_estado = @estadoEfectivo WHERE reserva_codigo = @reservaNro
	SET @respuestaTran = (SELECT SCOPE_IDENTITY())
	
	SELECT @respuestaTran AS respuestaDeLaTransacc
COMMIT TRAN transacc
END TRY
BEGIN CATCH
ROLLBACK TRAN transacc
SET @respuestaTran = 0
SELECT @respuestaTran AS respuestaDeLaTransacc
END CATCH
END
GO


------------------------------------------------------------------------------

/*
Se registra la estadia tomando a cada cliente del formulario que se asocio a la estadia que esta por iniciarse insertando ambos campos en la tabla intermedia.
*/

CREATE PROC FAGD.ConfirmarEstadiaXCliente @clienteCodigo numeric(18,0), @estadiaCodigo numeric(18,0)
AS BEGIN

DECLARE @respuestatran numeric(18,0)
BEGIN TRAN transacc
BEGIN TRY
	INSERT INTO FAGD.ClienteXEstadia (cliente_codigo,estadia_codigo) 
	VALUES (@clienteCodigo,@estadiaCodigo);
	SET @respuestatran = (SELECT estadia_codigo FROM FAGD.ClienteXEstadia WHERE estadia_codigo = @estadiaCodigo AND cliente_codigo = @clienteCodigo)
	SELECT @respuestatran
COMMIT TRAN transacc
END TRY
BEGIN CATCH
ROLLBACK TRAN transacc
SET @respuestatran=0
SELECT @respuestatran
END CATCH
END
GO

------------------------------------------------------------------------------

/*
Se registra la habitacion que el cliente asociada a la estadia particular utilizará
*/

CREATE PROC FAGD.SeleccionarHabitacionDeCliente @habitacion numeric(18,0), @cliente numeric(18,0), @estadia numeric(18,0)
AS BEGIN

DECLARE @respuestaTran numeric(18,0)
BEGIN TRAN transacc
BEGIN TRY
	UPDATE FAGD.ClienteXEstadia
	SET habitacion_codigo = @habitacion WHERE estadia_codigo = @estadia AND cliente_codigo = @cliente
	SET @respuestaTran = 1
	SELECT @respuestaTran
COMMIT TRAN transacc
END TRY
BEGIN CATCH
ROLLBACK TRAN transacc
SET @respuestaTran=0
SELECT @respuestaTran
END CATCH
END
GO

------------------------------------------------------------------------------

/*
Se efectiviza el checkout para todas las habitaciones de una estadia, comprobando la cantidad de dias que realmente se utilizaron de los que originalmente estaban
previstos que el cliente aprovechara, para establecer la nueva fecha de finalizacion y tener en cuenta cuantos dias de la estadia se facturarán como
"Dia no utilizado de Alojamiento" mas adelante en la factura.
*/


CREATE PROC FAGD.CheckoutParaEstadia @nroEstadia numeric(18,0), @fechaDelCheckout DATETIME, @username nvarchar(255)
AS BEGIN
 

DECLARE @respuestaTran numeric(18,0),
		@cantDias numeric(18,0),
		@diasSobrantes numeric(18,0),
		@precioNoche numeric(18,0),
		@nroReserva numeric(18,0),
		@resHasta datetime,
		@nuevafechaEgreso DATETIME,
		@factura numeric(18,0),
		@montoEstadia numeric(18,0)

SET @nuevafechaEgreso = CONVERT(DATETIME,@fechaDelCheckout,121)

BEGIN TRAN transacc
BEGIN TRY
	SET @cantDias = DATEDIFF(day,(SELECT estadia_fechaInicio FROM FAGD.Estadia WHERE estadia_codigo = @nroEstadia ),@nuevafechaEgreso);
	SET @nroReserva = (SELECT estadia_codigoReserva FROM FAGD.Estadia WHERE estadia_codigo = @nroEstadia);
	SET @resHasta = (SELECT reserva_fechaFin FROM FAGD.Reserva WHERE reserva_codigo = @nroReserva);
	SET @diasSobrantes = DATEDIFF(day,@nuevafechaEgreso,@resHasta);
	
	UPDATE FAGD.Estadia
	SET
	    Estadia.estadia_usuarioFinalizador = @username,
		Estadia.estadia_fechaFin = @nuevafechaEgreso,
	    Estadia.estadia_diasSobrantes = @diasSobrantes,
	    Estadia.estadia_cantNoches =  @cantDias
		WHERE Estadia.estadia_codigo = @nroEstadia;
	
    SET @montoEstadia = (SELECT R.reserva_costoTotal FROM FAGD.Reserva R WHERE reserva_codigo = @nroReserva)
	SET @factura = (SELECT F.factura_nro FROM FAGD.Factura F WHERE factura_codigoEstadia = @nroEstadia)
	
	INSERT INTO FAGD.ItemFactura(itemFactura_nroFactura,itemFactura_descripcion,itemFactura_cantidad,itemFactura_itemMonto)
	VALUES(@factura,'Estadia',1, @montoEstadia)
	SET @respuestaTran = 1;
	SELECT @respuestaTran
	
COMMIT TRAN transacc
END TRY
BEGIN CATCH
ROLLBACK TRAN transacc
SET @respuestaTran=0
SELECT @respuestaTran 
END CATCH
END
GO

------------------------------------------------------------------------------

/*
Se registra un consumible solicitado por una habitacion de una estadia en particular, para lo cual se actualiza un itemFactura asociado a la factura que fue 
creada en la instancia de check-in para luego poder liquidar todos los consumos de manera unificada en la facturacion al momento del egreso.
*/

CREATE PROCEDURE FAGD.RegistrarConsuXEstXHabitacion @estadiaCodigo numeric(18,0), @consumibleCodigo numeric(18,0), @habCodigo numeric(18,0)
AS BEGIN

DECLARE @respuestaTran numeric(18,0)
DECLARE @itemFacturaAUpdatear numeric(18,0)
DECLARE @descripcionItem nvarchar(255)
DECLARE @factura numeric(18,0)
DECLARE @precio numeric(18,0)

BEGIN TRAN transacc
BEGIN TRY

		SET @precio = (SELECT consumible_precio FROM FAGD.Consumible WHERE consumible_codigo = @consumibleCodigo)
		SET @descripcionItem = (SELECT consumible_descripcion FROM FAGD.Consumible WHERE consumible_codigo = @consumibleCodigo)
		SET @factura = (SELECT factura_nro FROM FAGD.Factura WHERE factura_codigoEstadia = @estadiaCodigo)

		IF(EXISTS(SELECT itemFactura_codigo FROM FAGD.ItemFactura WHERE itemFactura_descripcion = @descripcionItem AND itemFactura_nroFactura = @factura))
		BEGIN
			SET @itemFacturaAUpdatear = (SELECT itemFactura_codigo FROM FAGD.ItemFactura WHERE itemFactura_descripcion = @descripcionItem AND itemFactura_nroFactura = @factura)
			UPDATE FAGD.ItemFactura 
				SET itemFactura_itemMonto = itemFactura_itemMonto + @precio, itemFactura_cantidad = itemFactura_cantidad + 1
		WHERE itemFactura_codigo = @itemFacturaAUpdatear

		INSERT INTO FAGD.ConsumibleXEstadia (estadia_codigo,consumible_codigo,habitacion_codigo,itemFactura_codigo) 
		VALUES (@estadiaCodigo,@consumibleCodigo,@habCodigo,@itemFacturaAUpdatear)

		END

		ELSE BEGIN

		INSERT INTO FAGD.ItemFactura(itemFactura_nroFactura,itemFactura_cantidad,itemFactura_itemMonto,itemFactura_descripcion)
		VALUES (@factura,1,@precio,@descripcionItem)

		SET @itemFacturaAUpdatear = (SELECT itemFactura_codigo FROM FAGD.ItemFactura WHERE itemFactura_descripcion = @descripcionItem AND itemFactura_nroFactura = @factura)

		INSERT INTO FAGD.ConsumibleXEstadia (estadia_codigo,consumible_codigo,habitacion_codigo,itemFactura_codigo) 
		VALUES (@estadiaCodigo,@consumibleCodigo,@habCodigo,@itemFacturaAUpdatear)

		END
		SET @respuestaTran = 1
		SELECT @respuestaTran
COMMIT TRAN transacc
END TRY
BEGIN CATCH
ROLLBACK TRAN transacc
SET @respuestaTran = 0
SELECT @respuestaTran
END CATCH
END
GO

-----------------------------------------------------------------------------

/*
Se genera la factura al instante de validarse el check-in para una estadía, dejando en NULL varios de los campos menos la fecha en que se genero, para poder
asociar los itemFactura adecuados posteriormente. El campo total es cargado con los costos de la estadia o consumiciones si los hubiese por alguna situacion
excepcional, pero posteriormente serán actualizados.
*/

CREATE PROCEDURE FAGD.RegistrarDatosInicialesFactura  @estadia numeric(18,0), @fechaActual DATETIME
AS BEGIN



DECLARE @respuestaTran numeric(18,0),
		@regimenEstadia numeric(18,0),
		@reservaAsociada numeric(18,0),
		@fechaEmision DATETIME,
		@totalAPagar numeric(18,2),
		@cliente numeric(18,0)

SET @fechaEmision = CONVERT(DATETIME,@fechaActual,121)

BEGIN TRAN transacc
BEGIN TRY
		SET @reservaAsociada = (SELECT estadia_codigoReserva FROM FAGD.Estadia WHERE estadia_codigo = @estadia);
		SET @cliente = (SELECT reserva_clienteCodigo FROM FAGD.Reserva WHERE reserva_codigo = @reservaAsociada);
		SET @regimenEstadia = (SELECT reserva_codigoRegimen FROM FAGD.Reserva WHERE reserva_codigo = @reservaAsociada);
	IF (@regimenEstadia != 3)
	BEGIN
	--Si hubieron consumiciones
	SET @totalAPagar = FAGD.calcularCostosEstadia(@estadia) + FAGD.calcularCostosConsumible(@estadia);
	INSERT INTO FAGD.Factura(factura_codigoEstadia,factura_clienteCodigo,factura_fecha,factura_total)
	 VALUES (@estadia,@cliente,@fechaEmision,@totalAPagar);
	END
	ELSE BEGIN
	--Si no las hubieron
	SET @totalAPagar = FAGD.calcularCostosEstadia(@estadia);
	INSERT INTO FAGD.Factura(factura_codigoEstadia,factura_clienteCodigo,factura_fecha,factura_total)
	 VALUES (@estadia,@cliente,@fechaEmision,@totalAPagar);
	END
		SET @respuestaTran = (SELECT SCOPE_IDENTITY())
		SELECT @respuestaTran
COMMIT TRAN	transacc
END TRY
BEGIN CATCH
ROLLBACK TRAN transacc
SET @respuestaTran = 0
SELECT @respuestaTran
END CATCH
END
GO


----------------------------------------------------------------------------------------------------------------------------------------------

/*
Se actualiza la factura previamente creada con los valores definitivos, tanto el total a pagar, como la fecha de facturacion definitiva (en la que será impresa)
y además se detallara finalmente la modalidad de pago que el cliente utilizará. En vistas de que el check-out de la estadia es OBLIGATORIO para que se le pueda efectuar
la facturación definitiva en todos los casos la factura quedara con un valor de forma de pago definido y este no es contemplado en las instancias del check-in.
*/

CREATE PROC FAGD.EmitirFacturaActualizada @estadiaCodigo numeric(18,0), @modalidadPago numeric(18,0), @inicioDeEstadia DATETIME
AS BEGIN

DECLARE @regimenEstadia numeric(18,0),
		@reservaAsociada numeric(18,0),
		@totalAPagar numeric(18,2),
		@clienteAsociado numeric(18,0),
		@factura numeric(18,0),
		@respuestaTran numeric(18,0),
		@fechaDeFacturacionDefinitiva DATETIME

SET @fechaDeFacturacionDefinitiva = CONVERT(DATETIME,@inicioDeEstadia,121)

BEGIN TRAN transacc
BEGIN TRY
          SET @reservaAsociada = (SELECT estadia_codigoReserva FROM FAGD.Estadia WHERE estadia_codigo = @estadiaCodigo)
		  SET @regimenEstadia = (SELECT reserva_codigoRegimen FROM FAGD.Reserva WHERE reserva_codigo = @reservaAsociada)
		  SET @factura = (SELECT factura_nro FROM FAGD.Factura WHERE factura_codigoEstadia = @estadiaCodigo)
		  SET @clienteAsociado = (SELECT reserva_clienteCodigo FROM FAGD.Reserva WHERE reserva_codigo = @reservaAsociada)
      IF (@regimenEstadia != 3)
		  BEGIN
		  SET @totalAPagar = FAGD.calcularCostosEstadia(@estadiaCodigo) + FAGD.calcularCostosConsumible(@estadiaCodigo);
		UPDATE FAGD.Factura
			SET factura_modalidadPago = @modalidadPago, factura_fecha = @fechaDeFacturacionDefinitiva, factura_total = @totalAPagar
			WHERE factura_nro = @factura
	      END
		 ELSE BEGIN
			SET @totalAPagar = FAGD.calcularCostosEstadia(@estadiaCodigo);
		UPDATE FAGD.Factura
			SET factura_modalidadPago = @modalidadPago, factura_fecha = @fechaDeFacturacionDefinitiva, factura_total = @totalAPagar
			WHERE factura_nro = @factura
		END
	SET @respuestaTran = (SELECT factura_nro FROM FAGD.Factura WHERE factura_codigoEstadia = @estadiaCodigo AND factura_fecha = @fechaDeFacturacionDefinitiva)
	SELECT @respuestaTran
COMMIT TRAN	transacc
END TRY
BEGIN CATCH
ROLLBACK TRAN transacc
	SET @respuestaTran=0
	SELECT @respuestaTran
END CATCH
END
GO


----------------------------------------------------------------------------------------------------------------------------------------------

/*
Si el cliente eligio abonar su factura con tarjeta de credito/debito, este procedimiento registra los datos (a excepcion del codigo de seguridad) de la tarjeta
que se utilizará para concretar el pago asociandola a la factura correspondiente.
*/

CREATE PROC FAGD.AsociarTarjetaParaPago  @factura numeric(18), @entidadFinanc nvarchar(255), @numeroTarj numeric(18), @banco nvarchar(255), @titular nvarchar(255)
AS BEGIN

DECLARE @resultadoTran numeric(18,0)
BEGIN TRAN transacc
	BEGIN TRY
			INSERT INTO FAGD.Tarjeta(tarjeta_numero, tarjeta_banco, tarjeta_entidadFinanciera, tarjeta_titular) 
			VALUES (@numeroTarj, @banco, @entidadFinanc, @titular)
			UPDATE FAGD.Factura SET factura_tarjeta = (SELECT SCOPE_IDENTITY())
			WHERE factura_nro = @factura
			SET @resultadoTran = 1;
SELECT @resultadoTran
COMMIT TRAN transacc
END TRY
BEGIN CATCH
ROLLBACK TRAN transacc
SET @resultadoTran = 0
SELECT @resultadoTran
END CATCH
END
GO

------------------------------------------------------------------------------

/* Store procedure que recibe todos los datos de un cliente y los inserta en la tabla FAGD.Cliente. Devuelve el código del nuevo cliente si todo esta correcto. 
	En el caso que el cliente ingresado tenga el mismo tipo y número de documento que otro no se ingresara el cliente y devolver 2. Por otro lado, en caso de 
		de que el INSERT rompa, es decir se ingreso un mail ya existente se devolvera 0. */

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
						where cliente_tipoDocumento = @tipoDocumento and cliente_nroDocumento = @nroDocumento))
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
			set @respuesta = (SELECT SCOPE_IDENTITY());
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

---------------------------------------------------------------------------------------------------------------------------------

/* Al igual que el anterior, este Store procedure recibe todos los datos de un cliente ya existente. Se verifica nuevamente que el tipo y número de documento, y el
	mail ingresados no correspondan a otro cliente. En caso de todo este correcto, se updateara el cliente y se retornara 1. Si algo esta mal, devolvera 2 en el 
	primero de los casos y 0 en el segundo. */

create proc FAGD.modificarCliente
@codigo numeric(18),
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
			if (not exists(select * from FAGD.Cliente 
						where cliente_tipoDocumento = @tipoDocumento and cliente_nroDocumento = @nroDocumento and cliente_codigo != @codigo))
			begin
				if (@piso = '-')
				set @piso = null
				if (@dpto = '-')
				set @dpto = null
			
				UPDATE FAGD.Cliente

				set
				cliente_nroDocumento = @nroDocumento,
				cliente_nombre = @nombre,
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

				where cliente_codigo = @codigo;

				set @respuesta = 1;
			end
			else
			begin
				set @respuesta = 2;
			end
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

-----------------------------------------------------------------------------------------------------------------------------------------

/* Store procedure donde se recibe todos los datos de una habitación. Si el número de habitación ya existia en el hotel donde se quiere agregar, no se hara el
	INSERT y devolvera 2. Por algun error en el INSERT se devolvera 0. Caso contrario, es decir que todo se inserte correctamente devolvera 1.  */

create proc FAGD.GuardarNuevaHabitacion
@numero numeric(18),
@piso numeric(18),
@ubicacion nvarchar(255),
@tipoHab nvarchar(255),
@descripcion nvarchar(255),
@idHotel numeric(18),
@estado bit


as
begin
	declare @resultado numeric(18)
	declare @idTipoHab numeric(18)

	set @idTipoHab = (select habitacionTipo_codigo from FAGD.HabitacionTipo where habitacionTipo_descripcion = @tipoHab)
	begin tran nuHab
	begin try
		if (not exists(select habitacion_nro from FAGD.Habitacion where habitacion_nro = @numero and habitacion_codigoHotel = @idHotel))
			begin
				insert into FAGD.Habitacion(habitacion_codigoHotel, habitacion_nro, habitacion_tipoCodigo, habitacion_piso, habitacion_ubicacion, habitacion_descripcion, habitacion_estado)
				values (@idHotel, @numero, @idTipoHab, @piso, @ubicacion, @descripcion, @estado)
				set @resultado = 1;
			end
		else
			set @resultado = 2;
		select @resultado as resultado
		commit tran nuHab
	end try
	begin catch
		rollback tran nuHab
		set @resultado = 0
		select @resultado as resultado
	end catch
end
GO

-----------------------------------------------------------------------------------------------------------------------------------------------

/* Store procedure que modifica todos los datos de la habitación. Al igual que en el procedure anterior, verifica que no exista el número de habitación
	en dicho hotel. En caso de error o no cumplir con esto, devolvera 0 o 2 respectivamente. Si todo esta bien, se modificara el hotel y devolvera 1. */

create proc FAGD.ModificarHabitacion
@idHabitacion numeric(18),
@numero numeric(18),
@piso numeric(18),
@ubicacion nvarchar(255),
@tipoHab nvarchar(255), --Como el tipo no se puede modificar, este siempre sera el mismo.
@descripcion nvarchar(255),
@idHotel numeric(18),
@estado bit


as
begin
	declare @resultado numeric(18)
	declare @idTipoHab numeric(18)

	set @idTipoHab = (select habitacionTipo_codigo from FAGD.HabitacionTipo where habitacionTipo_descripcion = @tipoHab)
	begin tran nuHab
	begin try
		if (not exists(select habitacion_nro from FAGD.Habitacion where habitacion_nro = @numero and habitacion_codigoHotel = @idHotel and habitacion_codigo <> @idHabitacion))
			begin
				UPDATE FAGD.Habitacion

				set
				habitacion_nro = @numero,
				habitacion_piso = @piso,
				habitacion_ubicacion = @ubicacion,
				habitacion_descripcion = @descripcion,
				habitacion_estado = @estado,
				habitacion_tipoCodigo = @idTipoHab

				where habitacion_codigo = @idHabitacion;
				set @resultado = 1;
			end
		else set @resultado = 2;
		select @resultado as resultado
		commit tran nuHab
	end try
	begin catch
		rollback tran nuHab
		set @resultado = 0
		select @resultado as resultado
	end catch
end
GO
				
------------------------------------------------------------------------------------------------------------------------


----------------------------------- ABM ROL -----------------------------------------------------------------

/*'nuevoRol' recibe el nombre del rol a crear y su estado (activo/inactivo). Verifica que no exista otro rol con el nombre ingresado,
 * devolviendo 0 si ya existe. Si no es el caso, continúa a insertar los datos recibidos em la tabla Rol y devuelve 1 en caso de éxito
 * y 2 si hubo algún error
*/
CREATE PROC FAGD.nuevoRol @nombreRol nvarchar (255), @estado bit
AS
BEGIN
	DECLARE @resultado numeric(18)
	BEGIN TRAN rol
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
		COMMIT TRAN rol
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN rol
		SET @resultado = 2;
		SELECT @resultado AS resultado
	END CATCH 
END
GO

-------------------------------------------------------------------------------------------------------------------------

/* 'funcionalidadesDelRol' se ejecuta iterativamente (según la cantidad de funcionalidades que se ingresaron al crear el rol)
 * luego de haber insertado el rol en la tabla correspondiente. Este procedimiento recibe el nombre del rol al cual añadir una
 * funcionalidad e inserta ambos en la tabla RolXFuncionalidad, devolviendo 1 en caso de éxito y 0 en caso de error
*/
CREATE PROCEDURE FAGD.funcionalidadesDelRol @nombreRol nvarchar (255), @codigoFuncionalidad numeric (18)
AS 
BEGIN
	DECLARE @resultado numeric(18)
	BEGIN TRAN func
	BEGIN TRY
		INSERT INTO FAGD.RolXFuncionalidad (rol_codigo,funcionalidad_codigo)
		VALUES ((SELECT rol_codigo FROM FAGD.Rol WHERE @nombreRol = rol_nombre), @codigoFuncionalidad)
		SET @resultado=1;
		SELECT @resultado AS resultado
		COMMIT tran func
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN func
		SET @resultado = 0;
		SELECT @resultado AS resultado
	END CATCH
END
GO

--------------------------------------------------------------------------------------------------------------------------

/*'updatearRol' se ejecuta al momento de actualizar un rol, recibiendo tanto el nombre que este tenía antes de la actualización
 * como así también el que tendrá luego, además del estado que tendrá. Verifica que no haya un rol con el nuevo nombre o si el 
 * mismo se mantiene invariante. En esos casos, procede a hacer un update de la tabla Rol con los datos ingresados, devolviendo 1
 * en caso de éxito, 2 si ya existe un rol con ese nombre y 0 en caso de error 
 */

CREATE PROCEDURE FAGD.updatearRol @nombreViejo nvarchar (255), @nombreNuevo nvarchar(255), @estado bit
AS
BEGIN
	DECLARE @resultado numeric(1)
	BEGIN TRAN upd
	BEGIN TRY
		IF (NOT EXISTS(SELECT rol_nombre FROM FAGD.Rol WHERE rol_nombre = @nombreNuevo) OR @nombreNuevo = @nombreViejo)
			BEGIN
				UPDATE FAGD.Rol

					SET rol_nombre = @nombreNuevo,
						rol_estado = @estado
					WHERE rol_nombre = @nombreViejo;
					SET @resultado = 1;
			END
		ELSE
			BEGIN
				SET @resultado = 2;
			END
		SELECT @resultado AS resultado
		COMMIT TRAN upd
	END TRY 
	BEGIN CATCH
		ROLLBACK TRAN upd
		SET @resultado = 0;
		SELECT @resultado AS resultado
	END CATCH
END
GO

-------------------------------------------------------------------------------------------------------------------------

/*'limpiarFuncionalidades' se ejecuta al modificar un rol, después de haber realizado el update en la tabla. Lo que hace este 
 * procedimiento es borrar todas las filas que haya en la tabla RolXFuncionalidad para que luego sean insertadas las nuevas 
 * funcionalidades. Recibe el nombre del rol y procede a hacer un Delete de las filas que contengan a ese rol.
 */

CREATE PROCEDURE FAGD.limpiarFuncionalidades @nombreRol nvarchar (255)
AS
BEGIN 
DECLARE @resultado numeric(1)
	BEGIN TRAN limp
	BEGIN TRY
		DELETE 
			FROM FAGD.RolXFuncionalidad 
			WHERE rol_codigo = (SELECT rol_codigo FROM FAGD.Rol WHERE rol_nombre = @nombreRol)
		
		SET @resultado=1;
		SELECT @resultado AS resultado
		COMMIT tran limp
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN limp
		SET @resultado = 0;
		SELECT @resultado AS resultado
	END CATCH
END
GO

--------------------------------------------------------------------------------------------------------------------------------


---------------------------------------------------------- ABM USUARIO ---------------------------------------------------------
/*'guardarUsuario recibe los datos propios de cada usuario y un rol a desempeñar en determinado hotel. Verifica que no exista un usuario
 * con el mismo username y procede a hacer los inserts en las tablas Usuario y UsuarioXRolXHotel 
*/

CREATE PROCEDURE FAGD.guardarUsuario
@nombre nvarchar (255),
@apellido nvarchar (255),
@username nvarchar (255),
@password nvarchar (255),
@tipoDoc nvarchar (255),
@nroDoc numeric (18),
@direccion nvarchar (255),
@mail nvarchar (255),
@hotelCalle nvarchar (255),
@hotelNro numeric (18),
@rol nvarchar (255),
@telefono numeric (18),
@fechaNac datetime

AS 
BEGIN
	DECLARE @resultado numeric(1)
	DECLARE @fechaNacimiento datetime
	SET @fechaNacimiento = CONVERT(datetime, @fechaNac, 121)
	BEGIN TRAN usuario
	BEGIN TRY
		IF (@username NOT IN (SELECT usuario_username FROM FAGD.Usuario WHERE usuario_nombre = @username))
		BEGIN
			INSERT INTO FAGD.Usuario (usuario_username, usuario_password, usuario_nombre, usuario_apellido, usuario_direccion,
									  usuario_mail, usuario_telefono, usuario_fechaNacimiento, usuario_tipoDoc, usuario_nroDoc,
									  usuario_estado) 
			VALUES (@username, @password, @nombre, @apellido, @direccion, @mail, @telefono, @fechaNacimiento, @tipoDoc, @nroDoc, 1)
			
			INSERT INTO FAGD.UsuarioXRolXHotel (usuario_username, rol_codigo, hotel_codigo)
			VALUES (@username,
				   (SELECT rol_codigo FROM FAGD.Rol WHERE rol_nombre = @rol),
				   (SELECT hotel_codigo FROM FAGD.Hotel WHERE hotel_calle = @hotelCalle AND hotel_nroCalle = @hotelNro))
			SET @resultado = 1;
		END
		ELSE 
		BEGIN
			SET @resultado = 0;
		END
		SELECT @resultado AS resultado
		COMMIT tran usuario
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN usuario
		SET @resultado = 2;
		SELECT @resultado AS resultado
	END CATCH
END
GO

------------------------------------------------------------------------------------------------------------------------
/*'nuevoPuesto' inserta en la tabla UsuarioXRolXhotel el rol de un usuario en determinado hotel, recibiendo estos como parámetros.
 * Devuelve 1 en caso de éxito y 0 en caso contrario
 */
CREATE PROCEDURE FAGD.nuevoPuesto @username nvarchar(255), @hotelCalle nvarchar (255), @hotelNro numeric (18), @rol nvarchar (255)
AS 
BEGIN
	DECLARE @resultado numeric(1)
	BEGIN TRAN puesto
	BEGIN TRY
		INSERT INTO FAGD.UsuarioXRolXHotel (usuario_username, rol_codigo, hotel_codigo)
		VALUES (@username,
			   (SELECT rol_codigo FROM FAGD.Rol WHERE rol_nombre = @rol),
			   (SELECT hotel_codigo FROM FAGD.Hotel WHERE hotel_calle = @hotelCalle AND hotel_nroCalle = @hotelNro)
			   )
		SET @resultado = 1;
		SELECT @resultado AS resultado
		COMMIT tran puesto
	END TRY
	BEGIN CATCH 
		ROLLBACK TRAN puesto
		SET @resultado = 0;
		SELECT @resultado AS resultado
	END CATCH
END
GO

---------------------------------------------------------------------------------------------------------------------------
/*'borrarPuesto' elimina el rol de un usuario en cierto hotel, realizando los debidos Deletes en la tabla UsuarioXRolXHotel según
 * el usuario, el rol y el hotel recibidos. 
*/
CREATE PROCEDURE FAGD.borrarPuesto @username nvarchar(255), @hotelCalle nvarchar (255), @hotelNro numeric (18), @rol nvarchar (255)
AS 
BEGIN
	DECLARE @resultado numeric(1)
	BEGIN TRAN borrar
	BEGIN TRY
		DELETE FROM FAGD.UsuarioXRolXHotel
		WHERE usuario_username =  @username
			  AND hotel_codigo = (SELECT hotel_codigo FROM FAGD.Hotel WHERE hotel_calle = @hotelCalle AND hotel_nroCalle = @hotelNro)
			  AND rol_codigo = (SELECT rol_codigo FROM FAGD.Rol WHERE rol_nombre = @rol)
		SET @resultado = 1;
		SELECT @resultado AS resultado
		COMMIT tran borrar
	END TRY
	BEGIN CATCH 
		ROLLBACK TRAN borrar
		SET @resultado = 0;
		SELECT @resultado AS resultado
	END CATCH
END
GO

-----------------------------------------------------------------------------------------------------------------------------
/*'cambiarEstadoUsuario' se ejecuta desde el menú de modificación de usuario. Al presionar el botón, el procedimiento verifica el estado
 * actual del Usuario en la tabla Usuario, si es 1 (activo) lo cambia a 0 (inactivo) y viceversa. Devuelve 0 si inhabilitó al usuario, 
 * 1 si lo habilitó y 2 en caso de error
*/
CREATE PROCEDURE FAGD.cambiarEstadoUsuario @username nvarchar(255)
AS 
BEGIN
	DECLARE @resultado numeric(1)
	BEGIN TRAN estado
	BEGIN TRY
		IF ((SELECT usuario_estado FROM FAGD.Usuario WHERE usuario_username = @username) = 1)
		BEGIN
			UPDATE FAGD.Usuario
			SET usuario_estado = 0
			WHERE usuario_username = @username;
			SET @resultado = 0;
		END
		ELSE
		BEGIN
			UPDATE FAGD.Usuario
			SET usuario_estado = 1
			WHERE usuario_username = @username;
			SET @resultado = 1;
		END
		SELECT @resultado AS resultado
		COMMIT TRAN estado
	END TRY 
	BEGIN CATCH
		ROLLBACK TRAN estado
		SET @resultado = 2;
		SELECT @resultado AS resultado
	END CATCH
END
GO
-----------------------------------------------------------------------------------------------------------------------------

/*'updatearDatosUsuario' recibe los datos personales del usuario a modificar y realiza los updates pertinentes. No modifica ni su estado 
 * ni sus roles a cumplir.
*/
CREATE PROCEDURE FAGD.updatearDatosUsuario
@username nvarchar (255),
@nombre nvarchar (255),
@apellido nvarchar (255),
@tipoDoc nvarchar (255),
@nroDoc numeric (18),
@direccion nvarchar (255),
@mail nvarchar (255),
@telefono numeric (18),
@fechaNac datetime

AS 
BEGIN
	DECLARE @resultado numeric(1)
	DECLARE @fechaNacimiento datetime
	SET @fechaNacimiento = CONVERT(datetime, @fechaNac, 121)
	BEGIN TRAN upd
	BEGIN TRY

		UPDATE FAGD.Usuario
			
			SET usuario_nombre = @nombre,
				usuario_apellido = @apellido,
				usuario_tipoDoc= @tipoDoc,
				usuario_nroDoc= @nroDoc,
				usuario_direccion = @direccion,
				usuario_mail = @mail,
				usuario_telefono = @telefono,
				usuario_fechaNacimiento = @fechaNacimiento

			WHERE usuario_username = @username;
			SET @resultado = 1;
		SELECT @resultado AS resultado
		COMMIT tran usuario
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN upd
		SET @resultado = 0;
		SELECT @resultado AS resultado
	END CATCH
END
GO			
-----------------------------------------------------------------------------------------------------------------------------


-------------------------------------------------------------------ABM Login------------------------------------------------------------------------------

CREATE PROCEDURE FAGD.desactivarUsuario @username nvarchar (255)
AS
BEGIN
	DECLARE @resultado numeric(18)
	BEGIN TRAN actualizarEstado																										/*Procedimiento utilizado por el formulario loginContraseña para desactivar un usuario luego de pasados los 3 intentos de ingresar la contraseña
																																	y que esta no fuera valida. Se procede a updatear el estado del usuario recibido como parametro a 0 (inhabilitado)*/
		UPDATE FAGD.Usuario
		SET usuario_estado = 0
		WHERE usuario_username = @username;
		SET @resultado = 0;
	COMMIT TRAN ActualizarEstado
	SELECT @resultado AS resultado
END
GO

-------------------------------------------------------------------ABM Hotel-----------------------------------------------------------------------------

CREATE PROCEDURE FAGD.insertarHotel @estrellas numeric(18,0), @recargaEstrellas numeric(18,0), @pais nvarchar(255), @ciudad nvarchar(255), @calle nvarchar(255), @nroCalle numeric(18,0), @nombre nvarchar(255), @fechaDeCreacion datetime, @mail nvarchar(255), @telefono numeric(18,0)
AS
BEGIN
	DECLARE @resultado numeric(1)
	BEGIN TRAN insertarHotel
		INSERT INTO FAGD.Hotel 
		VALUES (@estrellas, @recargaEstrellas, @pais, @ciudad, @calle, @nroCalle, @nombre, @fechaDeCreacion, @mail, @telefono, 1) /*Con este procedimiento se realiza la carga de un hotel a la tabla FAGD.Hotel, segun los datos cargados en el formulario AltaHotel
																																	los cuales recibe como parametros.*/
	COMMIT TRAN insertarHotel
	SET @resultado = 0;
	SELECT @resultado AS resultado
END
GO

-------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE FAGD.insertarRegimenDeHotelCreado @nombreHotel nvarchar(255), @descripcionRegimen varchar (50)
AS
BEGIN
	DECLARE @resultado numeric(1)
	DECLARE @codigoHotel numeric (18,0)
	DECLARE @codigoRegimen numeric(18)
	SET @codigoHotel = (SELECT hotel_codigo FROM FAGD.Hotel WHERE hotel_nombre = @nombreHotel)
	SET @codigoRegimen = (SELECT regimen_codigo FROM FAGD.Regimen WHERE regimen_descripcion = @descripcionRegimen)				/*Este Stored Procedure es utilizado en el abmHotel, en los fomrularios de alta y modificacion de un hotel, con el fin de ir insertando
																																de a uno por vez los regimenes seleccionados para un hotel. Recibe un hotel y un regimen, y lo inserta en la tabla FAGD.HotelXRegimen.*/
	BEGIN TRAN insertarRegimenDeHotelCreado
		INSERT INTO FAGD.HotelXRegimen
		VALUES (@codigoHotel, @codigoRegimen)
	COMMIT TRAN insertarRegimenDeHotelCreado
	SET @resultado = 0;
	SELECT @resultado AS resultado
END
GO

-------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE FAGD.insertarAdministradorNuevoHotel @usuario nvarchar(255), @codigoHotel numeric (18,0)						
AS
BEGIN
	DECLARE @resultado numeric(1)
	BEGIN TRAN insertarAdministradorNuevoHotel
		INSERT INTO FAGD.UsuarioXRolXHotel																							/*Este procedimiento es utilizado en el abm hotel, en el formulario SeleccionarAdministrador. Recibe un codigo de hotel y un nombre
																																	de usuario, con el fin de asignar el rol de administrador para dicho hotel, a dicho usuario, insertandolo en la tabla FAGD.UsuarioXRolXHotel.*/
		VALUES (@usuario, 1, @codigoHotel)
	COMMIT TRAN insertarAdministradorNuevoHotel
	SET @resultado = 0;
	SELECT @resultado AS resultado;
END
GO

-------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE FAGD.actualizarHotel @estrellas numeric(18,0), @recargaEstrellas numeric(18,0), @pais nvarchar(255), @ciudad nvarchar(255), @calle nvarchar(255), @nroCalle numeric(18,0), @nombre nvarchar(255), @fechaDeCreacion datetime, @mail nvarchar(255), @telefono numeric(18,0), @codigoHotel numeric (18,0)
AS
BEGIN
	DECLARE @resultado numeric(1)
	BEGIN TRAN actualizarHotel
		UPDATE FAGD.Hotel
		SET hotel_nombre = @nombre, hotel_cantEstrellas = @estrellas, hotel_pais = @pais, hotel_recarga_estrellas = @recargaEstrellas, hotel_ciudad = @ciudad, hotel_calle = @calle, hotel_nroCalle = @nroCalle, hotel_fechaDeCreacion = @fechaDeCreacion, hotel_mail = @mail, hotel_telefono = @telefono
		WHERE hotel_codigo = @codigoHotel

		DELETE
		FROM FAGD.HotelXRegimen
		WHERE hotel_codigo = @codigoHotel																							/*Este procedimiento es utilizado por el formulario ModificarHotel, y se lo utiliza con el fin de realizar los cambios para un hotel ya creado (recibidos como parametros),
																																	según lo seleccionado por el usuario en dicho formulario, para lo que se updatea la tabla FAGD.Hotel. Además, se borran todos los regimenes de la tabla FAGD.Regimen, 
																																	los cuales volverán a ser cargados luego con el procedimiento FAGD.InsertarRegimenDeHotelCreado segun lo que el usuario haya ingresado en el formulario.*/
		SET @resultado = 0;
	COMMIT TRAN ActualizarHotel
	SELECT @resultado AS resultado
END
GO

---------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE FAGD.darDeBajaHotel @fechaInicio datetime, @fechaFin datetime, @motivo nvarchar(255), @codigoHotel numeric (18,0)
AS
BEGIN
	DECLARE @resultado numeric(1)
	BEGIN TRAN darDeBajaHotel
		INSERT INTO FAGD.BajaHotel
		VALUES (@codigoHotel,@fechaInicio,@fechaFin,@motivo)																		/*Procedimiento utilizado por el formulario BajaHotel con el fin de dar de baja el hotel , para un rango de fechas, que recibe como parámetro al igual que el hotel. 
																																	Se inserta dicha informacion en la tabla FAGD.BajaHotel*/ 
	COMMIT TRAN darDeBajaHotel
SET @resultado = 0;
SELECT @resultado AS resultado;
END
GO

----------------------------------------------------------------------------------------------------------------

/* Store procedure que busca habitaciones disponibles para reservar según el hotel, los dias que se quedara, el tipo de régimen (este puede pedirse o no, por lo que
	si no se especifica se devolveran todas las habitaciones para todos los régimenes del hotel), y el tipo de habitación que se desea. Para esto, se buscaran las 
		habitaciones que no esten reservadas para ese intervalo, devolviendo la información de la habitación y su costo por noche. En el caso de que el hotel este 
			inhabilitado en ese intervalo elegido, no se devolvera ninguna habitación. */

create procedure FAGD.BuscarHabitacionesDisponibles
@codigoHotel numeric(18),
@desde datetime,
@hasta datetime,
@regimen nvarchar(50),
@tipoHab nvarchar(255)

as
begin
	declare @fechaInicio datetime, @fechaFin datetime, @codigoTipoHab numeric(18)
	set @fechaInicio = CONVERT(datetime,@desde,121)
	set @fechaFin = CONVERT(datetime,@hasta,121)
	set @codigoTipoHab = (select habitacionTipo_codigo from FAGD.HabitacionTipo where habitacionTipo_descripcion = @tipoHab)

	if (@regimen is null)
	begin
		select distinct Ha.habitacion_codigo Codigo, Ha.habitacion_ubicacion Ubicacion, (R.regimen_precioBase*T.habitacionTipo_cantHuespedes) + (Ho.hotel_cantEstrellas*Ho.hotel_recarga_estrellas) PrecioPorNoche, R.regimen_descripcion
		from FAGD.Habitacion Ha, FAGD.Hotel Ho, FAGD.HabitacionTipo T, FAGD.Regimen R
		where
		Ho.hotel_codigo = @codigoHotel and
		T.habitacionTipo_codigo = @codigoTipoHab and
		Ha.habitacion_codigoHotel = @codigoHotel and
		Ha.habitacion_tipoCodigo = @codigoTipoHab and
		not exists (select hotel_codigo from FAGD.BajaHotel where hotel_codigo = @codigoHotel and fecha_inicio <= @fechaInicio and fecha_fin >= @fechaInicio) and 
		not exists (select hotel_codigo from FAGD.BajaHotel where hotel_codigo = @codigoHotel and fecha_inicio <= @fechaFin and fecha_fin >= @fechaFin) and
		(FAGD.habitacionDisponible(@fechaInicio, @fechaFin, Ha.habitacion_codigo)) < 1
	end
	else
	begin
		declare @codigoRegimen numeric(18)
		set @codigoRegimen = (select regimen_codigo from FAGD.Regimen where regimen_descripcion = @regimen)

		select distinct Ha.habitacion_codigo Codigo, Ha.habitacion_ubicacion Ubicacion, (R.regimen_precioBase*T.habitacionTipo_cantHuespedes) + (Ho.hotel_cantEstrellas*Ho.hotel_recarga_estrellas) PrecioPorNoche, R.regimen_descripcion
		from FAGD.Habitacion Ha, FAGD.Hotel Ho, FAGD.HabitacionTipo T, FAGD.Regimen R
		where
		R.regimen_codigo = @codigoRegimen and
		Ho.hotel_codigo = @codigoHotel and
		T.habitacionTipo_codigo = @codigoTipoHab and
		Ha.habitacion_codigoHotel = @codigoHotel and
		Ha.habitacion_tipoCodigo = @codigoTipoHab and
		not exists (select hotel_codigo from FAGD.BajaHotel where hotel_codigo = @codigoHotel and fecha_inicio <= @fechaInicio and fecha_fin >= @fechaInicio) and 
		not exists (select hotel_codigo from FAGD.BajaHotel where hotel_codigo = @codigoHotel and fecha_inicio <= @fechaFin and fecha_fin >= @fechaFin) and
		(FAGD.habitacionDisponible(@fechaInicio, @fechaFin, Ha.habitacion_codigo)) < 1
	end
end
GO

---------------------------------------------------------------------------------------------------------

/* En este store procedure, si intentara generar una nueva reserva, con todos sus datos, devolviendo el número de la nueva reserva generada en caso correcto y 0
	en caso de un error en el INSERT. Se insetara siempre ya que tanto las habitaciones, como el estado del cliente y hotel fueron validados previamente. */

create procedure FAGD.InsertarNuevaReserva
@fecha_realizada datetime,
@fecha_inicio datetime,
@fecha_fin datetime,
@dias numeric(5),
@regimen nvarchar(50),
@cliente numeric(18),
@usuario nvarchar(255),
@hotel numeric(18),
@total numeric(18)

as
begin
	declare @fechaRealizada datetime, @fechaInicio datetime, @fechaFin datetime
	set @fechaRealizada = CONVERT(datetime, @fecha_realizada, 121)
	set @fechaInicio = CONVERT(datetime, @fecha_inicio, 121)
	set @fechaFin = CONVERT(datetime, @fecha_fin, 121)

	declare @codRegimen numeric(18), @codEstado numeric(18), @respuesta numeric(18)

	begin tran re
	begin try
		set @codRegimen = (select regimen_codigo from FAGD.Regimen where regimen_descripcion = @regimen)
		set @codEstado = (select estado_codigo from FAGD.Estado where estado_descripcion = 'RESERVA CORRECTA')

		insert into FAGD.Reserva(reserva_fechaRealizada, reserva_fechaInicio, reserva_fechaFin, reserva_cantNoches, reserva_estado, reserva_codigoRegimen, 
					reserva_clienteCodigo, reserva_nombreUsuario, reserva_codigoHotel, reserva_costoTotal)
		values(@fechaRealizada, @fechaInicio, @fechaFin, @dias, @codEstado, @codRegimen, @cliente, @usuario, @hotel, @total)

		set @respuesta = (select SCOPE_IDENTITY());
		select @respuesta as respuesta
	commit tran re
	end try

	begin catch
	rollback tran re
	set @respuesta = 0
	select @respuesta as respuesta
	end catch
end
GO

---------------------------------------------------------------------------------------------------------

/* Store procedure que guarda en una tabla intermedia las habitaciones que fueron pedidas para una reserva ya generada. En caso que todo este correcto,
	se devolvera el codigo de la reserva. Caso contrario retornara 0. */

create procedure FAGD.InsertarReservaXHabitacion
@reserva numeric(18),
@habitacion numeric(18)

as
begin
	declare @respuesta numeric(18)

	begin tran rh
	begin try
		insert into FAGD.ReservaXHabitacion(reserva_codigo, habitacion_codigo)
		values (@reserva, @habitacion)

		set @respuesta = (select reserva_codigo from FAGD.ReservaXHabitacion where reserva_codigo = @reserva and habitacion_codigo = @habitacion)
		select @respuesta as respuesta
	commit tran rh
	end try

	begin catch
	rollback tran rh
	set @respuesta = 0
	select @respuesta as respuesta
	end catch
end
GO

---------------------------------------------------------------------------------------------------------

/* Store procedure que me devuelve todas las habitaciones reservadas para una reserva especifica. */

create procedure FAGD.BuscarHabitacionesReservadas
@reserva numeric(18)

as
begin
	select Ha.habitacion_codigo, (R.regimen_precioBase*T.habitacionTipo_cantHuespedes) + (Ho.hotel_cantEstrellas*Ho.hotel_recarga_estrellas)
	from FAGD.Reserva Re join FAGD.Regimen R on (Re.reserva_codigoRegimen = R.regimen_codigo) join FAGD.Hotel Ho on (Re.reserva_codigoHotel = Ho.hotel_codigo) join
		 FAGD.ReservaXHabitacion RH on (Re.reserva_codigo = RH.reserva_codigo) join FAGD.Habitacion Ha on (RH.habitacion_codigo = Ha.habitacion_codigo) join
		 FAGD.HabitacionTipo T on (Ha.habitacion_tipoCodigo = T.habitacionTipo_codigo)
	where Re.reserva_codigo = @reserva
end
GO

---------------------------------------------------------------------------------------------------------

/* Store procedure donde se podran modificar todos los datos de una reserva menos el hotel y el cliente, retornando 1 en caso de que la modificación haya sido
	exitosa. Caso contrario retornara 0. */

create procedure FAGD.ModificarReserva
@reserva numeric(18),
@fecha_realizada datetime,
@fecha_inicio datetime,
@fecha_fin datetime,
@dias numeric(5),
@regimen nvarchar(50),
@usuario nvarchar(255),
@total numeric(18)

as
begin
	declare @fechaRealizada datetime, @fechaInicio datetime, @fechaFin datetime
	set @fechaRealizada = CONVERT(datetime, @fecha_realizada, 121)
	set @fechaInicio = CONVERT(datetime, @fecha_inicio, 121)
	set @fechaFin = CONVERT(datetime, @fecha_fin, 121)

	declare @codRegimen numeric(18), @codEstado numeric(18), @respuesta numeric(18)

	begin tran re
	begin try
		set @codRegimen = (select regimen_codigo from FAGD.Regimen where regimen_descripcion = @regimen)
		set @codEstado = (select estado_codigo from FAGD.Estado where estado_descripcion = 'RESERVA MODIFICADA')

		update FAGD.Reserva set
		reserva_fechaRealizada = @fechaRealizada, 
		reserva_fechaInicio = @fechaInicio, 
		reserva_fechaFin = @fechaFin, 
		reserva_cantNoches = @dias, 
		reserva_estado = @codEstado, 
		reserva_codigoRegimen = @codRegimen, 
		reserva_nombreUsuario = @usuario, 
		reserva_costoTotal = @total
		where
		reserva_codigo = @reserva

		set @respuesta = 1;
		select @respuesta as respuesta
	commit tran re
	end try

	begin catch
	rollback tran re
	set @respuesta = 0
	select @respuesta as respuesta
	end catch
end
GO

---------------------------------------------------------------------------------------------------------

/* Store procedure para cancelar una reserva. Para esto, modifica el estado de la reserva dependiendo quien lo haya pedido (Empleado o Guest) y se insertara el
	código de la reserva en la tabla ReservaCancelada. En caso de que esto ocurra devolvera 1. Caso contario 0. */

create procedure FAGD.CancelarReserva
@reserva numeric(18),
@motivo nvarchar(255),
@fechaI datetime,
@usuario nvarchar(255),
@estado numeric(18)

as
begin
	declare @fecha datetime
	set @fecha = CONVERT(datetime,@fechaI,121)

	declare @respuesta numeric(18)
	begin tran cr
	begin try
		update FAGD.Reserva 
		set reserva_estado = @estado
		where reserva_codigo = @reserva;
	
		insert into FAGD.ReservaCancelada(reservaCancelada_nombreUsuario, reservaCancelada_codigoReserva,reservaCancelada_motivo, reservaCancelada_fechaCancelacion)
		values(@usuario,@reserva,@motivo,@fecha)
	
		set @respuesta =1
		select @respuesta as respuesta
	commit tran cr
	end try
	begin catch
		rollback tran cr
		set @respuesta=0
		select @respuesta as respuesta
	end catch
end
GO