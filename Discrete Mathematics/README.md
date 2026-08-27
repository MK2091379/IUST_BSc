# Discrete Mathematics

A collection of algorithmic implementations, recurrence models, and computational problem-solving suites developed for the **Discrete Mathematics** course. This repository explores recursive algorithm design, divide-and-conquer paradigms (Tower of Hanoi), propositional logic and set theory, combinatorial generation (permutations and combinations), graph reachability, and binary relation properties implemented across **C** and **C#**.

---

## 🛠 Tech Stack

- **Languages:** C (C99/C11), C# (.NET Core)
- **Compilers & Toolchains:** GCC / Clang, Roslyn (`csc`), .NET CLI / SDK
- **Core Mathematical Paradigms:** Recursion & Recurrence Relations, Combinatorics & Permutations, Graph Theory & Path Verification, Equivalence & Order Relations, Propositional Logic & Set Operations

---

## 📁 Repository Structure

### 📚 Coursework & Problem Sets
| Directory | Focus & Mathematical Concepts | Primary Files |
| :--- | :--- | :--- |
| `P-HW1/` | Recursive divide-and-conquer (Tower of Hanoi) and combinatorial algorithms | `Hanoi.c`, `.csproj` Project |
| `P-HW2/` | Applied discrete structures: permutation generators, graph path verification, relation closures | `Q1.cs`, `Q2.cs`, `Q3.cs` |

---

## 🚀 Getting Started

### Prerequisites
Ensure your environment has a standard C toolchain and the .NET SDK installed:

```bash
# Ubuntu / Debian
sudo apt update
sudo apt install -y build-essential dotnet-sdk-6.0
```

---

## 🧪 Compilation & Execution Guide

### 1. C Implementations (`P-HW1`)

Compile and execute the recursive Tower of Hanoi implementation using GCC:

```bash
cd "P-HW1"

# Compile with optimization
gcc -O2 Hanoi.c -o Hanoi

# Run the executable
./Hanoi
```

---

### 2. C# Projects via .NET CLI (`P-HW1`)

Execute project-based modules using the .NET SDK:

```bash
cd "P-HW1"

# Build and run the project
dotnet run
```

---

### 3. Standalone C# Scripts (`P-HW2`)

#### Option A: Direct Compilation with Roslyn (`csc`)
```bash
cd "P-HW2"

# Compile and run Q1 (Permutations & Combinations)
csc Q1.cs && ./Q1.exe

# Compile and run Q2 (Graph Path Verification)
csc Q2.cs && ./Q2.exe

# Compile and run Q3 (Relation Closures & Properties)
csc Q3.cs && ./Q3.exe
```

#### Option B: Running via .NET CLI
```bash
cd "P-HW2"

# Execute if structured within a console project
dotnet run
```

---

## 📜 Academic Disclaimer
The source code in this repository is maintained for portfolio, archival, and educational reference purposes.