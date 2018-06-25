CREATE PROCEDURE SP_CONSULTAR_PRODUCTO_PARA_VENTA
@PRODUCTO AS VARCHAR(200)
AS
IF(@PRODUCTO is null)

SELECT  p.Item ITEM,c.CodigoBarras CODIGO_BARRAS,p.Nombre NOMBRE,P.Referencia REFERENCIA,P.IVA,
SUM(c.Cantidad) CANTIDAD,AVG(c.Costo) COSTO,AVG(c.Margen) MARGEN,
((AVG(c.Costo) /(1-(AVG(c.Margen) / 100)))) VALOR_UN
FROM Kardex  k
LEFT JOIN Compras c ON k.IdCompra = c.ID
LEFT JOIN Venta v ON k.IdVenta = v.ID
LEFT JOIN Producto p ON c.CodigoProducto = p.ID
GROUP BY p.Item,c.CodigoBarras,p.Nombre,P.Referencia,P.IVA
ELSE
SELECT  p.Item ITEM,c.CodigoBarras CODIGO_BARRAS,p.Nombre NOMBRE,P.Referencia REFERENCIA,P.IVA,
SUM(c.Cantidad) CANTIDAD,AVG(c.Costo) COSTO,AVG(c.Margen) MARGEN,
((AVG(c.Costo) /(1-(AVG(c.Margen) / 100)))) VALOR_UN
FROM Kardex  k
LEFT JOIN Compras c ON k.IdCompra = c.ID
LEFT JOIN Venta v ON k.IdVenta = v.ID
LEFT JOIN Producto p ON c.CodigoProducto = p.ID
WHERE p.Item = @PRODUCTO OR c.CodigoBarras = @PRODUCTO
GROUP BY p.Item,c.CodigoBarras,p.Nombre,P.Referencia,P.IVA


