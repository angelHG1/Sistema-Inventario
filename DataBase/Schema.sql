Create database Sistema_Inventario
go
Use Sistema_Inventario
go 

--Creacion de Tablas

Create table Categoria
(
Id_Categoria int primary key identity,
Nombre varchar(100) not null unique,
Descripcion varchar(500) not null,
Fecha_Creacion date not null,
Fecha_Modificacion date,
Activo Bit not null default 1
)

Create table CategoriaFoto
(
Id_Foto int Primary Key Identity,
Id_Categoria int not null references Categoria(Id_Categoria),
Nombre varchar(500) not null
)

Create Table Suplidor
(
Id_Suplidor int primary key identity,
Nombre_Empresa varchar(100) not null,
Nombre_Contacto varchar(100) not null,
Telefono varchar(20) not null,
Correo varchar(100)  not null,
Web Varchar(200),
Fecha_Creacion date not null,
Fecha_Modificacion date,
Activo Bit not null default 1
)

Create Table Producto
(
Id_Producto int primary key identity,
Id_Categoria int not null,
Id_Suplidor int not null,
Nombre varchar(100) not null,
Precio_Unitario Decimal(10,2) not null,
Fecha_Creacion date not null,
Fecha_Modificacion date,
Activo Bit not null default 1,

foreign Key (Id_Categoria)
References Categoria(Id_Categoria),

foreign Key (Id_Suplidor)
References Suplidor(Id_Suplidor)
)
go

-- Procedimientos almacenados

-- Soft Delete

Create procedure SoftDeleteProducto
@Id_Producto int
as
begin
	set nocount on
	update Producto set Activo=0 
	where Id_Producto = @Id_Producto 
end
go

Create procedure SoftDeleteSuplidor
@Id_Suplidor int
as
begin
	set nocount on
	update Suplidor set Activo=0 
	where Id_Suplidor = @Id_Suplidor 
end
go

Create procedure SoftDeleteCategoria
@Id_Categoria int
as
begin
	set nocount on
	update Categoria set Activo=0 
	where Id_Categoria = @Id_Categoria
end
go

-- Create
Create procedure CreateProducto
(
@Id_Categoria int,
@Id_Suplidor int,
@Nombre varchar(100),
@Precio_Unitario Decimal(10,2),
@Fecha_Creacion date,
@Activo Bit
)
as
begin
	set nocount on

	Insert Into Producto
	(Id_Categoria,Id_Suplidor, Nombre, Precio_Unitario,Fecha_Creacion, Activo)
	Values (@Id_Categoria, @Id_Suplidor, @Nombre, @Precio_Unitario, @Fecha_Creacion, @Activo)
end
go

Create procedure CreateCategoria
(
@Nombre varchar(100),
@Descripcion varchar(500),
@Fecha_Creacion date,
@Activo Bit
)
as
begin
	set nocount on

	Insert Into Categoria
	(Nombre, Descripcion,Fecha_Creacion, Activo)
	Values (@Nombre, @Descripcion, @Fecha_Creacion, @Activo)
end
go

Create procedure CreateSuplidor
(
@Nombre_Empresa varchar(100),
@Nombre_Contacto varchar(100),
@Telefono varchar(20),
@Correo varchar(100),
@Web Varchar(200),
@Fecha_Creacion date,
@Activo Bit
)
as
begin
	set nocount on

	Insert Into Suplidor
	(Nombre_Empresa, Nombre_Contacto, Telefono, Correo, Web, Fecha_Creacion, Activo)
	Values (@Nombre_Empresa, @Nombre_Contacto, @Telefono, @Correo, @Web, @Fecha_Creacion, @Activo)
end
go

-- Update
Create or Alter  Procedure UpdateProducto
(
@Id_Producto int,
@Id_Categoria int,
@Id_Suplidor int,
@Nombre varchar(100),
@Precio_Unitario Decimal(10,2),
@Fecha_Modificacion date,
@Activo Bit
)
as
begin
	set nocount on

	update Producto set
	Id_Categoria = @Id_Categoria, 
	Id_Suplidor= @Id_Suplidor, 
	Nombre = @Nombre, 
	Precio_Unitario = @Precio_Unitario,
	Fecha_Modificacion = @Fecha_Modificacion, 
	Activo = @Activo
	where Id_Producto = @Id_Producto 
end
go

use Sistema_Inventario
Create or Alter Procedure UpdateCategoria
(
@Id_Categoria int,
@Nombre varchar(100),
@Descripcion Varchar(500),
@Fecha_Modificacion date,
@Activo Bit
)
as
begin
	set nocount on

	update Categoria set
	Nombre = @Nombre, 
	Descripcion = @Descripcion,
	Fecha_Modificacion = @Fecha_Modificacion, 
	Activo = @Activo
	where Id_Categoria = @Id_Categoria
end
go

Create or alter Procedure UpdateSuplidor
(
@Id_Suplidor int,
@Nombre_Empresa Varchar(100),
@Nombre_Contacto varchar(100),
@Telefono Varchar(20),
@Correo varchar(100),
@Web varchar(200),
@Fecha_Modificacion date,
@Activo Bit
)
as
begin
	set nocount on

	update Suplidor set
	Nombre_Empresa = @Nombre_Empresa, 
	Nombre_Contacto = @Nombre_Contacto,
	Telefono = @Telefono,
	Correo = @Correo,
	Web = @Web,
	Fecha_Modificacion = @Fecha_Modificacion, 
	Activo = @Activo
	where Id_Suplidor = @Id_Suplidor
end
go