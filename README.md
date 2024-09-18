#  CRUD-.NET8

Este es un proyecto simple de CRUD (Crear, Leer, Actualizar, Eliminar) desarrollado en C# con .NET 8, utilizando Entity Framework Core como ORM para la gestión de la base de datos. El objetivo de este proyecto es demostrar cómo implementar las operaciones básicas de CRUD en una aplicación web.

## Características
- Implementado con .NET 8
- Uso de Entity Framework Core para el acceso a datos
- Operaciones CRUD completas: Crear, Leer, Actualizar y Eliminar
- Interfaz sencilla y amigable
- Conexión a una base de datos relacional (ej. SQL Server)
- Arquitectura MVC (Model-View-Controller)


## Requisitos
Antes de ejecutar este proyecto, asegúrate de tener instalado:

- [Visual Studio 2022](http://https://visualstudio.microsoft.com/es/vs/ "Visual Studio 2022") o superior
- .[NET SDK 8.0](http://https://dotnet.microsoft.com/es-es/download/dotnet/8.0 "NET SDK 8.0")
- [SQL Server](http://https://www.microsoft.com/es-co/sql-server/sql-server-downloads "SQL Server") (o cualquier otra base de datos compatible)

# Estructura del Proyecto
- Models: Contiene las clases de dominio utilizadas por Entity Framework para mapear las tablas de la base de datos.
- Controllers: Define la lógica para manejar las solicitudes HTTP y conectar la vista con los modelos.
- Views: Las páginas HTML que renderizan la interfaz del usuario.
- Data: Contexto de la base de datos configurado por Entity Framework.


