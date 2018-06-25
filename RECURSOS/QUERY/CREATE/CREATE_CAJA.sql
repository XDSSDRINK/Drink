CREATE TABLE Caja(
ID INT IDENTITY(1,1) PRIMARY KEY,
Billete MONEY,
CantidadBilletes INT,
Moneda MONEY,
CantidadMonedas INT,
NumeroBaucher FLOAT,
ValorBaucher MONEY,
TipoOperacion VARCHAR(11),
Usuario INT,
FechaRegistro DATETIME
)