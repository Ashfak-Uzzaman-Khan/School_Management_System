
<p align="center">
  A multi-role C# .NET desktop application for managing the complete academic and administrative operations of an educational institution, backed by a structured SQL Server relational database.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/C%23-.NET%20Framework%20-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/SQL%20Server-Database-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" />
  <img src="https://img.shields.io/badge/ADO.NET-Data%20Access-blue?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/IDE-Visual%20Studio-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white" />
</p>

---

## 📌 Project Overview

The **School Management System** is a role-based C# .NET desktop application build using WinForms technology and designed to automate the core academic and administrative workflows of an educational institution. It provides a centralized digital platform where **Admins**, **Teachers**, and **Students** each interact through dedicated dashboards tailored to their roles and responsibilities.

The system provides a secure, data-driven interface that handles student and teacher management, course scheduling, attendance tracking, grading, assignment management, payment processing, leave requests, and teacher reviews and all backed by a structured relational database named **SchoolManagementDB**.

The application enforces strict business rules including **time-clash prevention** for course scheduling, **role-based access control**, **parameterized SQL queries** for injection prevention, and **automatic user identification** from login sessions to prevent unauthorized data access.

---

## ✨ Key Technical Highlights

- 🔐 **Role-based Authentication** : Single login routes Admin (Role 1), Teacher (Role 2), and Student (Role 3) to their respective dashboards automatically
- 🛡️ **SQL Injection Prevention** : All database operations use parameterized queries via ADO.NET (`SqlParameter[]`)
- 🏗️ **Centralized Data Access Layer** : `DataAccess.cs` wraps all SQL operations (`ExecuteQuery`, `ExecuteQueryTable`, `ExecuteDMLQuery`) with overloaded parameterized variants
- ⏰ **Time-Clash Detection** : Course scheduling and student registration both run conflict checks against existing schedules before committing
- 📊 **Auto-calculated Academics** : CGPA calculated from Grade table; attendance percentage computed from Attendance table in real-time
- 🔒 **Business Rule Enforcement** : Proper assignments handeling procedures, unique teacher-per-course validation, department-wise student profile orientation
- 🧩 **Modular UserControl Architecture** : Each feature loaded dynamically into dashboard body panels, keeping UI clean and maintainable

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
| Framework | .NET Framework  |
| Database | Microsoft SQL Server (SQL Express) |
| Database Tool | SQL Server Management Studio (SSMS) |
| Data Access | ADO.NET (`System.Data.SqlClient`) |
| UI Framework | Windows Forms (.NET Desktop) |

---

## 🗄️ Database Schema

The system uses **15 relational tables** inside `SchoolManagementDB`:

| # | Table | Description |
|---|---|---|
| 1 | `Roles` | Defines user roles (Admin, Teacher, Student) |
| 2 | `AuthenticationInfo` | Central login table - stores email, password, role, status |
| 3 | `AdminInfo` | Admin profile details linked to AuthenticationInfo |
| 4 | `Departments` | Academic department records |
| 5 | `TeacherInfo` | Teacher profile - experience, salary, gender, status |
| 6 | `StudentInfo` | Student profile - department, gender, status |
| 7 | `CourseInfo` | Course details - name, day, time, fee, assigned teacher |
| 8 | `StudentCourseRegistration` | Maps students to their registered courses |
| 9 | `Attendance` | Per-student, per-course daily attendance records |
| 10 | `Grade` | Student grades and grade points per course |
| 11 | `TeacherReview` | Student-submitted teacher ratings and review text |
| 12 | `TeacherLeaveRequest` | Teacher leave applications with admin-managed status |
| 13 | `PaymentInfo` | Course fee payment records per student |
| 14 | `Assignments` | Teacher-posted assignments with deadlines |
| 15 | `AssignmentSubmissions` | Student-submitted assignment answers |

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

---

## ⚙️ Setup & Installation

### Prerequisites

