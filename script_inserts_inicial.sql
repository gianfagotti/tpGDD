
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

INSERT INTO FAGD.Usuario (usuario_username, usuario_nombre, usuario_apellido, usuario_direccion, usuario_mail, usuario_telefono, usuario_fechaNacimiento, usuario_estado)
		values ('IRAA','Ivan','Arnaudo','Calle Falsa 123','ivan.arnaudo@gmail.com','11111111','02/09/96',1)
GO

INSERT INTO FAGD.UsuarioXRol(usuario_username,rol_codigo)
		values('IRAA',1)
GO

INSERT INTO FAGD.UsuarioXHotel(usuario_username,hotel_codigo)
		values('IRAA',1),('IRAA',2),('IRAA',3),('IRAA',4),('IRAA',5),('IRAA',6)
GO
