# Employee Attendance Management System

A desktop-based **Employee Attendance Management System** developed to manage employees and record their attendance in an organization.

The project includes two implementations of the system, one developed with **C# Windows Forms** and another with **Java Swing**, both connected to a **Microsoft SQL Server** database.

The system allows administrators to register employees, search for employees, modify or delete employee information, and record and review attendance records.

## 📋 Features

### 👨‍💼 Employee Management

* Register new employees
* Search employees
* Modify employee information
* Delete employees
* View employee information

### 🕐 Attendance Management

* Register employee attendance
* Record check-in information
* View attendance history
* Associate attendance records with employees
* Query attendance information

### 🗄️ Database

* Microsoft SQL Server integration
* Employee data management
* Attendance records
* SQL queries for CRUD operations
* Database backup included

## 🖥️ Screenshots

### Main Menu

![Main Menu](Screenshots/Manu%20Principal.jpg)

### Register Employee

![Register Employee](Screenshots/Registrar%20Empleados.jpg)

### Search Employee

![Search Employee](Screenshots/Buscar%20Empleado.jpg)

### Modify Employee

![Modify Employee](Screenshots/Modificar%20Empleado.jpg)

### Delete Employee

![Delete Employee](Screenshots/Eliminar%20Empleado.jpg)

### Register Attendance

![Register Attendance](Screenshots/Registrar%20Checada.jpg)

### Attendance History

![Attendance History](Screenshots/Historial%20Checada%20.jpg)

### Database Diagram

![Database Diagram](Screenshots/Diagrama%20DB.png)

## 🛠️ Technologies

| Technology           | Purpose                         |
| -------------------- | ------------------------------- |
| C#                   | Desktop application development |
| .NET Framework 4.7.2 | C# application framework        |
| Windows Forms        | C# graphical user interface     |
| Java                 | Desktop application development |
| Java Swing           | Java graphical user interface   |
| Microsoft SQL Server | Database management             |
| JDBC                 | Java database connectivity      |
| SQL                  | Database queries                |
| Visual Studio        | C# development                  |
| NetBeans             | Java development                |

## 🏗️ Project Architecture

The project contains two desktop implementations connected to the same database concept.

```text
Employee Attendance Management System
│
├── C# Implementation
│   └── Windows Forms
│       ├── Employee Management
│       ├── Attendance Registration
│       └── Attendance History
│
├── Java Implementation
│   └── Java Swing
│       ├── Employee Management
│       ├── Attendance Registration
│       └── Attendance History
│
└── Microsoft SQL Server
    ├── Employees
    └── Attendance Records
```

## 📂 Project Structure

```text
employee-attendance-management-system/
│
├── C#-RelojChecador/
│   ├── ProyectoRelojChecador.sln
│   └── ProyectoRelojChecador/
│       ├── BDPrincipal.cs
│       ├── Empleado.cs
│       ├── EmpleadoQuery.cs
│       ├── Checada.cs
│       ├── ChecadaQuery.cs
│       ├── Form1.cs
│       ├── FrmAgregarEmpleado.cs
│       ├── FrmBuscarEmpleado.cs
│       ├── FrmModificarEmpleado.cs
│       ├── FrmEliminarEmpleado.cs
│       └── FrmRegistroChecada.cs
│
├── Java-RolojChecador/
│   ├── build.xml
│   ├── manifest.mf
│   └── src/
│       └── app/
│           ├── BDPrincipal.java
│           ├── Empleado.java
│           ├── EmpleadoQuery.java
│           ├── Checada.java
│           ├── ChecadaQuery.java
│           ├── ChecadorPrincipal.java
│           ├── FrmAgregarEmpleado.java
│           ├── FrmBuscarEmpleado.java
│           ├── FrmModificarEmpleado.java
│           ├── FrmEliminarEmpleado.java
│           └── FrmRegistroChecada.java
│
├── Screenshots/
│   ├── Buscar Empleado.jpg
│   ├── Diagrama DB.png
│   ├── Eliminar Empleado.jpg
│   ├── Historial Checada .jpg
│   ├── Manu Principal.jpg
│   ├── Modificar Empleado.jpg
│   ├── Registrar Checada.jpg
│   └── Registrar Empleados.jpg
│
├── SCRIPT BASE DE DATOS RELOJ.sql
├── Respaldo-DBRelojChecador.bak
└── README.md
```

## 👥 Employee Management Module

The employee management module provides the basic CRUD operations required to maintain employee information.

```text
                Employee Management
                       │
        ┌──────────────┼──────────────┐
        ▼              ▼              ▼
     Create          Search         Update
        │              │              │
        └──────────────┼──────────────┘
                       ▼
                     Delete
```

### Available Operations

* **Create:** Register a new employee.
* **Read:** Search and view employee information.
* **Update:** Modify existing employee information.
* **Delete:** Remove an employee from the system.

## 🕐 Attendance Module

The attendance module allows employees' check-in records to be registered and later consulted.

```text
Employee
    │
    ▼
Attendance Registration
    │
    ▼
SQL Server
    │
    ▼
Attendance History
```

Attendance records are associated with employees through the database.

## 🗄️ Database

The application uses **Microsoft SQL Server** as its relational database.

The repository includes the SQL database script:

```text
SCRIPT BASE DE DATOS RELOJ.sql
```

A database backup is also included:

```text
Respaldo-DBRelojChecador.bak
```

The database stores the information required for employee management and attendance tracking.

## 🔄 System Workflow

The general workflow is:

```text
Start
  │
  ▼
Main Menu
  │
  ├───────────────┐
  ▼               ▼
Employees      Attendance
  │               │
  ▼               ▼
CRUD Operations  Register Check-in
  │               │
  └───────┬───────┘
          ▼
      SQL Server
          │
          ▼
    Query / History
```

## 💻 C# Version

The C# implementation was developed using **Windows Forms** and **.NET Framework 4.7.2**.

Main components include:

* Employee management forms
* Attendance registration form
* Database connection class
* Employee query class
* Attendance query class
* Windows Forms interface

### Main C# Forms

```text
Form1
├── FrmAgregarEmpleado
├── FrmBuscarEmpleado
├── FrmModificarEmpleado
├── FrmEliminarEmpleado
└── FrmRegistroChecada
```

## ☕ Java Version

The Java implementation was developed using **Java Swing** and NetBeans.

It provides functionality equivalent to the C# version.

### Main Java Components

```text
ChecadorPrincipal
├── FrmAgregarEmpleado
├── FrmBuscarEmpleado
├── FrmModificarEmpleado
├── FrmEliminarEmpleado
└── FrmRegistroChecada
```

The Java version uses JDBC to communicate with SQL Server.

## ⚙️ Requirements

### C# Version

* Windows
* Visual Studio
* .NET Framework 4.7.2
* Microsoft SQL Server

### Java Version

* Java JDK
* NetBeans or another Java IDE
* Microsoft SQL Server
* Microsoft JDBC Driver for SQL Server

## 🚀 Installation

### 1. Clone the repository

```bash
git clone https://github.com/YOUR_USERNAME/employee-attendance-management-system.git
```


## 🎯 Project Objectives

The main objective of this project was to develop a desktop application capable of managing employees and recording their attendance using a relational database.

The project also provided an opportunity to implement the same business requirements using two different programming languages and desktop GUI technologies.



## 👨‍💻 Author

**Rivaldo Méndez**

Information Technology Engineering Student

GitHub: [@RivaldoMc7](https://github.com/RivaldoMc7)

---

⭐ Desktop application focused on **employee management, attendance tracking, CRUD operations, SQL Server integration, Java, and C#**.
