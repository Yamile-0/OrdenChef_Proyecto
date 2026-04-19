USE OrdenChefDB;
GO

-- Tabla Restaurantes
CREATE TABLE Restaurantes (
    IdRestaurante INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Delegacion NVARCHAR(100) NOT NULL,
    Direccion NVARCHAR(200),
    Tel NVARCHAR(20)
);

-- Tabla Productos
CREATE TABLE Productos (
    IdProducto INT PRIMARY KEY IDENTITY(1,1),
    NombreProducto NVARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    IdRestaurante INT NOT NULL,
    FOREIGN KEY (IdRestaurante) REFERENCES Restaurantes(IdRestaurante)
);

-- Tabla Pedidos
CREATE TABLE Pedidos (
    IdPedido INT PRIMARY KEY IDENTITY(1,1),
    FechaPedido DATETIME NOT NULL DEFAULT GETDATE(),
    DelegacionUsuario NVARCHAR(100),
    EstadoPedido NVARCHAR(50) NOT NULL,
    Total DECIMAL(10,2) NOT NULL
);

-- Tabla DetallePedido
CREATE TABLE DetallePedido (
    IdDetalle INT PRIMARY KEY IDENTITY(1,1),
    IdPedido INT NOT NULL,
    IdProducto INT NOT NULL,
    Cantidad INT NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (IdPedido) REFERENCES Pedidos(IdPedido),
    FOREIGN KEY (IdProducto) REFERENCES Productos(IdProducto)
);