USE TallerTextilDB;
GO

-- =============================================
-- 1. CLIENTES
-- =============================================

-- Procedimiento para insertar (o editar) clientes
CREATE OR ALTER PROCEDURE sp_GuardarCliente
    @Id_cliente INT = 0, -- Si es 0 inserta, si >0 actualiza
    @Nombre VARCHAR(100),
    @Dni VARCHAR(20),
    @Email VARCHAR(100),
    @Telefono VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    IF @Id_cliente = 0
    BEGIN
        INSERT INTO CLIENTE (Nombre, Dni, Email, Telefono)
        VALUES (@Nombre, @Dni, @Email, @Telefono);
    END
    ELSE
    BEGIN
        UPDATE CLIENTE 
        SET Nombre = @Nombre, Dni = @Dni, Email = @Email, Telefono = @Telefono
        WHERE Id_cliente = @Id_cliente;
    END
END
GO