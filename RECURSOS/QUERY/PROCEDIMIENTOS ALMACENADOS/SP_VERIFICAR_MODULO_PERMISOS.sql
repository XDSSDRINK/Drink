
CREATE PROCEDURE SP_VERIFICAR_MODULO_PERMISOS
@Usuario varchar(15),
@Modulo varchar(100)
AS
DECLARE 
@Rol INT,
@Modulos INT
SET @Rol = (SELECT Rol FROM Usuario WHERE Usuario = @Usuario)
IF (@Modulo = 'Ventas')
	SET @Modulo = 'VENTAS'
ELSE
	IF (@Modulo = 'Compras') 
		SET @Modulo = 'COMPRAS'
    ELSE
		IF (@Modulo = 'Clientes') 
		SET @Modulo = 'CLIENTES'
		ELSE
			IF (@Modulo = 'Productos') 
			SET @Modulo = 'PRODUCTO'
			ELSE
				IF (@Modulo = 'Proveedores') 
				SET @Modulo = 'PROVEEDOR'
				ELSE
					IF (@Modulo = 'Producto') 
					SET @Modulo = 'P_PRODUCTO'
					ELSE
						IF (@Modulo = 'Factura') 
						SET @Modulo = 'P_FACTURA'
						ELSE
							IF (@Modulo = 'Documentos') 
							SET @Modulo = 'P_DOCUMENTOS'
							ELSE
								IF (@Modulo = 'Venta') 
								SET @Modulo = 'P_VENTA'
								ELSE
									IF (@Modulo = 'Rol y Permisos') 
									SET @Modulo = 'P_ROL_Y_PERMISOS'
									ELSE
										IF (@Modulo = 'Personal') 
										SET @Modulo = 'PERSONAL'
										ELSE
											IF (@Modulo = 'Compañia') 
											SET @Modulo = 'COMPAÑIA'
											ELSE
												IF (@Modulo = 'Ganancias y perdidas') 
												SET @Modulo = 'R_GANANCIAS_Y_PERDIDAS'
												ELSE
													IF (@Modulo = 'R Ventas') 
													SET @Modulo = 'R_VENTAS'
													ELSE
														IF (@Modulo = 'R Compras') 
														SET @Modulo = 'R_COMPRAS'
														ELSE
															IF (@Modulo = 'Inventario') 
															SET @Modulo = 'R_INVENTARIO'

SET @Modulos = (SELECT ID FROM Modulo WHERE Modulo = @Modulo)
SELECT p.Nombre FROM Rol_Permiso rp INNER JOIN Permiso p ON rp.Permiso = p.ID WHERE rp.Rol = @Rol AND rp.Modulo = @Modulos

