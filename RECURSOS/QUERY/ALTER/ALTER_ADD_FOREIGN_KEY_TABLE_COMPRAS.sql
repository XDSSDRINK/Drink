--Adicionar usuario creacion, usuario modificacion en tabla Compras.

ALTER TABLE Compras
ADD  UsuarioCrea INT
GO
ALTER TABLE Compras
ADD  UsuarioModifica INT NULL
GO
ALTER TABLE Compras
ADD FOREIGN KEY(UsuarioCrea) REFERENCES Usuario(Codigo)
GO
ALTER TABLE Compras
ADD FOREIGN KEY(UsuarioModifica) REFERENCES Usuario(Codigo)