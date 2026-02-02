-- =============================================
-- 3. ACTUALIZAR GUARDAR (Manejo de reactivación)
-- =============================================
CREATE OR ALTER PROCEDURE sp_GuardarCliente
    @Id_cliente INT = 0,
    @Nombre VARCHAR(100),
    @Dni VARCHAR(20),
    @Email VARCHAR(100),
    @Telefono VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Caso Especial: ¿Existe el DNI pero está dado de baja (Activo=0)?
    DECLARE @IdExistente INT;
    SELECT @IdExistente = Id_cliente FROM CLIENTE WHERE Dni = @Dni;

    -- Si existe el cliente (mismo DNI)
    IF @IdExistente IS NOT NULL
    BEGIN
        -- Si estamos intentando crear uno nuevo (Id 0) pero el DNI ya existe...
        IF @Id_cliente = 0 OR @Id_cliente <> @IdExistente
        BEGIN
             -- Lo "Resucitamos" y actualizamos sus datos
             UPDATE CLIENTE
             SET Nombre = @Nombre, 
                 Email = @Email, 
                 Telefono = @Telefono,
                 Activo = 1 -- <--- Lo volvemos a activar
             WHERE Id_cliente = @IdExistente;
             
             RETURN; -- Terminamos aquí
        END
    END

    -- FLUJO NORMAL
    IF @Id_cliente = 0
    BEGIN
        INSERT INTO CLIENTE (Nombre, Dni, Email, Telefono, Activo)
        VALUES (@Nombre, @Dni, @Email, @Telefono, 1);
    END
    ELSE
    BEGIN
        UPDATE CLIENTE
        SET Nombre = @Nombre,
            Dni = @Dni,
            Email = @Email,
            Telefono = @Telefono
            
        WHERE Id_cliente = @Id_cliente;
    END
END
GO

-- =============================================
-- LOGIN DE ADMINISTRADOR
-- =============================================
CREATE OR ALTER PROCEDURE sp_Login
    @Email VARCHAR(100),
    @Clave VARCHAR(256) 
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id_admin, Nombre, Email
    FROM ADMINISTRADOR
    WHERE Email = @Email 
      AND Clave = @Clave;
      
END
GO

CREATE OR ALTER PROCEDURE sp_RegistrarAdmin
    @Nombre VARCHAR(100),
    @Email VARCHAR(100),
    @Clave VARCHAR(256) -- Aquí llegará el Hash
AS
BEGIN
    SET NOCOUNT ON;

    -- 1. Validamos si el email ya existe
    IF EXISTS (SELECT 1 FROM ADMINISTRADOR WHERE Email = @Email)
    BEGIN
        -- Generamos un error controlado que C# podrá atrapar
        RAISERROR('El email ingresado ya está registrado.', 16, 1);
        RETURN;
    END

    -- 2. Si no existe, insertamos
    INSERT INTO ADMINISTRADOR (Nombre, Email, Clave)
    VALUES (@Nombre, @Email, @Clave);
END
GO