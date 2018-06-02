INSERT INTO FAGD.Hotel ([hotel_ciudad], [hotel_calle], [hotel_nroCalle], [hotel_cantEstrellas], [hotel_recarga_estrellas])
	SELECT DISTINCT [Hotel_Ciudad],[Hotel_Calle],[Hotel_Nro_Calle],[Hotel_CantEstrella],[Hotel_Recarga_Estrella]
	FROM [GD1C2018].[gd_esquema].[Maestra]

INSERT INTO FAGD.Regimen ([regimen_descripcion],[regimen_precioBase])
		SELECT DISTINCT ([Regimen_Descripcion],[Regimen_Precio])
		FROM [GD1C2018].[gd_esquema].[Maestra]

INSERT INTO FAGD.Consumible ([consumible_codigo],[consumible_descripcion],[consumible_precio])
		SELECT DISTINCT [Consumible_Codigo],[Consumible_Descripcion],[Consumible_Precio]
		FROM [GD1C2018].[gd_esquema].[Maestra]

INSERT INTO FAGD.Cliente ([cliente_nroDocumento],[cliente_apellido],[cliente_nombre],[cliente_fechaNac],[cliente_mail],[cliente_calle],
		[cliente_nroCalle],[cliente_piso],[cliente_dpto],[cliente_nacionalidad])
		SELECT DISTINCT [Cliente_Pasaporte_Nro],[Cliente_Apellido],[Cliente_Nombre],[Cliente_Fecha_Nac],[Cliente_Mail],[Cliente_Dom_Calle],
		[Cliente_Nro_Calle],[Cliente_Piso],[Cliente_Depto],[Cliente_Nacionalidad]
		FROM [GD1C2018].[gd_esquema].[Maestra]


INSERT INTO FAGD.Reserva ([reserva_codigo],[reserva_fechaInicio],[reserva_cantNoches],[reserva_codigoRegimen],[reserva_clienteNroDocumento],[reserva_codigoHotel],[reserva_nroHabitacion])
		--[reserva_nombreUsuario],--
		
		SELECT DISTINCT ([Reserva_Codigo],[Reserva_Fecha_Inicio],[Reserva_Cant_Noches],
		[(SELECT regimen_codigo FROM FAGD.Regimen, gd_esquema.Maestra WHERE regimen_descripcion = Regimen_Descripcion)],
		[Cliente_Pasaporte_Nro],
		[(SELECT hotel_codigo FROM FAGD.Hotel, gd_esquema.Maestra WHERE hotel_calle = Hotel_Calle and hotel_nroCalle = Hotel_Nro_Calle)],
		--[(SELECT habitacion_codigo FROM FAGD.Habitacion, gd_esquema.Maestra WHERE NO ME DA EL TIEMPO PENSAR ESTE SELECT)]


		FROM [GD1C2018].[gd_esquema].[Maestra]
GO
-------------------------------- ROLES Y FUNCIONALIDADES INICIALES --------------------------------- 
INSERT INTO FAGD.Rol (rol_codigo,rol_nombre,rol_estado)	
		values (1,'administrador',1),(2,'recepcionista',1),(3,'cliente',1)
GO

INSERT INTO FAGD.Funcionalidad(funcionalidad_codigo,funcionalidad_cliente)
		values (1,'ABM_Reservas'),(2,'ABM_Estadias'),(3,'ABM_Clientes'),(4,'ABM_Consumibles'),(5,'ABM_Roles'),(6,'ABM_Hoteles'),
		       (7,'ABM_Habitaciones'),(8,'ABM_Usuarios'),(9,'ABM_Regimenes'),(10,'Estadisticas')
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