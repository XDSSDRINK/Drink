CREATE PROCEDURE SP_InformeVentas
@Buscar AS VARCHAR(100),
@NombreDoc AS VARCHAR(100),
@ConsecutivoDoc AS VARCHAR(100),
@FechaIni AS VARCHAR(100),
@FechaFin AS VARCHAR(100)
AS

SELECT v.FechaRegistro,v.HoraRegistro,u.Usuario,v.NombreDocumento,v.ConsecutivoDocumento,
p.Item,v.CodigoBarras,p.Nombre,p.Referencia,v.Cantidad,((v.Costo /(1-(v.Margen / 100))) * v.Cantidad) ValorVenta,
(((v.Costo /(1-(v.Margen / 100))) * (v.Descuento/100)) * v.Cantidad) ValorDescuento,
((v.Costo /(1-(v.Margen / 100))) * v.Cantidad) - (((v.Costo /(1-(v.Margen / 100))) * (v.Descuento/100)) * v.Cantidad) TotalVenta,
v.Costo,v.Margen,v.Descuento,p.IVA,v.MedioPago
FROM Venta v
INNER JOIN Producto p ON v.CodigoProducto = p.ID
INNER JOIN Cliente c ON v.CodigoCliente = c.Codigo
INNER JOIN Usuario u ON v.CodigoUsuario = u.Codigo
WHERE (p.Item = @Buscar OR u.Usuario = @Buscar) AND  
(v.NombreDocumento = @NombreDoc OR v.ConsecutivoDocumento = @ConsecutivoDoc) 
AND v.FechaRegistro BETWEEN @FechaIni AND @FechaFin
ORDER BY v.FechaRegistro ASC

