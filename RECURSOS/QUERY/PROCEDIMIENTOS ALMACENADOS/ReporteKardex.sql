USE [SBX]
GO
/****** Object:  StoredProcedure [dbo].[ReporteKardex]    Script Date: 7/06/2018 8:43:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Juan sebastian santa
-- Create date: 04/jun/2018
-- Description:	Encargado de generar el reporte Kardex
-- =============================================
ALTER PROCEDURE [dbo].[ReporteKardex] 
	-- Add the parameters for the stored procedure here
	@item AS VARCHAR(100)

AS
BEGIN

DECLARE
@valorRegistro INT
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	--SET @item=41;
	
	SELECT K.ID, k.FechaRegistro AS Fecha_Registro,
	CASE WHEN K.Idcompra  IS NULL THEN 'SALIDA' ELSE 'ENTRADA' END AS Accion ,
	p.Item AS Item,
	CONCAT(CASE WHEN K.Idcompra  IS NULL THEN 'SALIDA' ELSE 'ENTRADA' END,': ','Factura ',
	(CASE WHEN K.Idcompra  IS NULL THEN K.IdVenta ELSE K.IdCompra END)) AS Detalle,
	C.costo  AS costo,
	CASE WHEN K.Idcompra  IS NULL THEN '0' ELSE C.Cantidad END AS ENTRADA,
	0 AS SALIDA,
	P.Stock AS EXISTENCIA
	FROM Kardex k 
	INNER JOIN Compras C ON K.IdCompra = C.ID 
	INNER JOIN Producto P on C.CodigoProducto= P.ID
	WHERE P.Item LIKE '%'+@item+'%'
	UNION
	SELECT K.ID,k.FechaRegistro AS Fecha_Registro,
	CASE WHEN K.Idcompra  IS NULL THEN 'SALIDA' ELSE 'ENTRADA' END AS Accion,
	p.Item AS Item,
	CONCAT(CASE WHEN K.Idcompra  IS NULL THEN 'SALIDA' ELSE 'ENTRADA' END,': ','Factura ',
	(CASE WHEN K.Idcompra  IS NULL THEN K.IdVenta ELSE K.IdCompra END)) AS Detalle,
	V.costo  AS costo,
	0 AS ENTRADA,
	CASE WHEN K.Idcompra  IS NULL THEN V.Cantidad ELSE '0' END AS SALIDA,
	P.Stock AS EXISTENCIA
	FROM Kardex k 
	INNER JOIN Venta V ON K.IdVenta=V.ID
	INNER JOIN Producto P ON V.CodigoProducto=P.ID
	WHERE P.Item LIKE '%'+@item+'%'
	ORDER BY p.Item DESC
END

