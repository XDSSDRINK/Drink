CREATE PROC SP_EliminarRol
@CodigoRol as int
AS
DELETE FROM Rol_Permiso WHERE Rol = @CodigoRol
DELETE FROM Rol WHERE ID = @CodigoRol
