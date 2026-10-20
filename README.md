# Sistema de Inventario

Sistema de escritorio desarrollado en C# con Windows Forms y SQL Server para gestionar categorías, suplidores y productos, permitiendo registrar, consultar, modificar, desactivar y restaurar registros.

## Tecnologías utilizadas

- **Lenguaje:** C#
- **Interfaz gráfica:** Windows Forms
- **Base de datos:** Microsoft SQL Server
- **Gestión de base de datos:** SQL Server Management Studio (SSMS)
- **Entorno de desarrollo:** Visual Studio Community
- **Arquitectura:** N capas
- **Control de versiones:** Git y GitHub

## Funcionalidades

### Gestión de categorías
- Registrar categorías.
- Consultar y buscar categorías.
- Modificar información.
- Desactivar categorías mediante eliminación lógica.
- Restaurar categorías desde la papelera.
- Validar los datos antes de guardarlos.

### Gestión de suplidores
- Registrar empresas suplidoras.
- Consultar y buscar suplidores.
- Modificar su información de contacto.
- Desactivar y restaurar registros.
- Validar información como teléfono y correo electrónico.

### Gestión de productos
- Registrar productos asociados a una categoría y un suplidor.
- Consultar y buscar productos.
- Modificar la información de los productos.
- Desactivar productos sin eliminarlos físicamente de la base de datos.
- Restaurar productos desde la papelera.

### Papelera de reciclaje
- Consultar los registros desactivados.
- Buscar registros dentro de la papelera.
- Restaurar categorías, suplidores y productos.

## Arquitectura del proyecto

El sistema utiliza una arquitectura por capas para separar las responsabilidades y facilitar el mantenimiento del código.

| Capa | Responsabilidad |
|---|---|
| `SistemaInventario.Entidades` | Contiene las clases que representan los datos del sistema. |
| `SistemaInventario.AccesoDatos` | Gestiona las operaciones de comunicación con SQL Server y los repositorios. |
| `SistemaInventario.LogicaNegocio` | Contiene las validaciones y reglas de negocio. |
| `SistemaInventario.Presentación` | Contiene los formularios y la interfaz gráfica del usuario. |

Esta separación permite que cada capa tenga una responsabilidad específica y facilita los cambios futuros del sistema.


## Instalación y configuración

### 1. Descargar el proyecto

Clonar o descargar el repositorio

### 2. Crear la base de datos

Ejecutar los 2 archivos del directorio Database

### 3. Configurar la conexión

Verificar la cadena de conexión utilizada por la aplicación y ajústarla a la instancia de SQL Server.
la base de datos debe haberse creado correctamente antes de ejecutar el programa.

### 4. Ejecutar desde Visual Studio

1. Abrir src/SistemaInventario.sln.
2. Configurar el proyecto SistemaInventario.Presentación como proyecto de inicio.
3. Verificar la cadena de conexión.
4. Ejecutar el proyecto.

### 5. Ejecutar la versión compilada

Entrar en la carpeta build y ejecuta el archivo .exe publicado.

## Capturas de pantalla

<img width="810" height="494" alt="image" src="https://github.com/user-attachments/assets/c0781a17-55ac-4e5f-b4ea-06f4ab72b1a9" />
<img width="980" height="639" alt="image" src="https://github.com/user-attachments/assets/bf57bca4-0717-4064-b757-1acacb7a4ac1" />
<img width="998" height="661" alt="image" src="https://github.com/user-attachments/assets/c1504187-bc15-4347-8dba-ce187816eeb5" />

