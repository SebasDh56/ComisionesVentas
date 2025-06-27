# ComisionesVentas - Sistema de Cálculo de Comisiones para Vendedores

**ComisionesVentas** es una aplicación web desarrollada con **ASP.NET Core MVC**, diseñada para calcular de manera sencilla y automática las comisiones de los vendedores, basándose en reglas predefinidas según el monto de las ventas. La aplicación es liviana, fácil de configurar y se ejecuta localmente sin necesidad de contenedores ni configuraciones complejas.

---

## Funcionalidades Principales

- Cálculo automático de comisiones (5%, 10% o 15% dependiendo del monto de la venta).
- Filtrado de ventas por rango de fechas y vendedor.
- Interfaz moderna y responsiva con Bootstrap.
- Base de datos local integrada con SQLite.
- Datos de prueba pre-cargados: 5 vendedores, 3 reglas de comisión y 20 ventas de ejemplo.

---

## Tecnologías Utilizadas

- ASP.NET Core MVC (.NET 8)
- Entity Framework Core
- SQLite
- Bootstrap 5

---

## Requisitos Previos

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Git](https://git-scm.com/) (opcional)
- [DB Browser for SQLite](https://sqlitebrowser.org/) (opcional)

---

## Instalación y Configuración

### 1. Clonar el Repositorio

``
git clone https://github.com/tu-usuario/ComisionesVentas.git
cd ComisionesVentas
``

### 2. Configurar la Base de Datos SQLite
Instalar el paquete de SQLite:

dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 8.0.0
Editar el archivo appsettings.json:
json

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=comisiones.db"
  }
}
```
### 3. Configuración del Contexto de Datos en Program.cs
Configurar el contexto de la base de datos en Program.cs:
```
builder.Services.AddDbContext<SalesDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
Restaurar las dependencias:

dotnet restore
```
### 4. Crear y Aplicar Migraciones
Crear la migración inicial y aplicar los cambios:
```
dotnet ef migrations add InitialCreateSQLite --project ComisionesVentas.csproj --startup-project ComisionesVentas.csproj
dotnet ef database update --project ComisionesVentas.csproj --startup-project ComisionesVentas.csproj
Esto creará el archivo comisiones.db en la raíz del proyecto.
```
### 5. Ejecutar la Aplicación
Compilar y ejecutar:
```
dotnet build
dotnet run
```
### Acceder a la aplicación en el navegador:

https://comissionventas.onrender.com/

Estructura del Proyecto
```
ComisionesVentas/
├── Controllers/
│   └── CommissionsController.cs
├── Data/
│   ├── SalesDbContext.cs
│   └── DbInitializer.cs
├── Models/
│   ├── Vendedor.cs
│   ├── Regla.cs
│   └── Venta.cs
├── ViewModels/
│   └── CommissionViewModel.cs
├── Views/
│   └── Commissions/
│       └── Index.cshtml
├── appsettings.json
└── Program.cs
```
## Uso de la Aplicación

### Ejecutar:


dotnet run
Abrir el navegador y acceder a:
```
https://comissionventas.onrender.com/
```
### Calcular comisiones:

Seleccionar un rango de fechas.
Elegir un vendedor específico o "Todos".
Hacer clic en "Calcular".
Visualizar las ventas y las comisiones en la tabla de resultados.
Ejemplo de Reglas de Comisión
```
Monto de la Venta	Comisión Aplicada
Hasta $1000	5%
$1001 - $5000	10%
Más de $5000	15%
```
### Contribuciones
Se aceptan contribuciones mediante pull requests o issues.

### Licencia
Este proyecto se distribuye con fines educativos y de aprendizaje.

### Autor
Amable Sebastian Quishpe
