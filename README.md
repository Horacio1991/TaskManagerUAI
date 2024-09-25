# Task Manager - Gestión de Tareas por Sectores

Este proyecto es una aplicación de escritorio desarrollada en C# usando ADO.NET y arquitectura en capas (DAL, BLL, UI, Entity), diseñada para gestionar tareas asignadas a empleados de una empresa. 
Los administradores pueden gestionar usuarios y asignar tareas a empleados de su sector, mientras que los empleados pueden visualizar y marcar sus tareas como completadas.

## Características Principales

- **Administradores:**
  - Pueden agregar, modificar y eliminar usuarios de su sector.
  - Asignar tareas a empleados de su sector con una fecha límite para su finalización.
  - Ver un resumen de todas las tareas asignadas en su sector.
  - Marcar tareas como completadas.

- **Usuarios (empleados):**
  - Solo pueden ver las tareas que les han sido asignadas.
  - Marcar sus propias tareas como completadas.

## Arquitectura en Capas

El proyecto sigue una arquitectura en capas que incluye:

1. **Capa de Presentación (UI):**
   - Ventanas y formularios de Windows Forms para la interacción con el usuario.
   - Los formularios incluyen gestión de usuarios, asignación de tareas y visualización de tareas.
   
2. **Capa de Negocio (BLL):**
   - Manejo de la lógica de negocio.
   - Validación de datos y conexión con la capa de datos.
   - Métodos para agregar, modificar, eliminar y consultar tareas y usuarios.

3. **Capa de Datos (DAL):**
   - Acceso a la base de datos mediante ADO.NET.
   - Consultas y transacciones SQL para gestionar usuarios y tareas.

4. **Capa de Entidades (Entity):**
   - Modelos de datos para representar usuarios y tareas en el sistema.

## Requisitos del Sistema

- **IDE**: Visual Studio 2022 o superior
- **.NET Framework**: 4.7.2 o superior
- **Base de datos**: Microsoft SQL Server

## Configuración de la Base de Datos

La cadena de conexión a la base de datos está configurada en el archivo `app.config` del proyecto. 

```xml
<connectionStrings>
    <add name="EmpresaTicketsDB" connectionString="Data Source=TU_SERVIDOR;Initial Catalog=TaskManagerDB;Integrated Security=True;" providerName="System.Data.SqlClient" />
</connectionStrings>

## Funcionalidades Detalladas

### Administrador
- **Agregar Usuario**: Agrega un nuevo usuario al sistema asignándole un nombre, email, contraseña.
- **Modificar Usuario**: Permite modificar los datos de un usuario existente usando su email como identificador.
- **Eliminar Usuario**: Elimina a un usuario y sus tareas asignadas.
- **Asignar Tareas**: Asigna tareas a un empleado del sector, especificando un título, descripción y fecha límite.
- **Ver Tareas del Sector**: Muestra un resumen de todas las tareas asignadas a los empleados del sector.

### Usuario (Empleado)
- **Ver Tareas**: Muestra las tareas que el usuario tiene asignadas, con la posibilidad de marcarlas como completadas.

## Uso de la Aplicación

### Pantalla de Login
- Los usuarios deben iniciar sesión con su email y contraseña.
- Los administradores pueden acceder a las opciones de gestión de usuarios y tareas.
- Los empleados solo pueden ver sus tareas.

### Gestión de Usuarios
- Los administradores pueden agregar, modificar o eliminar usuarios de su sector.

### Asignación de Tareas
- Los administradores pueden asignar tareas a los empleados de su sector.
- Las tareas incluyen título, descripción y fecha límite para completarlas.

### Visualización de Tareas
- Tanto administradores como empleados pueden ver las tareas asignadas.
- Los empleados pueden marcar sus tareas como completadas.

