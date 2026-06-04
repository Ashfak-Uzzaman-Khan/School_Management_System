<h1 align="center">🏫 School Management System</h1>

<p align="center">
  A multi-role C# .NET desktop application for managing the complete academic and administrative operations of an educational institution — backed by a structured SQL Server relational database.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/C%23-.NET%20Framework%204.7.2-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/SQL%20Server-Database-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" />
  <img src="https://img.shields.io/badge/ADO.NET-Data%20Access-blue?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/IDE-Visual%20Studio-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white" />
</p>

---

## 📌 Project Overview

The **School Management System** is a role-based C# .NET desktop application designed to automate the core academic and administrative workflows of an educational institution. It provides a centralized digital platform where **Admins**, **Teachers**, and **Students** each interact through dedicated dashboards tailored to their roles and responsibilities.

The system replaces manual paper-based processes with a secure, data-driven interface that handles student and teacher management, course scheduling, attendance tracking, grading, assignment management, payment processing, leave requests, and teacher reviews — all backed by a structured relational database named **SchoolManagementDB**.

The application enforces strict business rules including **time-clash prevention** for course scheduling, **role-based access control**, **parameterized SQL queries** for injection prevention, and **automatic user identification** from login sessions to prevent unauthorized data access.

---

## ✨ Key Technical Highlights

- 🔐 **Role-based Authentication** — Single login routes Admin (Role 1), Teacher (Role 2), and Student (Role 3) to their respective dashboards automatically
- 🛡️ **SQL Injection Prevention** — All database operations use parameterized queries via ADO.NET (`SqlParameter[]`)
- 🏗️ **Centralized Data Access Layer** — `DataAccess.cs` wraps all SQL operations (`ExecuteQuery`, `ExecuteQueryTable`, `ExecuteDMLQuery`) with overloaded parameterized variants
- ⏰ **Time-Clash Detection** — Course scheduling and student registration both run conflict checks against existing schedules before committing
- 📊 **Auto-calculated Academics** — CGPA calculated from Grade table; attendance percentage computed from Attendance table in real-time
- 🔒 **Business Rule Enforcement** — Duplicate assignment submission prevention, unique teacher-per-course validation, department-wise student distribution
- 🧩 **Modular UserControl Architecture** — Each feature loaded dynamically into dashboard body panels, keeping UI clean and maintainable

---

## 👥 User Roles & Features

### 🔴 Admin
| Module | Capabilities |
|---|---|
| Dashboard | Live count of total Teachers, Students, Departments, and Courses |
| Teacher Manager | Add, Edit, Delete, Search, Filter by Status (Active / Inactive / Pending) |
| Student Manager | Add, Edit, Delete, Search, Filter by Status |
| Course Manager | Add, Edit, Delete, Search; time-clash prevention; view registered students per course |
| Department Manager | View departments; view students per department |
| Payment Manager | View all payment records; search by student name |
| Leave Request Manager | View, search, and update teacher leave request status (Approve / Decline / Pending) |
| Reviews Manager | View all teacher reviews and ratings; view average rating per teacher |
| Profile | View and edit own personal information |

### 🟡 Teacher
| Module | Capabilities |
|---|---|
| Dashboard | Personalized welcome + weekly teaching schedule (day, course, time) |
| Grade Manager | View, assign, and update student grades (A+ to F scale with grade points) |
| Attendance Manager | View, add, and update student attendance (Present / Absent / Late) |
| Assignment Manager | Create and delete assignments per course; search and view student submissions |
| Leave Request | Submit leave requests; view own request history with current status |
| Profile | View and edit personal contact information |

### 🟢 Student
| Module | Capabilities |
|---|---|
| Dashboard | Personalized welcome + weekly class schedule (day, course, time) |
| Course Registration | View available courses, search, and register; time-clash prevention |
| Results | View grades and auto-calculated CGPA per course |
| Attendance | View attendance records and overall attendance percentage |
| Payments | View course fees and payment status; complete payments per course |
| Assignment Submission | View all assignments for registered courses; submit answers; track submission status |
| Teacher Review | Search teachers, submit ratings (1–5) and review text; view own past reviews |
| Profile | View and edit personal contact information |

---

## 🛠️ Tech Stack

