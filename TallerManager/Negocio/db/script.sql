-- 1. Crear la Base de Datos
CREATE DATABASE TallerTextilDB;
GO

USE TallerTextilDB;
GO

-- ---------------------------------------------------------
-- 2. Tablas de Catálogos e Independientes
-- ---------------------------------------------------------

CREATE TABLE CLIENTE (
    Id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Dni VARCHAR(20),
    Email VARCHAR(100),
    Telefono VARCHAR(50)
);

CREATE TABLE ESTADO (
    Id_estado INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL
);

CREATE TABLE POSICION (
    Id_posicion INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL -- Ej: Frente, Espalda, Manga
);

CREATE TABLE IMAGEN (
    Id_imagen INT IDENTITY(1,1) PRIMARY KEY, -- Corregido: estandarizado a Id_imagen
    Url_imagen VARCHAR(MAX) -- MAX para rutas largas o base64 si fuera necesario
);

-- ---------------------------------------------------------
-- 3. Tablas de Activos (Matrices)
-- ---------------------------------------------------------

CREATE TABLE MATRIZ (
    Id_matriz INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Url_matriz VARCHAR(MAX), -- Corregido: "Url_martriz" -> "Url_matriz"
    Id_imagen INT,
    CONSTRAINT FK_Matriz_Imagen FOREIGN KEY (Id_imagen) REFERENCES IMAGEN(Id_imagen)
);

-- ---------------------------------------------------------
-- 4. Tablas Principales de Operación (Trabajo y Items)
-- ---------------------------------------------------------

CREATE TABLE TRABAJO (
    Id_trabajo INT IDENTITY(1,1) PRIMARY KEY,
    Id_cliente INT NOT NULL,
    Id_estado INT NOT NULL,
    Fecha DATETIME DEFAULT GETDATE(),
    Total MONEY DEFAULT 0,
    CONSTRAINT FK_Trabajo_Cliente FOREIGN KEY (Id_cliente) REFERENCES CLIENTE(Id_cliente),
    CONSTRAINT FK_Trabajo_Estado FOREIGN KEY (Id_estado) REFERENCES ESTADO(Id_estado)
);

CREATE TABLE ITEM_TRABAJO (
    Id_item INT IDENTITY(1,1) PRIMARY KEY,
    Id_trabajo INT NOT NULL,
    Descripcion VARCHAR(200) NOT NULL, -- Ej: "Remera Jersey L"
    Cantidad INT NOT NULL DEFAULT 1,   -- Agregado: Fundamental
    Prenda_propia BIT DEFAULT 0,       -- 1 = Si (No cobra prenda), 0 = No (Vende prenda)
    Precio_unitario MONEY DEFAULT 0,   -- Costo de la prenda (confección)
    CONSTRAINT FK_Item_Trabajo FOREIGN KEY (Id_trabajo) REFERENCES TRABAJO(Id_trabajo) ON DELETE CASCADE
);

-- ---------------------------------------------------------
-- 5. Tabla de Detalle (Bordados aplicados al item)
-- ---------------------------------------------------------

CREATE TABLE BORDADO (
    Id_bordado INT IDENTITY(1,1) PRIMARY KEY,
    Id_item_trabajo INT NOT NULL,
    Id_matriz INT NOT NULL,
    Id_posicion INT,
    Puntadas INT,
    Ancho DECIMAL(10,2), -- Corregido: Decimal para medidas exactas
    Alto DECIMAL(10,2),  -- Corregido: Decimal para medidas exactas
    Valor MONEY NOT NULL,
    CONSTRAINT FK_Bordado_Item FOREIGN KEY (Id_item_trabajo) REFERENCES ITEM_TRABAJO(Id_item) ON DELETE CASCADE,
    CONSTRAINT FK_Bordado_Matriz FOREIGN KEY (Id_matriz) REFERENCES MATRIZ(Id_matriz),
    CONSTRAINT FK_Bordado_Posicion FOREIGN KEY (Id_posicion) REFERENCES POSICION(Id_posicion)
);
GO

-- ---------------------------------------------------------
-- 6. Datos Iniciales (Semilla) para probar
-- ---------------------------------------------------------

-- Insertar Estados Básicos
INSERT INTO ESTADO (Nombre) VALUES ('Pendiente'), ('En Proceso'), ('Terminado'), ('Entregado');

-- Insertar Posiciones Comunes
INSERT INTO POSICION (Nombre) VALUES ('Pecho Izquierdo'), ('Pecho Derecho'), ('Espalda Grande'), ('Manga'), ('Frente Gorra');