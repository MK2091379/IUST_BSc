# Advanced Programming

A comprehensive collection of coursework, assignments, practical quizzes, projects, and examination solutions developed for the **Advanced Programming** course. This repository covers foundational to advanced **C#** and **.NET** paradigms, including Object-Oriented Programming (OOP) design, custom mathematical engines, operator overloading, event-driven architectures, and Desktop GUI development.

---

## 🛠 Tech Stack

- **Language:** C#
- **Frameworks & Runtimes:** .NET (.NET Core / .NET Framework)
- **GUI:** Windows Presentation Foundation (WPF), XAML
- **Development Environment:** Visual Studio / VS Code, .NET CLI

---

## 📁 Repository Structure

### 📚 Homework & Assignments
| Directory | Focus & Core Concepts | Primary Files |
| :--- | :--- | :--- |
| `HW1/` | Basic C# syntax, data types, console I/O, arithmetic operations | `Q1.cs` – `Q4.cs` |
| `HW2/` | Control flow, conditional branching, loops, basic array processing | `Q1.cs` – `Q5.cs` |
| `HW3/` | OOP fundamentals: class design, methods, constructors, encapsulation | `Q1.cs` – `Q4.cs` |
| `HW4/` | Algorithmic logic and multi-dimensional array manipulation | `Q1.cs` – `Q5.cs` |
| `HW5/` | OOP patterns: inheritance, polymorphism, abstract classes, interfaces | `Q1.cs` – `Q3.cs` |
| `HW6/BookStoreDevelopment/` | Architecture & implementation of a bookstore management system | `.csproj` Project |
| `HW7/MatrixAndVector_update/` | Custom mathematical engine with Vector/Matrix operator overloading | `.csproj` Project |
| `HW8/` | Advanced C# features: delegates, events, lambda expressions, collections | `Q1.cs` – `Q3.cs` |

### 📝 Quizzes & Examinations
| Directory | Focus & Description | Primary Files |
| :--- | :--- | :--- |
| `Quiz3/` | Practical evaluation covering intermediate C# constructs | `Program.cs` |
| `Quiz4/` | Practical evaluation on algorithm implementation and logic design | `Program.cs` |
| `Final Exam/` | Comprehensive practical exam covering core algorithms and OOP paradigms | `Q1.cs` – `Q5.cs` |

### 🖥 Projects
| Directory | Focus & Description | Tech |
| :--- | :--- | :--- |
| `P-P1/WPF/` | Multi-window desktop application with interactive UI workflows | WPF, XAML, C# |

---

## 🚀 Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0+ recommended)
- [Visual Studio](https://visualstudio.microsoft.com/) (with *.NET desktop development* workload) or [VS Code](https://code.visualstudio.com/) with the C# Dev Kit extension.

---

### Running the Code

#### 1. Standalone C# Files (`HW1`–`HW5`, `Final Exam`)
Compile and run standalone `.cs` files using the C# compiler (`csc`):

```bash
# Compile the file
csc <FilePath>.cs

# Run the compiled executable (Windows)
./<FileName>.exe
```

#### 2. .NET Console Projects (`HW6`, `HW7`, Quizzes)
Run project-based modules using the .NET CLI:

```bash
# Build the project
dotnet build <PathToProject>/<ProjectName>.csproj

# Run the project
dotnet run --project <PathToProject>/<ProjectName>.csproj
```

#### 3. WPF Desktop Application (`P-P1/WPF`)
> **Note:** WPF applications require a Windows operating system.

```bash
# Build and execute via .NET CLI
dotnet run --project P-P1/WPF/<ProjectName>.csproj
```
*Alternatively, open the solution/project (`.sln` / `.csproj`) in Visual Studio and press `F5`.*

---

## 📜 Academic Disclaimer
The source code in this repository is maintained for portfolio, archival, and educational reference purposes.