/*25 de Junio de 2018*/
CREATE TABLE Meseros(
	Codigo bigint IDENTITY(1,1) NOT NULL,
	DNI bigint NULL,
	TipoIdentificacion varchar(30) NULL,
	Nombres varchar(60) NULL,
	Apellidos varchar(70) NULL,
	Departamento varchar(10) NULL,
	Municipio varchar(10) NULL,
	BarrioVereda varchar(60) NULL,
	Direccion varchar(100) NULL,
	TelefonoFijo varchar(8) NULL,
	Email varchar(100) NULL,
	Celular varchar(11) NULL
);
GO
ALTER TABLE Meseros ADD CONSTRAINT pk_meseros PRIMARY KEY (codigo);
ALTER TABLE Meseros ADD UNIQUE (DNI);
GO

CREATE TABLE Mesas(
	nomBoton VARCHAR(20) NOT NULL,
	nomMesa VARCHAR(20) NOT NULL,
	detalle VARCHAR(200) NOT NULL,
	coordenadax VARCHAR(30) NOT NULL,
	coordenaday VARCHAR(30) NOT NULL,
	largo VARCHAR(30) NOT NULL,
	ancho VARCHAR(30) NOT NULL
);
GO
ALTER TABLE Mesas ADD CONSTRAINT pk_mesas PRIMARY KEY (nomBoton);
GO


CREATE TABLE mesasMeseros(
	nomBoton VARCHAR(20) NOT NULL,
	Codigo bigint NOT NULL,
	fecha smalldatetime NOT NULL
);

ALTER TABLE mesasMeseros ADD CONSTRAINT fkMesa FOREIGN KEY (nomBoton) REFERENCES mesas(nomBoton);
ALTER TABLE mesasMeseros ADD CONSTRAINT fkmeseros FOREIGN KEY (codigo) REFERENCES Meseros(codigo);
ALTER TABLE mesasMeseros ADD CONSTRAINT dfFecha DEFAULT (getdate()) FOR fecha;
GO
ALTER TABLE mesasMeseros DROP CONSTRAINT fkMesa;
GO

/*
Se crea formulario para meseros y su rspectivo detalle
se crea formulario para las mesas y su respectivo detalle
se crea formulario para las ventas de las mesas

*/


