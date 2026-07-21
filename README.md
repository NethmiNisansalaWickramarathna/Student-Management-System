# 🎓 Student Registration & Academic Performance Management System (SMS)

> **Coursework Project:** ITE 1942 – ICT Project (Level 01)  
> **Institution:** Faculty of Information Technology, University of Moratuwa  
> **Student Name:** Wickramarathna G.W.N.Nisansala  
> **Index Number:** E2410027  

---

## 📌 Project Overview
A robust, lightweight, and offline-first desktop application engineered using **C# Windows Forms** and an embedded **SQLite** relational database (`SMS.db`). Designed specifically for departmental registries, the system provides local administrative tools to register student profiles, enforce dynamic security via Role-Based Access Control (RBAC), and automatically evaluate academic Performance Point Averages (GPA).

---

## 🌟 Key Functional Features

* **🔐 Role-Based Access Control (RBAC):**
  * **Admin Role:** Full CRUD privileges (Create, Read, Update, Delete student records and grade analytics).
  * **Staff Role:** Operational access for entry and edits; destructive paths (Delete actions) are programmatically disabled and visually locked.
* **📊 Automated Academic GPA Analytics:**
  * Real-time calculation engine that maps subject scores (Business Studies, Economics, ICT) to standard GPA scales and records overall aggregate GPAs automatically.
* **⚡ Dynamic Keypress Search Filtering:**
  * Real-time in-memory lookup over active `DataView` collections, completely bypassing disk I/O lag and sanitizing inputs to prevent SQL injection crashes.
* **💾 Serverless Embedded Relational Storage:**
  * Transactional SQLite database engine operating offline in the local directory without requiring external database server installations.

---

## 🛠️ Tech Stack & Prerequisites

* **Language:** C# (.NET Framework)
* **UI Framework:** Windows Forms (WinForms)
* **Database Engine:** SQLite (`System.Data.SQLite`)
* **Development Environment:** Visual Studio 2019 / 2022

---

## 🚀 Getting Started

### 1. Clone the Repository
```bash
git clone [https://github.com/NethmiNisansala/Student-Management-System.git](https://github.com/NethmiNisansala/Student-Management-System.git)
