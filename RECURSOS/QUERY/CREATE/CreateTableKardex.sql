
CREATE TABLE Kardex (
ID int IDENTITY(1,1) PRIMARY KEY,
IdProducto int,
IdCompra int,
Entrada float,
IdVenta int,
Salida float,
FechaRegistro date,
Bodega int,
foreign key(IdCompra) references compras(ID),
foreign key(IdVenta) references Venta(ID),
foreign key(IdProducto) references Producto(ID),
foreign key(Bodega) references Bodega(ID)
)