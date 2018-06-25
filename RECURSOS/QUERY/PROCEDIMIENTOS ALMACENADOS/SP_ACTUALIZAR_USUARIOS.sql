
CREATE PROC SP_ACTUALIZAR_USUARIOS
@CodigoUsuario INT,
@Persona AS INT,
@Usuario AS VARCHAR(15),
@Contrasena AS VARCHAR(300),
@Estado AS VARCHAR(8),
@Rol AS VARCHAR(20)
AS
DECLARE
@IdRol INT
SET @IdRol = (SELECT ID FROM Rol WHERE Nombre = @Rol)
UPDATE Usuario SET Usuario = @Usuario,Contraseña = ENCRYPTBYPASSPHRASE('password', @Contrasena),Estado = @Estado,Rol = @IdRol
WHERE Codigo = @CodigoUsuario

