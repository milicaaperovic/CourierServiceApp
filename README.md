# Courier Service Desktop Application

A simple C# WinForms application created as part of university coursework and practice.  
This project simulates basic operations of a courier service, including parcel entry, login, and data storage.

---

## 🚀 Features

- Employee login system  
- Insert and manage parcels  
- Display list of parcels using `BindingList` + `DataGridView`  
- Select origin and destination via dropdown menus  
- Save single or multiple parcels to database  
- Transaction support for batch inserts  
- Multi-project solution (UI + Logic + Session/Broker)  
- SQL Server database connection  

---

## 🧱 Project Structure

- **Biblioteka** – business logic classes (`Posiljka`, `Mesto`, `Kurir`, `Sluzbenik`, etc.)  
- **KorisnickiInterfejs** – WinForms UI (Login, Main Form, Parcel Entry Form)  
- **Sesija** – Broker class for database communication  

---

## 🛠 Technologies Used

- C#  
- .NET  
- WinForms  
- SQL Server (LocalDB)  
- Visual Studio  

---

## ⚠️ Note

This application was created for learning purposes.  
Some database queries are simplified for practice (e.g., string concatenation instead of parameterized queries).  

---

## 🎯 Purpose

The goal of this project was to understand:

- Handling UI components  
- Connecting to a SQL database  
- Structuring a multi-project solution  
- Working with transactions  
- Implementing basic business logic  

---
