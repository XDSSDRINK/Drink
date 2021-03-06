USE [SBX]
GO
/****** Object:  StoredProcedure [dbo].[SP_CARGAR_PRODUCTO_VENTA]    Script Date: 15/06/2018 9:47:05 ******/
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

SELECT c.CodigoProducto PRODUCTO,p.Item,c.CodigoBarras COD_BARRAS,p.Nombre,p.Referencia,
AVG(c.Costo) / (1 -(AVG(c.Margen)/100)) PRECIO_VENTA,c.IVA,AVG(c.Costo) Costo,AVG(c.Margen) Margen
FROM Compras C
INNER JOIN Producto p ON C.CodigoProducto = P.ID
WHERE c.FechaRegistro = (SELECT MAX(FechaRegistro) FROM Compras  WHERE CodigoProducto = @ID) AND CodigoProducto = @ID
GROUP BY CodigoProducto,p.Item,CodigoBarras,p.Nombre,p.Referencia,c.IVA

