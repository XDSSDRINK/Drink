USE [SBX]
GO
/****** Object:  StoredProcedure [dbo].[SP_CARGAR_PRODUCTO_VENTA]    Script Date: 13/06/2018 14:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_CARGAR_PRODUCTO_VENTA]
@Item_Producto AS VARCHAR(20)
AS

DECLARE 
@ID AS INT
SET @ID = (SELECT ID FROM Producto WHERE Item = @Item_Producto)

SELECT c.CodigoProducto PRODUCTO,p.Item,c.CodigoBarras COD_BARRAS,p.Nombre,p.Referencia,AVG(c.Costo) / (1 -(AVG(c.Margen)/100)) PRECIO_VENTA,c.IVA FROM Compras C
INNER JOIN Producto p ON C.CodigoProducto = P.ID
WHERE c.FechaRegistro = (SELECT MAX(FechaRegistro) FROM Compras  WHERE CodigoProducto = @ID) AND CodigoProducto = @ID
GROUP BY CodigoProducto,p.Item,CodigoBarras,p.Nombre,p.Referencia,c.IVA