| Category | Technology |
|---|---|
| Language | C# |
| Framework | .NET Framework 4.7.2 |
| Database | Microsoft SQL Server (SQL Express) |
| Database Tool | SQL Server Management Studio (SSMS) |
| Data Access | ADO.NET (`System.Data.SqlClient`) |
| UI Framework | Windows Forms (.NET Desktop) |
| IDE | Visual Studio 2022 |

---

## 🗄️ Database Schema

The system uses **15 relational tables** inside `SchoolManagementDB`:

| # | Table | Description |
|---|---|---|
| 1 | `Roles` | Defines user roles (Admin, Teacher, Student) |
| 2 | `AuthenticationInfo` | Central login table — stores email, password, role, status |
| 3 | `AdminInfo` | Admin profile details linked to AuthenticationInfo |
| 4 | `Departments` | Academic department records |
| 5 | `TeacherInfo` | Teacher profile — experience, salary, gender, status |
| 6 | `StudentInfo` | Student profile — department, gender, status |
| 7 | `CourseInfo` | Course details — name, day, time, fee, assigned teacher |
| 8 | `StudentCourseRegistration` | Maps students to their registered courses |
| 9 | `Attendance` | Per-student, per-course daily attendance records |
| 10 | `Grade` | Student grades and grade points per course |
| 11 | `TeacherReview` | Student-submitted teacher ratings and review text |
| 12 | `TeacherLeaveRequest` | Teacher leave applications with admin-managed status |
| 13 | `PaymentInfo` | Course fee payment records per student |
| 14 | `Assignments` | Teacher-posted assignments with deadlines |
| 15 | `AssignmentSubmissions` | Student-submitted assignment answers with status |

---

## 🔁 Application Flow

```
Application Start
      │
      ▼
   Home Page
      │
      ├──► Teacher Application Form  →  Pending Approval by Admin
      ├──► Student Enrollment Form   →  Pending Approval by Admin
      └──► Login Page
                │
                ▼
        Email + Password Check
        (AuthenticationInfo table)
                │
        ┌───────┼───────────┐
        ▼       ▼           ▼
   Admin(1) Teacher(2) Student(3)
   Dashboard  Dashboard  Dashboard
        │       │           │
        ▼       ▼           ▼
  UserControls loaded dynamically
  into body panel on sidebar click
```

---

## 📁 Project Structure

```
SCHOOL MANAGEMENT SYSTEM/
│
├── Program.cs                          # Application entry point
├── Home.cs                             # Landing page
├── Login.cs                            # Authentication + role routing
├── Forgot_Reset_Pass.cs                # Password recovery
├── Apply.cs                            # Teacher application form
├── Enrollment.cs                       # Student enrollment form
├── DataAccess.cs                       # Centralized data access layer (ADO.NET)
│
├── AdminDashboard.cs                   # Admin main dashboard
├── TeacherDashboard.cs                 # Teacher main dashboard
├── StudentDashboard.cs                 # Student main dashboard
│
├── UC_TeacherManager.cs                # Admin: Manage teachers
├── UC_StudentManager.cs                # Admin: Manage students
├── UC_CourseManager.cs                 # Admin: Manage courses
├── UC_DepartmentManager.cs             # Admin: Manage departments
├── UC_AdminPayments.cs                 # Admin: View all payments
├── UC_AdminLeaveRequests.cs            # Admin: Manage leave requests
├── UC_AdminReviews.cs                  # Admin: View teacher reviews
├── UC_AdminProfile.cs                  # Admin: Profile settings
│
├── UC_TeacherGradeManager.cs           # Teacher: Assign/update grades
├── UC_TeacherAttendance.cs             # Teacher: Manage attendance
├── UC_TeacherAssignmentManager.cs      # Teacher: Post/manage assignments
├── UC_TeacherLeaveRequest.cs           # Teacher: Submit leave requests
├── UC_TeacherProfile.cs                # Teacher: Profile settings
│
├── UC_StudentCourseRegistration.cs     # Student: Register for courses
├── UC_StudentResults.cs                # Student: View grades + CGPA
├── UC_StudentAttendance.cs             # Student: View attendance %
├── UC_StudentPayments.cs               # Student: Pay course fees
├── UC_StudentAssignmentSubmission.cs   # Student: Submit assignments
├── UC_StudentTeacherReview.cs          # Student: Rate teachers
├── UC_StudentProfile.cs                # Student: Profile settings
│
└── App.config                          # App configuration
```

