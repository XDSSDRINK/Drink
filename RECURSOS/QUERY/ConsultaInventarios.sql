SELECT cp.CodigoProducto,pro.Item,pro.Nombre,pro.Referencia,SUM(cp.Cantidad) Cantidad_Comprada,
SUM(CASE WHEN v.Cantidad IS NULL THEN  0 END) Cantidad_Vendida,
(SUM(cp.Cantidad) - SUM((CASE WHEN v.Cantidad IS NULL THEN  0 END))) CANTIDAD_EXISTENTE,
cp.FechaVencimiento,pro.Stock StockMinimo,pro.Descripcion,pro.IVA,M.Nombre Marca,Pre.Nombre Presentacion,
cat.Nombre Categoria,unm.Nombre UnidadMedida,pro.Medida,estd.Estado
 FROM Kardex k
INNER JOIN Compras cp ON k.IdCompra = cp.ID
LEFT JOIN Venta v ON k.IdVenta = v.ID
INNER JOIN Producto pro ON pro.ID = cp.CodigoProducto
INNER JOIN Marca M ON pro.Marca = m.ID
INNER JOIN Presentacion Pre ON pro.Presentacion = Pre.ID
INNER JOIN Categoria cat ON pro.Categoria = cat.ID
INNER JOIN EstadoProducto estd ON pro.Estado = estd.IdEstado
INNER JOIN UnidadMedida unm ON pro.UnidadMedida = unm.ID
GROUP BY cp.CodigoProducto,v.CodigoProducto,pro.Item,pro.Nombre,
cp.FechaVencimiento,pro.Stock,pro.Referencia,pro.Descripcion,pro.IVA,M.Nombre ,Pre.Nombre ,
cat.Nombre ,unm.Nombre ,pro.Medida,estd.Estado




