USE OrdenChefDB;
GO

-- RESTAURANTES
INSERT INTO Restaurantes (Nombre, Delegacion, Direccion, Tel)
VALUES
('Las Hamburguesitas', 'Álvaro Obregón', 'Av. Altavista', '5574413280'),
('Dogs #71', 'Azcapotzalco', 'Av. Norte #71', '5584359566'),
('Tacos El Güero', 'Benito Juárez', 'Av. Insurgentes 250', '5587654321'),
('Pizza Express', 'Coyoacán', 'Av. Universidad 100', '5512345678'),
('Aroma', 'Cuajimalpa de Morelos', 'Av. Vasco de Quiroga', '5584200134'),
('Brunetto', 'Cuauhtémoc', 'Av. Paseo de la Reforma', '5502143698'),
('La Piedad', 'Gustavo A. Madero', 'Calzada de Guadalupe', '5501236247'),
('Yumi Yumi', 'Iztacalco', 'Av. Plutarco Elías Calles', '5614008795');

-- PRODUCTOS
INSERT INTO Productos (NombreProducto, Precio, IdRestaurante)
VALUES
('Hamburguesa Sencilla', 100, 1),
('Hamburguesa Hawaiana', 130, 1),
('Refresco 500ml', 30, 1),

('Hot Dog', 25, 2),
('Papas', 50, 2),
('Agua de Horchata', 35, 2),

('Tacos de Cabeza', 25, 3),
('Tacos de Suadero', 25, 3),
('Agua de Tamarindo', 35, 3),

('Pizza de Peperoni', 120, 4),
('Pizza Hawaina', 180, 4),
('Pizza Mexicana', 230, 4),

('Chapata de Pechuga de Pavo', 65, 5),
('Chapata de Carnes Frias', 75, 5),
('Baguet de 3 Quesos', 70, 5),

('Pasta Alfredo', 115, 6),
('Lasaña', 200, 6),
('Pasta al Ajin', 160, 6),

('Club Sandwich', 115, 7),
('Hot Cakes', 40, 7),
('Latte', 35, 7),

('Boneless', 115, 8),
('Alitas', 200, 8),
('Cerveza', 160, 8);