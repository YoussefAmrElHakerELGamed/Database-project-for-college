# 📚 Library Management System

A full-featured database project for managing a library system.  
Built using **SQL** for the schema, data handling, and ERD design, and a **C# .NET** desktop application to provide a clean CRUD interface for managing books, members, loans, and staff.

---

## 🧰 Technologies Used

| Layer         | Technology        |
|---------------|-------------------|
| Database       | SQL (MySQL / MSSQL) |
| Data Modeling  | ERD, Normalization (3NF) |
| Application    | C# .NET Framework |
| GUI Toolkit    | WinForms / WPF (based on implementation) |

---

## ✨ Features

- 🗃️ **Relational database schema** designed for scalability and integrity
- 🔍 **Search** for books, members, and borrowing records
- 📥 **Add / Edit / Delete** books and members
- 📚 **Track borrowed and returned books**
- 🧑‍💼 Admin panel for managing categories and staff
- 📈 Designed with **ERD and normalization** principles
- 💾 Database built with primary keys, foreign keys, constraints, and indexes

---

## 🧠 ERD & Schema

> ✅ Database schema is normalized to 3NF  
> ✅ ERD includes relationships between:  
- Books  
- Members  
- Borrowing Records  
- Categories  
- Staff

📌 Diagrams and `.sql` scripts included in `/database/` folder

## 🧗 Challenges & Solutions

| Challenge | Solution |
|----------|----------|
| ⚠️ Normalizing large data sets | Applied 3NF and split data into proper tables |
| ⚠️ Connecting SQL to C# UI | Used ADO.NET with parameterized queries |
| ⚠️ Preventing SQL Injection | Used secure query methods and validations |
| ⚠️ Handling empty/null inputs | Added validation in C# forms and database constraints |

---

## 🏁 How to Run the Project

### 🛠 Database Setup
1. Open the `.sql` file from the `/database` folder
2. Run it in your SQL environment (MySQL or SQL Server)
3. Verify tables and relationships are created

### 💻 Application Setup
1. Open the `.sln` file in Visual Studio
2. Update the connection string in `App.config` or `Database.cs`
3. Build and run the project

---

## 📄 License

MIT License — For educational purposes.

---

## 🙌 Acknowledgements

- Built as part of a college-level database systems project
- Special thanks to faculty for feedback and guidance

