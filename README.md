# 🏨 Hostel Room Allotment Windows Form Application

A **modern Windows Forms app** for seamless hostel room management — enquiry, booking, payment, and vacating, all integrated with a SQL database for real-time updates!  
<br>
<p align="center">
  <img src="https://img.shields.io/badge/Platform-Windows-blue?logo=windows" alt="Platform" />
  <img src="https://img.shields.io/badge/Language-C%23-239120?logo=csharp" alt="C#" />
  <img src="https://img.shields.io/badge/Database-SQL%20Server-CC2927?logo=microsoftsqlserver" alt="SQL Server" />
  <img src="https://img.shields.io/badge/Status-Active-brightgreen" alt="Active" />
</p>

---

## ✨ Features

- 🛏️ **Vacant Room Enquiry** — Instantly check which rooms are available.
- 📝 **Room Booking** — User-friendly booking with payment integration.
- 💸 **Payment Handling** — Securely record and display payments.
- 📑 **Allotment Letter** — Instant digital confirmation for each booking.
- 🚪 **Vacate Room** — Simple process to vacate and update room status.
- 🗃️ **Database-Driven** — All actions reflect in a persistent SQL backend.

---

## 🗺️ Application Flow

1. **🏠 Main Menu:**  
   &nbsp;&nbsp;&nbsp;Navigate to Room Enquiry or Vacate Room.

2. **🔍 Enquiry:**  
   &nbsp;&nbsp;&nbsp;View all vacant rooms. Jump to booking if you find your match!

3. **🛎️ Room Allotment:**  
   &nbsp;&nbsp;&nbsp;Enter details, pay, and get your instant allotment letter.

4. **🚶 Vacate:**  
   &nbsp;&nbsp;&nbsp;Moving out? Vacate your room with a click.

---

## 🏗️ System Architecture

- **Frontend:** Windows Forms (.NET, C#)
- **Backend:** SQL Server (connection via `System.Data.SqlClient`)
- **Major Forms:**
  - `Form1` — Main menu & navigation
  - `Enquiry` — List available rooms
  - `roomAllotment` — Book and pay for a room
  - `vacate` — Vacate a room
  - `AllotmentDetails` — (for future extensibility)

---

## 🗄️ Database Schema (Overview)

> **You must create these tables in your SQL Server database before running the app.**

| Table   | Columns                                                                      |
| ------- | ---------------------------------------------------------------------------- |
| Room    | `room_no` (INT, PK), `floor` (INT), `status` (VARCHAR: 'vacant'/'alloted')   |
| Payment | `room_no` (INT), `amount` (INT), `student_name` (VARCHAR)                    |

**Tip:** Update connection strings in the code:
```csharp
conn = new SqlConnection("your_connection_string");
```

---

## 🚀 Getting Started

1. **Clone the repo**
    ```sh
    git clone https://github.com/18Tharun/Hostel-Room-Allotment-Windows-Form-Application.git
    ```
2. **Open in Visual Studio** and restore dependencies.
3. **Create the database** and tables as listed above.
4. **Set your SQL connection string** in each relevant form (`roomAllotment.cs`, `Enquiry.cs`, `vacate.cs`).
5. **Build and Run!**

---

## 🛠️ Usage

- **Room Enquiry:**  
  _Click "Room Enquiry", check availability, and proceed to book._
- **Booking:**  
  _Select a vacant room, enter your details, pay, and get your allotment letter._
- **Vacating:**  
  _Enter your room number and vacate with one click!_

---

## 👤 Contributor

<table>
  <tr>
    <td align="center">
      <a href="https://github.com/18Tharun">
        <img src="https://avatars.githubusercontent.com/18Tharun?v=4" width="80" style="border-radius:50%"><br>
        <sub><b>Tharun</b></sub>
      </a>
      <br>
      <a href="https://github.com/18Tharun" title="Author">💻</a>
    </td>
  </tr>
</table>

---


---

## 📄 License

MIT License — _Free to use, share, and modify!_

---

> _Made with ❤️ by [Tharun](https://github.com/18Tharun)_
