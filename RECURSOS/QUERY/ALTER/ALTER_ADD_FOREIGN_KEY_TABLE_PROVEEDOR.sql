--Adicionar usuario creacion, usuario modificacion en tabla PROVEEDOR.

ALTER TABLE Proveedor
ADD  UsuarioCrea INT
GO
ALTER TABLE Proveedor
ADD  UsuarioModifica INT NULL
GO
ALTER TABLE Proveedor
ADD FOREIGN KEY(UsuarioCrea) REFERENCES Usuario(Codigo)
GO
ALTER TABLE Proveedor
ADD FOREIGN KEY(UsuarioModifica) REFERENCES Usuario(Codigo)