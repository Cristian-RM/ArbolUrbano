# TropicosSync - Proyecto TCU

**TropicosSync** es un proyecto de la **Universidad Técnica Nacional (UTN)**, creado como parte de un **Trabajo Comunal Universitario (TCU)**, con el objetivo de sincronizar datos del **API de Tropicos** a una base de datos local para fines de investigación y conservación, en el marco de una **ONG sin fines de lucro**.

Este repositorio contiene una librería que facilita la sincronización de especies y otros datos desde el **API de Tropicos** hacia nuestra base de datos local. El proyecto busca contribuir a la preservación de especies y a la investigación científica mediante el uso de datos abiertos.

## Estructura del Proyecto

### 1. **Librería `TropicosSyncLib`**

Esta librería contiene la lógica de negocio para interactuar con el **API de Tropicos**, sincronizar datos con una base de datos local y realizar operaciones como agregar, actualizar o consultar especies. 

- **`SpeciesRepository.cs`**: Repositorio que gestiona la sincronización de las especies.
- **`TropicosApiClient.cs`**: Cliente para interactuar con el API de Tropicos.
- **`IDbContext.cs`**: Interfaz genérica para interactuar con la base de datos, permitiendo la conexión con cualquier implementación de `DbContext`.

### 2. **Aplicación Web o API**

La aplicación web o API expone servicios para la gestión de los datos sincronizados y permite a los usuarios interactuar con la base de datos de especies.

- **`ApplicationDbContext.cs`**: Implementación de `DbContext` específico de la aplicación.
- **`SpeciesSyncService.cs`**: Servicio encargado de orquestar la sincronización de los datos.

### 3. **Pruebas y Validación**

El proyecto incluye pruebas unitarias para garantizar que la sincronización y las operaciones sobre los datos sean correctas.

- **`TropicosSyncLib.Tests`**: Proyecto que contiene pruebas unitarias para la librería.

## Requisitos

- .NET 8.0 o superior
- Entity Framework Core
- Acceso a la API de Tropicos

## Instalación

1. Clonar el repositorio:

   ```bash
   git clone https://github.com/tu-usuario/tropicos-sync.git
    
   ```
2. Restaurar los paquetes NuGet:

   ```bash
    dotnet restore
    ```
3. Construir el proyecto:

   ```bash
    dotnet build
    ```
4. Ejecutar el proyecto:

   ```bash
    dotnet run
    ```



## Configuración

1. Conexión a la Base de Datos
Asegúrate de tener configurada la cadena de conexión en el archivo appsettings.json para conectarte a la base de datos SQL:

 ```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=NombreDeBaseDeDatos;User Id=usuario;Password=contraseña;"
  }
}
   ```

   2. API Key de Tropicos
El proyecto requiere una API Key para acceder al servicio de Tropicos. Debes obtener una clave de la API y configurarla en el archivo de configuración correspondiente.


 ```json
{
{
  "TropicosApi": {
    "ApiKey": "tu-api-key-aqui"
  }
}
   ```
## Contribuciones
Este proyecto está destinado a ser colaborativo y está abierto a nuevas contribuciones. Si deseas contribuir, por favor sigue estos pasos:

   1. Haz un fork del repositorio.

   2. Crea una rama con tu nombre y la característica o bug que estás resolviendo.

   3. Realiza las modificaciones necesarias.

   4. Asegúrate de agregar pruebas unitarias para las nuevas características.

   5. Realiza un pull request para revisar tus cambios.

## Licencia
Este proyecto es de carácter educativo y no tiene fines de lucro. No está sujeto a una licencia comercial, pero se puede utilizar para fines educativos y de investigación.
