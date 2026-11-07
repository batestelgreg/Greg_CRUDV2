# Student Enrollment System (Greg_CRUDV2)

A **Student Enrollment System** — a practical project demonstrating full **CRUD (Create, Read, Update, Delete)** functionality for managing school records, built as a C# **Windows Forms** desktop application with **LINQ to SQL** as the data access layer and **SQL Server Express** as the database.

## Features

- **Main Dashboard** — centralized entry point to all modules
- **Students** — add, view, update, and delete student records
- **Courses** — manage course information
- **Sections** — manage class sections
- **Enrollment** — record and maintain student enrollments
- **Grades** — encode and manage student grades
- **Reports** — generate summary reports of student records

## Technologies Used

| Component     | Technology                          |
| ------------- | ------------------------------------ |
| Language      | C#                                   |
| Framework     | .NET Framework 4.8 (Windows Forms)   |
| Data Access   | LINQ to SQL (`Greg.dbml`)            |
| Database      | SQL Server Express (`Montebon` DB)   |
| IDE           | Visual Studio                        |

## Getting Started

### Prerequisites

- Visual Studio (with .NET desktop development workload)
- SQL Server Express installed locally (`.\\SQLEXPRESS`)

### Setup

1. Clone the repository:
   ```bash
   git clone <your-repo-url>
   ```
2. Open the solution file `Greg_CRUDV2.slnx` in Visual Studio.
3. Restore/attach the `Montebon` database to your local SQL Server Express instance.
4. If needed, update the connection string in `App.config`.
5. Build and run the project (**F5** or **Ctrl+F5**).

## Project Structure

```
Greg_CRUDV2/
├── MainForm.cs        → Main dashboard navigation
├── StudentForm.cs     → Student CRUD operations
├── CourseForm.cs      → Course CRUD operations
├── SectionForm.cs     → Section CRUD operations
├── EnrollmentForm.cs  → Enrollment CRUD operations
├── GradeForm.cs       → Grade CRUD operations
├── ReportForm.cs      → Report generation
├── Greg.dbml          → LINQ to SQL data model
└── App.config         → Database connection settings
```

---

## 📄 Submission Message

> **Submitted by:** Greg Anderson M. Batestel
> **Course / Subject:** Student Enrollment System
> **Section:** BSIT 3-B
> **Instructor:** Prof. Angelbert Maghanoy
> **Date Submitted:** November 05, 2026
>
> This repository serves as my submission for the practical assessment on
> **CRUD Operations**. It is a Windows Forms desktop application that performs
> Create, Read, Update, and Delete operations on a SQL Server database using
> LINQ to SQL, covering the management of students, courses, sections,
> enrollments, grades, and reports.
>
> All requirements for this practical have been implemented and tested.

---

*For any questions regarding this project, feel free to open an issue.*