---

## ⚙️ Setup & Installation

### Prerequisites

- Windows OS
- [Visual Studio 2022](https://visualstudio.microsoft.com/) with **.NET desktop development** workload
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

---

### Step 1 — Restore the Database

Open **SSMS**, connect to your SQL Server instance, and run the project's SQL script to create and populate `SchoolManagementDB` with all 15 tables.

---

### Step 2 — Update the Connection String

Open `DataAccess.cs` and update the connection string to match your local SQL Server instance name:

```csharp
this.Sqlcon = new SqlConnection(
    @"Data Source=YOUR_SERVER_NAME\SQLEXPRESS;
      Initial Catalog=SchoolManagementDB;
      Integrated Security=True");
```

Replace `YOUR_SERVER_NAME` with your actual machine name. You can find it in SSMS under **Object Explorer → Server Name**.

---

### Step 3 — Build & Run

Open the solution file (`SCHOOL MANAGEMENT SYSTEM.slnx`) in Visual Studio, build the project (**Ctrl + Shift + B**), then run it (**F5**).

---

## 🔑 Demo Login Credentials

Use the following credentials to explore the system as each user role:

| User Email | Password |
|---|---|
|  |  |
|  |  |
|  |  |

> **Note:** Admin must set a Teacher or Student account status to **Active** before they can log in.

---

## 📸 Screenshots

> _Screenshots will be added soon._

<!-- 
### Common Pages
| Home | Login | Forgot Password |
|:---:|:---:|:---:|
| ![Home]() | ![Login]() | ![Forgot]() |

### Admin Panel
| Dashboard | Teacher Manager | Student Manager |
|:---:|:---:|:---:|
| ![Admin Dashboard]() | ![Teacher Manager]() | ![Student Manager]() |

| Course Manager | Department Manager | Payment Manager |
|:---:|:---:|:---:|
| ![Course Manager]() | ![Department Manager]() | ![Payment Manager]() |

| Leave Request Manager | Reviews Manager | Admin Profile |
|:---:|:---:|:---:|
| ![Leave Request]() | ![Reviews]() | ![Admin Profile]() |

### Teacher Panel
| Dashboard | Grade Manager | Attendance Manager |
|:---:|:---:|:---:|
| ![Teacher Dashboard]() | ![Grade Manager]() | ![Attendance]() |

| Assignment Manager | Leave Request | Teacher Profile |
|:---:|:---:|:---:|
| ![Assignment Manager]() | ![Leave Request]() | ![Teacher Profile]() |

### Student Panel
| Dashboard | Course Registration | Results |
|:---:|:---:|:---:|
| ![Student Dashboard]() | ![Course Registration]() | ![Results]() |

| Payments | Assignment Submission | Attendance |
|:---:|:---:|:---:|
| ![Payments]() | ![Assignments]() | ![Attendance]() |

| Teacher Review | Student Profile |
|:---:|:---:|
| ![Teacher Review]() | ![Student Profile]() |
-->

---

## ⚠️ Known Limitations

- Single-user desktop application — does not support concurrent multi-user access or remote availability
- Passwords are currently stored as plain text — should be upgraded to secure hashing (e.g. BCrypt) for production use
- No email notifications for leave approvals, assignment deadlines, or payment confirmations
- No cloud backup or real-time data synchronisation
- Teacher Research Budget Manager and Student Department Change modules are currently placeholders

---

## 🚀 Future Improvements

- [ ] Implement BCrypt password hashing for secure authentication
- [ ] Migrate to ASP.NET Core Web API + React for a web-based multi-user version
- [ ] Add email notification system for leave approvals and assignment deadlines
- [ ] Complete the Research Budget Manager and Department Change modules
- [ ] Add report export functionality (PDF / Excel) for grades and attendance
- [ ] Implement cloud database hosting for remote access

---

## 👤 Author

**Your Name**
- 💼 LinkedIn: [linkedin.com/in/your-profile](https://linkedin.com/in/your-profile)
- 📧 Email: your.email@example.com
- 🐙 GitHub: [@your-username](https://github.com/your-username)

---

<p align="center">
  If you found this project helpful, please consider giving it a ⭐ on GitHub!
</p>
