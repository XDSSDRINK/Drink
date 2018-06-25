CREATE PROCEDURE SP_VERIFICA_USUARIO_LOGIN
@Usuarios VARCHAR(15),
@Contrasenas VARCHAR(300)
AS
DECLARE
@Personas int,
@PassEncritado VARCHAR(300),
@PassDecifrado VARCHAR(300)

SET @Personas = (SELECT Persona FROM Usuario WHERE Usuario = @Usuarios)
SET @PassEncritado = (SELECT Contraseña FROM Usuario WHERE Persona = @Personas)
SET	@PassDecifrado = DECRYPTBYPASSPHRASE('password', @PassEncritado)
IF(@PassDecifrado = @Contrasenas)
SELECT Persona FROM Usuario WHERE Persona = @Personas
ELSE
SELECT Persona FROM Usuario WHERE Persona = 0

