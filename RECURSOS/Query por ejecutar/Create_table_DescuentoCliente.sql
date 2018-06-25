
CREATE TABLE DescuentoCliente(
ID INT IDENTITY(1,1) PRIMARY KEY,
Cliente INT,
Producto INT,
CodigoBarras varchar(100),
Descuento FLOAT,
FOREIGN KEY(Cliente) REFERENCES Cliente(Codigo),
FOREIGN KEY(Producto) REFERENCES Producto(ID)
)