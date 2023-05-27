# Sistema de Gestión de Compras de Animales


## Descripción
Este proyecto es un sistema de gestión de compras de animales que permite a los clientes explorar y adquirir animales de diferentes razas. Proporciona una interfaz intuitiva y fácil de usar para realizar pedidos y generar detalles de facturación.

## Características principales
- Búsqueda y selección de animales por raza, sexo y estado.
- Agregado de animales al carrito de compras.
- Aplicación automática de descuentos según reglas de negocio.
- Cálculo del costo de envío en función del número de animales.
- Generación de detalles de facturación con información detallada del pedido.
- Modal de agradecimiento al finalizar la compra.

## Tecnologías utilizadas
- ASP.NET Core
- HTML, CSS y JavaScript
- Bootstrap
- DataTables
- Entity Framework Core

## Configuración y ejecución del proyecto
1. Clona el repositorio del proyecto desde GitHub.
2. Abre el proyecto en tu entorno de desarrollo preferido (por ejemplo, Visual Studio).
3. Asegúrate de tener las dependencias y herramientas necesarias instaladas, como el SDK de .NET Core.
4. Configura la conexión a la base de datos en el archivo `appsettings.json` según tus necesidades. Aquí tienes un ejemplo:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=NombreBaseDeDatos;User=Usuario;Password=Contraseña;"
  }
}
```
5. Ejecuta las migraciones para crear la base de datos y las tablas necesarias. Utiliza el siguiente comando:

```shell
dotnet ef database update
```

6. Compila y ejecuta la aplicación. Utiliza el siguiente comando:

```shell
dotnet ef database update
```

## Contribución
Si deseas contribuir a este proyecto, sigue estos pasos:
1. Realiza un fork del repositorio.
2. Crea una rama con un nombre descriptivo para tu función o corrección de errores.
3. Realiza los cambios en tu rama y asegúrate de que el código sea coherente con las convenciones del proyecto.
4. Envía una solicitud de extracción explicando los cambios realizados y su propósito.

Agradecemos cualquier contribución que ayude a mejorar este sistema de gestión de compras de animales.

## Soporte
Si tienes alguna pregunta, problema o sugerencia relacionada con este proyecto, no dudes en abrir un nuevo problema en el repositorio de GitHub. Estaremos encantados de ayudarte.

¡Gracias por tu interés y apoyo en este proyecto de gestión de compras de animales!
