INSERT 
	INTO FAGD.Hotel ([hotel_ciudad], [hotel_calle], [hotel_nroCalle], [hotel_cantEstrellas], [hotel_recarga_estrellas])
	SELECT DISTINCT [Hotel_Ciudad],[Hotel_Calle],[Hotel_Nro_Calle],[Hotel_CantEstrella],[Hotel_Recarga_Estrella]
	FROM [GD1C2018].[gd_esquema].[Maestra]

INSERT 
	INTO FAGD.Regimen ([regimen_descripcion],[regimen_precioBase])
		SELECT DISTINCT ([Regimen_Descripcion],[Regimen_Precio])
		FROM [GD1C2018].[gd_esquema].[Maestra]

INSERT
	INTO FAGD.Consumible ([consumible_codigo],[consumible_descripcion],[consumible_precio])
		SELECT DISTINCT [Consumible_Codigo],[Consumible_Descripcion],[Consumible_Precio]
		FROM [GD1C2018].[gd_esquema].[Maestra]

INSERT 
	INTO FAGD.Cliente ([cliente_nroDocumento],[cliente_apellido],[cliente_nombre],[cliente_fechaNac],[cliente_mail]
	---aca falta cliente_domCalle---
	,[cliente_nroCalle],[cliente_piso],[cliente_dpto],[cliente_nacionalidad]
		SELECT DISTINCT [Cliente_Pasaporte_Nro],[Cliente_Apellido],[Cliente_Nombre],[Cliente_Fecha_Nac],[Cliente_Mail],
		[Cliente_Dom_Calle],[Cliente_Nro_Calle],[Cliente_Piso],[Cliente_Depto],[Cliente_Nacionalidad]
		FROM [GD1C2018].[gd_esquema].[Maestra]