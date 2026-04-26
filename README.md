# Mentor.NET 🎓✨

<p align="center">
  <img src="https://readme-typing-svg.herokuapp.com?font=Fira+Code&size=24&pause=1000&color=1A9C5F&center=true&vCenter=true&width=700&lines=ASP.NET+Core+MVC+Learning+Platform;Entity+Framework+Core+%2B+SQL+Server;Clean+Mini+Project+for+Practice+and+Growth" alt="Typing animation" />
</p>

<p align="center">
  <img src="https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET 10" />
  <img src="https://img.shields.io/badge/ASP.NET_Core-MVC-0D6EFD?style=for-the-badge&logo=aspdotnet&logoColor=white" alt="ASP.NET Core MVC" />
  <img src="https://img.shields.io/badge/EF_Core-SQL_Server-198754?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" alt="EF Core SQL Server" />
  <img src="https://img.shields.io/badge/Status-Active-success?style=for-the-badge" alt="Status" />
</p>

---

## 🚀 About The Project

**Mentor.NET** is a mini educational web project built with **ASP.NET Core MVC**.
It renders a modern landing page and dynamically displays mentor/expert cards from a SQL Server database via **Entity Framework Core**.

This project is great for practicing:
- 🧠 MVC architecture basics
- 🗄️ EF Core + SQL Server integration
- 🎨 Razor Views with reusable UI sections
- ⚡ Frontend animation libraries (AOS, Swiper, PureCounter, Glightbox)

---

## 🛠️ Tech Stack

- **Backend:** C#, ASP.NET Core MVC (.NET 10)
- **Database:** SQL Server LocalDB
- **ORM:** Entity Framework Core 10
- **Frontend:** Razor Views, Bootstrap, AOS animations, Swiper, PureCounter, Glightbox

---

## 📂 Project Structure

```text
Mentor.NET/
├── Controllers/
│   └── HomeController.cs
├── Models/
│   ├── Expert.cs
│   └── Data/AppDbContext.cs
├── ViewModels/
│   └── ExpertVm.cs
├── Views/
│   ├── Home/Index.cshtml
│   └── Shared/_Layout.cshtml
├── Migrations/
├── wwwroot/
│   └── assets/
└── Program.cs
```

---

## ⚙️ Getting Started

### 1. Clone repository
```bash
git clone <your-repo-url>
cd Mentor.NET
```

### 2. Update database connection (optional)
Default connection string is in `Mentor.NET/appsettings.json`:

```json
"Default": "Server=(localdb)\\MSSQLLocalDB;Database=MentorDB;Trusted_Connection=True;TrustServerCertificate=True"
```

### 3. Apply migrations
```bash
cd Mentor.NET
dotnet ef database update
```

### 4. Run the app
```bash
dotnet run
```

Open in browser:
- `https://localhost:xxxx`
- or `http://localhost:xxxx`

---

## 🧩 Current Features

- ✅ Home page with modern education-style layout
- ✅ Dynamic expert/trainer list loaded from DB
- ✅ MVC separation (Controller + ViewModel + View)
- ✅ EF Core migration included (`InitialCreate`)
- ✅ Responsive UI with frontend motion effects

---

## 🌱 Next Ideas

- Add CRUD for experts (Admin panel) 🛠️
- Add validation and DTO mapping ✅
- Add repository/service layer architecture 🧱
- Add authentication and role-based access 🔐
- Dockerize the app 🐳

---

## 💡 Notes

- Table/entity currently uses the `Decription` property name (typo kept as-is from source model).
- On startup, `EnsureCreated()` is called in `Program.cs`.

---

<p align="center">
  <img src="https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExcTB0aXU4N3Y4M3N4enY4dDJldzMzcGY4a2M4a2hzMWJ3MHRra3ZiNSZlcD12MV9naWZzX3NlYXJjaCZjdD1n/26ufdipQqU2lhNA4g/giphy.gif" width="240" alt="coding animation" />
</p>

<p align="center"><b>Built with focus, curiosity, and clean practice 💚</b></p>
