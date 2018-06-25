Create table Rol_Permiso
(
Rol int,
Permiso int,
Modulo int
Foreign key(Rol) references Rol(ID),
Foreign key(Permiso) references Permiso(ID),
Foreign key(Modulo) references Modulo(ID)
)

