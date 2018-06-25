--Adicionar usuario creacion, usuario modificacion en tabla producto.

ALTER TABLE Producto
ADD  UsuarioCrea INT
GO
ALTER TABLE Producto
ADD  UsuarioModifica INT NULL
GO
ALTER TABLE Producto
ADD FOREIGN KEY(UsuarioCrea) REFERENCES Usuario(Codigo)
GO
ALTER TABLE Producto
ADD FOREIGN KEY(UsuarioModifica) REFERENCES Usuario(Codigo)



