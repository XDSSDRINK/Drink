CREATE TABLE Persona(
Codigo int IDENTITY(1,1) PRIMARY KEY,
DNI bigint,
TipoIdentificacion  varchar(30),
Nombres  varchar(60),
Apellidos varchar(70),
Departamento varchar(10),
Municipio varchar(10),
BarrioVereda varchar(60),
Direccion varchar(100),
TelefonoFijo varchar(8),
Email varchar(100),
Celular varchar(11),
foreign key(Departamento) references Departamento(Codigo),
foreign key(Municipio) references Municipio(Codigo)
)