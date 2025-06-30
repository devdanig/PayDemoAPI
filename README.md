# 🚀 PayDemoAPI

API de demostración construida con **.NET 8** para simular operaciones básicas de un sistema de pagos y gestión de usuarios. Este proyecto fue creado como práctica técnica para entrevistas, con enfoque en mostrar dominio de las tecnologías clave solicitadas: **C#, ASP.NET Core, SQL Server y EF Core**.

---

## 🎯 ¿Qué hace?

- Gestiona usuarios (crear, listar, etc.)
- Simula transacciones entre cuentas
- Expone un API REST con endpoints seguros y claros
- Integra persistencia en base de datos SQL Server usando Entity Framework Core

---

## 🛠 Tecnologías utilizadas

- **C# 12 y .NET 8**: lenguaje principal y plataforma del backend.
- **ASP.NET Core Web API**: framework para la creación de servicios RESTful.
- **Entity Framework Core**: ORM para persistencia en SQL Server.
- **SQL Server 2022**: motor de base de datos relacional.
- **Docker (opcional)**: para levantar SQL Server en contenedor.
- **Postman**: pruebas de los endpoints.
- **Git**: control de versiones.

---

## 📂 Estructura del proyecto

```
PayDemoAPI/
├── Controllers/
│   └── UsersController.cs
├── Data/
│   └── AppDbContext.cs
├── Models/
│   └── User.cs
├── Program.cs
├── appsettings.json
└── ...
```

---

## 🚦 Endpoints principales

- **GET /api/users**: lista los usuarios.
- **POST /api/users**: crea un usuario nuevo.
- *(Próximamente)* **POST /api/transactions**: simular transacción entre usuarios.

---

## ⚙️ Configuración

### 1️⃣ Clona este repositorio:

```bash
git clone https://github.com/TuUsuario/PayDemoAPI.git
cd PayDemoAPI
```

### 2️⃣ Ajusta tu cadena de conexión a SQL Server en `appsettings.json`:

```json
{
  "ConnectionStrings": {
     *(Próximamente)* "DefaultConnection": "*SIN CONEXION (EN PROGRESO)*"
  }
}
```

### 3️⃣ Aplica las migraciones para crear la base de datos:

```bash
dotnet ef database update
```

### 4️⃣ Corre el API:

```bash
dotnet run
```

---

## ✅ Requisitos

- .NET 8 SDK instalado.
- SQL Server (en local o en contenedor).
- Git para clonar y versionar.

---

## 👨‍💻 Autor

**Daniel Garcia]** – Estudiante de Software, apasionado por el backend, la arquitectura de sistemas y crear soluciones que impacten positivamente.