- Windows OS
- [Visual Studio 2022](https://visualstudio.microsoft.com/) with **.NET desktop development** workload
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

---

### Step 1 : Restore the Database

Open **SSMS**, connect to your SQL Server instance, and use the database file provided in the Database folder names as  `SchoolManagementDB.bacpac` with all 15 tables.

---

### Step 2 : Update the Connection String

Open `DataAccess.cs` and update the connection string to match your local SQL Server instance name:

```csharp
this.Sqlcon = new SqlConnection(
    @"Data Source=YOUR_SERVER_NAME\SQLEXPRESS;
      Initial Catalog=SchoolManagementDB;
      Integrated Security=True");
```

Replace `YOUR_SERVER_NAME` with your actual machine name. You can find it in SSMS under **Object Explorer → Server Name**.

---

### Step 3 : Build & Run

Open the solution file (`SCHOOL MANAGEMENT SYSTEM.slnx`) in Visual Studio, build the project (**Ctrl + Shift + B**), then run it (**F5**).

---

## 🔑 Demo Login Credentials

Use the following credentials to explore the system as each user role:

| User Email | Password |
|---|---|
| ashfak.admin@school.com | admin_123 |
| nadia.teacher@school.com | nadia_123 |
| mitu.student@school.com | mitu_123 |

> **Note:** Admin must set a Teacher or Student account status to **Active** before they can log in.

---



## 📸 Use-case Diagram 

> _Use case diagram of the project._
<img width="752" height="720" alt="image004" src="https://github.com/user-attachments/assets/c66193d2-84dc-4568-acc7-a9fd408f0ea2" />


## 📸 ER Diagram 

> _ER diagram of the project._
<img width="1897" height="877" alt="ER" src="https://github.com/user-attachments/assets/d26205f5-494b-4f75-9fb7-84850ec99fc8" />


## 📸 Screenshots 

> _Screen shots of the project pages._
### 👤 Common Pages

| **Home** | **Log In** | **Forgot Password & Reset** |
|:---:|:---:|:---:|
| <img width="400" alt="home" src="https://github.com/user-attachments/assets/a60206fe-529d-47d2-9276-ec4d135e313c" /> | <img width="400" alt="login" src="https://github.com/user-attachments/assets/d1578424-f9f3-4f80-b061-2e1e51064b45" /> | <img width="400" alt="forgot-password" src="https://github.com/user-attachments/assets/8ad6ad46-fde4-49f8-bb47-946359e134c9" /> |


| **Teacher Application** | **Student Enrollment** |
|:---:|:---:|
| <img width="400" alt="teacher-application" src="https://github.com/user-attachments/assets/9853d1fe-cad2-4d3a-bbf1-4cecf8d82cd3" /> | <img width="400" alt="student-enrollment" src="https://github.com/user-attachments/assets/1a45dbf4-9452-46dc-a6a2-3dd6c377f0d7" /> |


---

### 🛡️ Admin Panel

| **Dashboard** | **Course Manager** | **Teacher Manager** |
|:---:|:---:|:---:|
| <img width="400" alt="admin-dashboard" src="https://github.com/user-attachments/assets/e59e6f63-caff-4b13-83f6-737816ff7baa" /> | <img width="400" alt="admin-course-manager" src="https://github.com/user-attachments/assets/2bc55e0d-5109-4440-8996-4ad14dafab83" /> | <img width="400" alt="admin-teacher-manager" src="https://github.com/user-attachments/assets/86d62ed2-15cf-4a74-8cf2-83b12ef29bc1" /> |


| **Student Manager** | **Payment Manager** | **Department Manager** |
|:---:|:---:|:---:|
| <img width="400" alt="admin-student-manager" src="https://github.com/user-attachments/assets/b9c67ac2-5ec5-49c9-9d00-a7477963349c" /> | <img width="400" alt="admin-payment-manager" src="https://github.com/user-attachments/assets/60611a89-922c-4e3a-b598-5fcfc46a03d0" /> | <img width="400" alt="admin-department-manager" src="https://github.com/user-attachments/assets/342e6a6c-2332-4b43-8862-b89b22399b3b" /> |


| **Teacher Review Manager** | **Leave Request Manager** |
|:---:|:---:|
| <img width="400" alt="admin-review-manager" src="https://github.com/user-attachments/assets/dc51d490-1ab1-44f3-9047-b3143982d5e9" /> | <img width="400" alt="admin-leave-request" src="https://github.com/user-attachments/assets/4c94299a-c554-4e2a-be9c-3017a6f6feef" /> |


---

### 👨‍🏫 Teacher Panel

| **Dashboard** | **Attendance Manager** | **Grade Manager** |
|:---:|:---:|:---:|
| <img width="400" alt="teacher-dashboard" src="https://github.com/user-attachments/assets/777d73e9-564a-454f-b422-f9ccc5a0a72f" /> | <img width="400" alt="teacher-attendance" src="https://github.com/user-attachments/assets/7bba2fa5-db83-4b50-ac6e-acbf4f6af956" /> | <img width="400" alt="teacher-grade-manager" src="https://github.com/user-attachments/assets/24457a30-77ef-4e99-96f4-7fd90ed1b2e7" /> |


| **Assignment Manager** | **Leave Request** | **Profile Settings** |
|:---:|:---:|:---:|
| <img width="400" alt="teacher-assignment-manager" src="https://github.com/user-attachments/assets/6c8afb58-454e-4afe-a0f2-eafdcb132154" /> | <img width="400" alt="teacher-leave-request" src="https://github.com/user-attachments/assets/3e44ad89-12e5-42af-9a53-66d272fc72d6" /> | <img width="400" alt="teacher-profile" src="https://github.com/user-attachments/assets/b8b3c71a-3077-4c49-af87-aafcb46a989f" /> |


---

### 👨‍🎓 Student Panel

| **Dashboard** | **Course Registration** | **Result View** |
|:---:|:---:|:---:|
| <img width="400" alt="student-dashboard" src="https://github.com/user-attachments/assets/0f27774c-bb8d-4f8d-a9cb-3645dff504b9" /> | <img width="400" alt="student-course-registration" src="https://github.com/user-attachments/assets/420453dc-f01e-43dc-86da-672505a4ce98" /> | <img width="400" alt="student-result" src="https://github.com/user-attachments/assets/b323f799-a8c9-4851-ac07-725f97b3b706" /> |
| **Dashboard** | **Course Registration** | **Result View** |

| **Payment Manager** | **Assignment Submission** | **Attendance View** |
|:---:|:---:|:---:|
| <img width="400" alt="student-payment" src="https://github.com/user-attachments/assets/e283a562-7532-48e8-b3b9-a0cd303536bd" /> | <img width="400" alt="student-assignment" src="https://github.com/user-attachments/assets/bf6dc118-784a-4ac1-9bb4-fc26d23cdb60" /> | <img width="400" alt="student-attendance" src="https://github.com/user-attachments/assets/19700890-0429-4ab9-b493-47ef0ece7234" /> |


| **Teacher Review** | **Profile Settings** |
|:---:|:---:|
| <img width="400" alt="student-teacher-review" src="https://github.com/user-attachments/assets/f41a73c3-8cdd-4385-a7a9-7bb04ee1edf9" /> | <img width="400" alt="student-profile" src="https://github.com/user-attachments/assets/d8ebbdf7-9f75-4e47-a650-87498dc28485" /> |


---



