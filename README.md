# ⏰ Employee Attendance Management System



## 📖 Overview



The **Employee Attendance Management System** is a desktop application designed to manage employee attendance records within an organization.



The system allows employees to register their daily check-ins using a unique employee ID and automatically tracks the different stages of a workday, including:



* 🏢 Workday start

* 🍽 Lunch break departure

* 🔙 Return from lunch

* 🚪 End of workday



Additionally, the system calculates attendance bonuses based on completed attendance cycles and stores all records in a \*\*Microsoft SQL Server\*\* database.



This project was developed as part of an **Object-Oriented Programming (OOP)** course and demonstrates the implementation of:



* Database connectivity

* Object-oriented design

* Desktop user interfaces

* CRUD operations

* SQL Server integration



---



## 🚀 Features



### 👨‍💼 Employee Management



* Register employees

* Update employee information

* Delete employee records

* Search employees by ID

* View employee information



### ⏱ Attendance Tracking



* Employee clock-in using an employee ID

* Automatic attendance registration

* Attendance history management

* Daily attendance tracking



### ✅ Workday Status Validation



The system automatically determines the employee status based on the number of attendance records registered during the day:



| Check-in Number | Status               |

| --------------- | -------------------- |

| 1               | Entering work        |

| 2               | Leaving for lunch    |

| 3               | Returning from lunch |

| 4               | Leaving work         |



### 🎁 Bonus System



After completing the fourth attendance registration of the day, the system:



* Removes temporary attendance records

* Registers a bonus record

* Stores bonus information in the database



---



## 🛠 Technologies Used



### Programming Languages



* Java 8

* C#



### Frameworks and Tools



* Apache NetBeans IDE

* Visual Studio

* Windows Forms



### Database



* Microsoft SQL Server



### Database Connectivity



* JDBC Driver for SQL Server

* ADO.NET (SqlConnection)



---



## 🗄 Database Structure



The system uses the following database tables:



### EMPLEADO



Stores employee information.



| Field            | Description      |

| ---------------- | ---------------- |

| ID_EMPLEADO_TE   | Employee ID      |

| NOMBRE           | First name       |

| APELLIDO_PATERNO | Last name        |

| APELLIDO_MATERNO | Second last name |

| EDAD             | Age              |

| SEXO             | Gender           |

| PUESTO           | Job position     |



---



### CHECADA



Stores employee attendance records.



| Field          | Description     |

| -------------- | --------------- |

| ID_EMPLEADO_TC | Employee ID     |

| HORA           | Attendance time |

| FECHA          | Attendance date |



---



### CHECADABONO



Stores employee bonus records.



| Field          | Description |

| -------------- | ----------- |

| ID_EMPLEADO_TB | Employee ID |

| FECHA          | Date        |

| BONO           | Bonus value |



---



### PUESTO



Stores employee job positions.



| Field         | Description   |

| ------------- | ------------- |

| ID_PUESTO     | Position ID   |

| NOMBRE_PUESTO | Position name |



---



## 🏗 Project Structure



```text

Reloj-Checador

│

├── C#-RelojChecador

│

├── ProyectoRelojChecador

│

├── Screenshots

│

├── README.md

│

├── Respaldo-DBRelojChecador

│

└── SCRIPT BASE DE DATOS RELOJ

```



---



## 🎯 Object-Oriented Programming Concepts Applied



This project implements several OOP principles:



### Encapsulation



Employee and attendance information are stored using classes with attributes and methods.



### Abstraction



Database operations are encapsulated inside query classes.



### Modularity



The application separates responsibilities into:



* Employee management

* Attendance management

* Database access

* User interface



### Reusability



Query classes and database connection classes are reused throughout the project.



---



## 📚 Learning Outcomes



Through this project I learned:



* Object-Oriented Programming principles

* SQL Server database design

* CRUD operations

* Desktop application development

* Database connectivity using JDBC and ADO.NET

* Event-driven programming

* User interface development

* Software architecture organization



---



## 📸 Screenshots



Include screenshots of:



* Main menu

* Employee registration form

* Attendance registration form

* Attendance history

* Database tables




## 🔮 Future Improvements



* User authentication

* Attendance reports

* PDF export functionality

* Monthly attendance statistics

* Employee schedules

* Role-based access control

* Web version of the application



---



## 👨‍💻 Author



**Rivaldo Méndez Carranza**



Information Technology Engineering Student



Benemérita Universidad Autónoma de Puebla (BUAP)



---



## 📄 License



This project is intended for educational and portfolio purposes.



