CREATE PROCEDURE [dbo].[sp_Login]
    @Option INT = 0,
    @Email NVARCHAR(200),
    @Password NVARCHAR(70)
AS
BEGIN
    SET NOCOUNT ON;

    -- Login
    IF @Option = 2
    BEGIN
        DECLARE @StoredHashedPassword NVARCHAR(128);

        -- Obtener la contraseña almacenada para el usuario
        SELECT @StoredHashedPassword = Contrasena
        FROM [Usuarios]
        WHERE Email = @Email;

        IF @StoredHashedPassword IS NOT NULL
        BEGIN
            -- Verificar la contraseña
            IF PWDCOMPARE(@Password, @StoredHashedPassword) = 1
            BEGIN
                -- La contraseña es válida
                SELECT 'Inicio de sesión exitoso.' AS Resultado;
            END
            ELSE
            BEGIN
                -- La contraseña no es válida
                SELECT 'La contraseña no es válida.' AS Resultado;
            END
        END
        ELSE
        BEGIN
            -- El usuario no existe
            SELECT 'El usuario no existe.' AS Resultado;
        END
    END

    -- Creación de Usuarios
    IF @Option = 1
    BEGIN
        -- Verificar si el correo electrónico ya está registrado
        IF EXISTS (SELECT 1 FROM [Usuarios] WHERE Email = @Email)
        BEGIN
            -- El correo electrónico ya está registrado
            SELECT 'El correo electrónico ya está registrado.' AS Resultado;
        END
        ELSE
        BEGIN
            -- Encriptar la contraseña
            DECLARE @EncryptedPassword VARBINARY(128);
            SET @EncryptedPassword = PWDENCRYPT(@Password);

            -- Insertar el nuevo usuario con la contraseña encriptada
            INSERT INTO [Usuarios] (Email, Contrasena)
            VALUES (@Email, @EncryptedPassword);

            SELECT 'Usuario creado exitosamente.' AS Resultado;
        END
    END
END
