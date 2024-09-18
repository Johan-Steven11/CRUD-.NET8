CRUD Básico con .NET 8 y Entity Framework
Este es un proyecto simple de CRUD (Crear, Leer, Actualizar, Eliminar) desarrollado en C# con .NET 8, utilizando Entity Framework Core como ORM para la gestión de la base de datos. El objetivo de este proyecto es demostrar cómo implementar las operaciones básicas de CRUD en una aplicación web.

Características
Implementado con .NET 8
Uso de Entity Framework Core para el acceso a datos
Operaciones CRUD completas: Crear, Leer, Actualizar y Eliminar
Interfaz sencilla y amigable
Conexión a una base de datos relacional (ej. SQL Server)
Arquitectura MVC (Model-View-Controller)
Requisitos
Antes de ejecutar este proyecto, asegúrate de tener instalado:

Visual Studio 2022 o superior
.NET SDK 8.0
SQL Server (o cualquier otra base de datos compatible)
Configuración del Proyecto
Clona este repositorio:


git clone https://github.com/tu-usuario/nombre-del-repositorio.git
Navega hasta el directorio del proyecto:


cd nombre-del-repositorio
Configura la cadena de conexión: Abre el archivo appsettings.json y actualiza la cadena de conexión con los detalles de tu base de datos:


{
  "ConnectionStrings": {
    "DefaultConnection": "Server=tu_servidor;Database=tu_base_de_datos;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
Aplica las migraciones: Si es la primera vez que ejecutas el proyecto, asegúrate de crear la base de datos ejecutando las migraciones de Entity Framework Core:



dotnet ef database update
Ejecuta la aplicación: Puedes ejecutar la aplicación en tu entorno local con el siguiente comando:


dotnet run
Luego, abre tu navegador y navega a https://localhost:5001 para ver la aplicación en funcionamiento.

Estructura del Proyecto
Models: Contiene las clases de dominio utilizadas por Entity Framework para mapear las tablas de la base de datos.
Controllers: Define la lógica para manejar las solicitudes HTTP y conectar la vista con los modelos.
Views: Las páginas HTML que renderizan la interfaz del usuario.
Data: Contexto de la base de datos configurado por Entity Framework.
