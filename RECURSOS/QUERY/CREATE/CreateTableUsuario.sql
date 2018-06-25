
CREATE TABLE Usuario(
Codigo int IDENTITY(1,1) PRIMARY KEY,
Persona int,
Usuario varchar(15),
Contraseña varchar(300),
Estado varchar(10),
Rol int,
foreign key(Persona) references Persona(Codigo),
foreign key(Rol) references Rol(ID)
)