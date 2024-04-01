# RetroShoes E-commerce 

Este proyecto es un e-commerce de zapatos desarrollado con ASP.NET Core, que utiliza una base de datos SQL para almacenar la información de los productos, los usuarios y otras entidades relevantes. Además, se ha implementado una API utilizando Swagger para realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) en la base de datos de productos, así como también filtros por género y marca.

## Características principales

- **ASP.NET Core**: El proyecto está desarrollado utilizando ASP.NET Core, lo que proporciona una plataforma robusta y escalable para la construcción de aplicaciones web.
- **Base de datos SQL**: Se utiliza una base de datos SQL para almacenar la información de los productos, usuarios y otras entidades del sistema.
- **API Swagger**: Se ha implementado una API con Swagger, lo que facilita la documentación y el consumo de los servicios web.
- **Operaciones CRUD**: La API permite realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) en la base de datos de productos.
- **Filtros por género y marca**: Los usuarios pueden filtrar los zapatos por género y marca para una experiencia de compra personalizada.
- **Inicio de sesión y registro**: Se proporciona funcionalidad de inicio de sesión y registro para los usuarios.

## Requisitos del sistema

- **ASP.NET Core SDK**: Es necesario tener instalado el SDK de ASP.NET Core para compilar y ejecutar el proyecto.
- **SQL Server**: Se requiere una instancia de SQL Server para alojar la base de datos del sistema.
- **Navegador web**: Para interactuar con la aplicación a través de la interfaz de usuario.

## Configuración del proyecto

1. **Clonar el repositorio**: Clona el repositorio del proyecto desde GitHub.

```bash
git clone https://github.com/SantiagoAnzola1/RetroShoes.git
```

2. **Crear archivo `appsettings.json` **: Crear archivo **`appsettings.json`** dentro de la carpeta UserAPI e incluir:
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },

  "ConnectionStrings": {
    "DefaultConnection": "data source=<Server name>;initial catalog=<database name>;User Id=<user id/ username>;Password=<password>"
  },
  "AllowedHosts": "*"
}
```
3. **Configurar la base de datos**: Configura una base de datos SQL Server y actualiza la cadena de conexión en el archivo `appsettings.json` con la información de tu instancia de SQL Server.

```json
"ConnectionStrings": {
    "DefaultConnection": "data source=<Server name>;initial catalog=<database name>;User Id=<user id/ username>;Password=<password>"
  }
```
3. **Crear Base de Datos**: Descarga el archivo `SQLQuery1.sql` y ejecuta en el sistema de gestión de base de datos relacional de tu preferencia. 

4. **Compilar y ejecutar el proyecto**: Abre el proyecto en tu entorno de desarrollo preferido (Visual Studio, Visual Studio Code, etc.) y compila el proyecto. Luego, ejecútalo para iniciar el servidor web.

5. **Acceder a la documentación de la API**: Una vez que el proyecto esté en ejecución, accede a la documentación de la API Swagger en `http://localhost:<puerto>/swagger`.

