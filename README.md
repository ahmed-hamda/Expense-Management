# 📊 Expense Management Systems

## 🧾 Project Overview

**Expense Management Systems** is a desktop application developed using **C# WinForms** and **SQL Server**, designed to help users efficiently manage their **expenses**, **incomes**, and **categories**, while providing **KPI dashboards** and graphical insights.

The system ensures **data isolation per user** and follows a clean relational database design with **One-To-Many relationships**.

---

## 🎯 Project Objectives

- Develop a professional desktop financial management application
- Apply core software engineering concepts:
  - CRUD operations
  - Relational database modeling
  - One-To-Many associations
- Implement a clear separation between:
  - UI layer
  - Data access layer
  - Database initialization
- Provide statistical visualization to support decision-making

---

## 🛠️ Technologies & Tools

- Programming Language: **C#**
- Framework: **.NET WinForms**
- Database: **Microsoft SQL Server**
- IDE: **Visual Studio**
- Version Control: **Git & GitHub**

---

## ✨ Main Features

### 👤 User Management
- User registration
- Secure authentication
- Personal data isolation per user

### 📁 Category Management
- Create, update, and delete categories
- Category type: *Income* or *Expense*
- Category status management

### 💰 Income Management
- Add and manage income records
- Category association
- Date-based tracking

### 💸 Expense Management
- Add and manage expense records
- Category association
- Date-based tracking

### 📈 Dashboard & KPIs
- Daily and monthly financial summaries
- Income vs Expense comparison
- Bar charts and line charts
- KPI visualization for financial analysis

---

## 🗄️ Database Design

**Tables:**
- `tblUsers`
- `tblCategories`
- `tblIncomes`
- `tblExpenses`

**Relationships:**
- User **1..*** Categories
- Category **1..*** Incomes
- Category **1..*** Expenses

---

## ▶️ Installation & Execution

1. Clone the repository:
```bash
git clone https://github.com/ahmed-hamda/Expense-Management.git
