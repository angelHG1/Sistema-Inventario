-- Datos de prueba

-- Categorias

Insert Into Categoria
(Nombre, Descripcion, Fecha_Creacion, Activo)
Values
('Electronica', 'Productos electronicos y accesorios tecnologicos', GETDATE(), 1),
('Hogar', 'Articulos para el hogar y uso domestico', GETDATE(), 1),
('Oficina', 'Materiales y equipos para oficina', GETDATE(), 1),
('Deportes', 'Articulos y accesorios deportivos', GETDATE(), 1),
('Accesorios', 'Accesorios para computadoras y dispositivos', GETDATE(), 1)
go

-- Fotos de categorias

Insert Into CategoriaFoto
(Id_Categoria, Nombre)
Values
(1, 'electronica.jpg'),
(1, 'tecnologia.jpg'),
(2, 'hogar.jpg'),
(3, 'oficina.jpg'),
(4, 'deportes.jpg'),
(5, 'accesorios.jpg')
go

-- Suplidores

Insert Into Suplidor
(Nombre_Empresa, Nombre_Contacto, Telefono, Correo, Web, Fecha_Creacion, Activo)
Values
('Tech Dominicana', 'Carlos Perez', '809-555-1001', 'contacto@techdominicana.com', 'https://techdominicana.com', GETDATE(), 1),
('Distribuidora del Caribe', 'Maria Rodriguez', '829-555-1002', 'ventas@distribuidoracaribe.com', 'https://distribuidoracaribe.com', GETDATE(), 1),
('Suministros Empresariales', 'Jose Martinez', '849-555-1003', 'info@suministrosempresariales.com', 'https://suministrosempresariales.com', GETDATE(), 1),
('Deportes Total', 'Ana Garcia', '809-555-1004', 'ventas@deportestotal.com', 'https://deportestotal.com', GETDATE(), 1),
('Accesorios Digitales', 'Luis Fernandez', '829-555-1005', 'contacto@accesoriosdigitales.com', NULL, GETDATE(), 1)
go

-- Productos

Insert Into Producto
(Id_Categoria, Id_Suplidor, Nombre, Precio_Unitario, Fecha_Creacion, Activo)
Values
-- Electronica
(1, 1, 'Laptop Lenovo', 35000.00, GETDATE(), 1),
(1, 1, 'Monitor Samsung 24 pulgadas', 8500.00, GETDATE(), 1),
(1, 5, 'Teclado mecanico', 2500.00, GETDATE(), 1),
(1, 5, 'Mouse inalambrico', 950.00, GETDATE(), 1),

-- Hogar
(2, 2, 'Licuadora', 2200.00, GETDATE(), 1),
(2, 2, 'Ventilador de pedestal', 3500.00, GETDATE(), 1),
(2, 2, 'Plancha electrica', 1200.00, GETDATE(), 1),
(2, 2, 'Microondas', 6500.00, GETDATE(), 1),

-- Oficina
(3, 3, 'Resma de papel', 280.00, GETDATE(), 1),
(3, 3, 'Grapadora metalica', 350.00, GETDATE(), 1),
(3, 3, 'Silla de oficina', 4500.00, GETDATE(), 1),
(3, 3, 'Escritorio ejecutivo', 12500.00, GETDATE(), 1),

-- Deportes
(4, 4, 'Balon de futbol', 1500.00, GETDATE(), 1),
(4, 4, 'Balon de baloncesto', 1800.00, GETDATE(), 1),
(4, 4, 'Mancuernas 10 kg', 2200.00, GETDATE(), 1),
(4, 4, 'Cuerda para saltar', 450.00, GETDATE(), 1),

-- Accesorios
(5, 5, 'Cable USB-C', 350.00, GETDATE(), 1),
(5, 5, 'Adaptador HDMI', 750.00, GETDATE(), 1),
(5, 1, 'Memoria USB 64 GB', 600.00, GETDATE(), 1),
(5, 1, 'Disco SSD 500 GB', 3200.00, GETDATE(), 1)
go




