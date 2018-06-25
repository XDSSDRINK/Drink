CREATE PROC SP_CREAR_USUARIOS
@DNI AS BIGINT,
@Usuario AS VARCHAR(15),
@Contrasena AS VARCHAR(300),
@Estado AS VARCHAR(8),
@Rol AS VARCHAR(20)
AS
DECLARE
@IdRol INT,
@CodigoPersona INT

SET @IdRol = (SELECT ID FROM Rol WHERE Nombre = @Rol)
SET @CodigoPersona = (SELECT Codigo FROM Persona WHERE DNI = @DNI)
INSERT INTO Usuario VALUES(@CodigoPersona,@Usuario,ENCRYPTBYPASSPHRASE('password', @Contrasena),@Estado,@IdRol)




