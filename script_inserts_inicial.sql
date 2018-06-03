INSERT INTO FAGD.Hotel ([hotel_ciudad], [hotel_calle], [hotel_nroCalle], [hotel_cantEstrellas], [hotel_recarga_estrellas])
	SELECT DISTINCT [Hotel_Ciudad],[Hotel_Calle],[Hotel_Nro_Calle],[Hotel_CantEstrella],[Hotel_Recarga_Estrella]
	FROM [GD1C2018].[gd_esquema].[Maestra]

INSERT INTO FAGD.Regimen ([regimen_descripcion],[regimen_precioBase])
		SELECT DISTINCT [Regimen_Descripcion],[Regimen_Precio]
		FROM [GD1C2018].[gd_esquema].[Maestra]

INSERT INTO FAGD.Consumible ([consumible_descripcion],[consumible_precio])
		SELECT DISTINCT [Consumible_Descripcion],[Consumible_Precio]
		FROM [GD1C2018].[gd_esquema].[Maestra]

INSERT INTO FAGD.Cliente ([cliente_nroDocumento],[cliente_apellido],[cliente_nombre],[cliente_fechaNac],[cliente_mail],[cliente_calle],
		[cliente_nroCalle],[cliente_piso],[cliente_dpto], [cliente_nacionalidad], [cliente_tipoDocumento], [cliente_telefono], [cliente_estado], [cliente_localidad])
		SELECT DISTINCT [Cliente_Pasaporte_Nro],[Cliente_Apellido],[Cliente_Nombre],[Cliente_Fecha_Nac],[Cliente_Mail],[Cliente_Dom_Calle],
		[Cliente_Nro_Calle],[Cliente_Piso],[Cliente_Depto],[Cliente_Nacionalidad],'Pasaporte', 000, 1, NULL
		FROM [GD1C2018].[gd_esquema].[Maestra]


INSERT INTO FAGD.Reserva ([reserva_codigo],[reserva_fechaInicio],[reserva_cantNoches],[reserva_codigoRegimen],[reserva_clienteNroDocumento],[reserva_codigoHotel],[reserva_codigoHabitacion])
		--[reserva_nombreUsuario],--
		
		/*SELECT DISTINCT [Reserva_Codigo],[Reserva_Fecha_Inicio],[Reserva_Cant_Noches],
		[SELECT regimen_codigo FROM FAGD.Regimen, gd_esquema.Maestra WHERE regimen_descripcion = Regimen_Descripcion],
		[Cliente_Pasaporte_Nro],
		[SELECT hotel_codigo FROM FAGD.Hotel, gd_esquema.Maestra WHERE hotel_calle = Hotel_Calle and hotel_nroCalle = Hotel_Nro_Calle],
		[SELECT habitacion_codigo FROM FAGD.Habitacion, gd_esquema.Maestra WHERE habitacion_nro = Habitacion_Numero and habitacion_codigoHotel = reserva_codigoHotel]
		FROM [GD1C2018].[gd_esquema].[Maestra]*/
		SELECT DISTINCT M.Reserva_codigo, M.Reserva_Fecha_Inicio, M.Reserva_Cant_Noches, R.regimen_codigo, M.Cliente_Pasaporte_Nro, H.hotel_codigo, A.habitacion_codigo
		FROM FAGD.Regimen R, FAGD.Hotel H, FAGD.Habitacion A, gd_esquema.Maestra M
		WHERE M.Regimen_Descripcion = R.regimen_descripcion and M.Hotel_Calle = H.hotel_calle and M.Hotel_Nro_Calle = H.hotel_nroCalle and M.Habitacion_Numero = A.habitacion_nro
		ORDER BY M.Reserva_Codigo

INSERT INTO FAGD.HabitacionTipo(habitacionTipo_codigo, habitacionTipo_descripcion, habitacionTipo_porcentual)
		
		SELECT DISTINCT Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual
		FROM gd_esquema.Maestra 


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