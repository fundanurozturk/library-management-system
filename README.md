# Library Management System – Windows Forms Application

This project is a **Library Management System** developed as a **Windows Forms Application** using **C#**.  
It was created as a course project and includes user authentication and basic library-related operations.

---

## Technologies Used

- **C#**
- **Windows Forms (.NET Framework)**
- **Visual Studio**
- **Oracle Database**

---

## Project Structure

```
projeödevi/
│
├── WindowsFormOdev/
│   ├── Resources/              # Images and UI resources
│   ├── tumkodlar.cs            # Main source code
│   ├── WindowsFormOdev.csproj  # Project configuration
│   └── WindowsFormOdev.exe     # Compiled executable
│
├── WindowsFormOdevKutuphane.sln # Visual Studio solution file
└── README.md
```

---

## Requirements

Before running the project, make sure the following are installed on your system:

- **Windows OS**
- **Visual Studio 2019 or later**
- **.NET Framework** (compatible with Windows Forms)
- **Oracle Database**
- **Oracle Data Provider for .NET (ODP.NET)**

---

## Installation & Setup

### Clone or Download the Project

```bash
git clone https://github.com/your-username/library-management-system.git
```

Or download the ZIP file and extract it.

---

### Open the Project in Visual Studio

1. Open **Visual Studio**
2. Click **File → Open → Project/Solution**
3. Select:
```
WindowsFormOdevKutuphane.sln
```

---

### Database Configuration (Oracle)

1. Ensure **Oracle Database** is running
2. Create the required tables using the provided `.sql` scripts
3. Update the connection string in the project:

```csharp
Data Source=YOUR_DB;
User Id=YOUR_USERNAME;
Password=YOUR_PASSWORD;
```

---

### Build the Project

- Click **Build → Build Solution**
- Ensure there are no errors

---

### Run the Application

- Press **F5** or click **Start**
- Login screen will appear
- Use database users to log in

---

## Run Executable Directly

1. Navigate to:
```
WindowsFormOdev/WindowsFormOdev.exe
```
2. Double-click the file
3. Ensure Oracle Database is running

---

## Features

- User authentication
- Library interface
- Database-backed operations
- Resource-based UI

---

## Notes

- Educational project
- Database must be properly configured
- UI language: English
- Project structure should not be modified

---

## Author

**Fundanur Öztürk**  
Computer Engineering Student  
Course Project – Library Management System

---

## License

This project is created for academic use only.
