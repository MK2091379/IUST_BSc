# Data Structures and Algorithms

A comprehensive repository of foundational and advanced Data Structures and Algorithms implementations developed across **Python**, **C++**, and **C# (.NET Core)**. This repository covers abstract data types (ADTs), trees, heaps, disjoint sets, graph algorithms, asymptotic complexity analysis, advanced sorting techniques (such as Dual-Pivot Quicksort), and practical applications including Huffman lossless data compression.

---

## 🛠 Tech Stack

- **Languages:** Python 3.x, C++ (C++11/C++17), C# (.NET Core / .NET CLI)
- **Compilers & Runtimes:** GCC / Clang (`g++`), .NET Core SDK / Roslyn, Python Interpreter
- **Core Data Structures:** Arrays, Linked Lists, Stacks, Queues, Binary Search Trees (BST), Max/Min Heaps, Disjoint Sets, Graphs (Adjacency Matrix & Lists)
- **Algorithmic Paradigms:** Divide-and-Conquer, Greedy Optimization, Dynamic Programming, State-Space Tree/Graph Traversals (DFS / BFS), Prefix Tree Compression

---

## 📁 Repository Structure

### 🔬 Capstone Compression Project
| Directory | Focus & Architecture | Primary Scripts |
| :--- | :--- | :--- |
| `DS-Project/` | Lossless file compression and decompression engine using Huffman prefix trees | `useHuffman.py`, `Huffman.py` |

### 📚 Coursework & Assignments
| Directory | Topics & Algorithmic Focus | Primary Implementations |
| :--- | :--- | :--- |
| `HW1_1_Prof/` | Array processing, frequency maps, and duplicate element detection | Python |
| `HW1_2_Prof/` | Recursive vs. iterative array transformations and algorithms | Python |
| `HW2_Prof/` | Matrix determinants via Sarrus weaving and Laplace cofactor expansion | C#, Python |
| `HW2_TA/` | ADT simulation: Queue via dual Stacks, Stack searching via Queues | C# (`.csproj`) |
| `HW3_Prof/` | Graph representations (Adjacency List/Matrix) and basic path finding | Python |
| `HW3_TA/` | High-performance sorting: Dual-Pivot Quicksort (Yaroslavskiy algorithm) | `DualQuickSort.py` |
| `HW4_TA/` | Priority Queues: Max-Heap construction and Binary Tree merging | `MaxHeap.py`, `MergingTwoTree.py` |
| `HW5_TA/` | Grid graph connected components (Number of Islands problem) via DFS/BFS | `FindingIsland.cpp` (C++) |
| `P-HW1/` | Array rotation, Insertion Sort, and Divide-and-Conquer Merge Sort | `mergesort.py`, `arrayrotation.py` |
| `P-HW2/` | Tree traversals, recursive tree height computation, and Linked List Merge Sort | `compute_tree_height.cpp` (C++) |
| `P-HW3/` | Flow graphs, dependency resolution, and graph reachability analysis | Python, C# |

---

## 🚀 Getting Started

### Prerequisites
Install the required compilers and runtime environments:

```bash
# Ubuntu / Debian
sudo apt update
sudo apt install -y python3 g++ dotnet-sdk-6.0
```

---

## 🧪 Execution Guide

### 1. Python Implementations

#### Huffman Compression Engine
```bash
cd "DS-Project/DS-Project"
python useHuffman.py
```

#### Dual-Pivot Quicksort
```bash
cd "HW3_TA/DS-HW3"
python DualQuickSort.py
```

#### Heaps & Binary Trees
```bash
cd "HW4_TA/DS"
python MaxHeap.py
python MergingTwoTree.py
```

#### Sorting & Array Manipulations
```bash
cd "P-HW1"
python mergesort.py
python arrayrotation.py
```

---

### 2. C++ Implementations

#### Island Detection (Graph DFS / BFS)
```bash
cd "HW5_TA/DS_2/DS"
g++ -std=c++17 FindingIsland.cpp -o FindingIsland
./FindingIsland
```

#### Tree Height Calculation
```bash
cd "P-HW2"
g++ -std=c++17 compute_tree_height.cpp -o compute_tree_height
./compute_tree_height
```

---

### 3. C# (.NET Core) Projects

#### Matrix Determinant Algorithms
```bash
# Laplace Cofactor Expansion
cd "HW2_Prof/DS_DeterminateHW/Expanding"
dotnet run

# Sarrus Weaving Calculation
cd "../BasketVWeave"
dotnet run
```

#### ADT Emulations
```bash
# Queue Implementation via Dual Stacks
cd "HW2_TA/DStraining/ImplementQueueByStack"
dotnet run

# Stack Search via Queues
cd "../SearchingStackByQueue"
dotnet run
```

---

## 📜 Academic Disclaimer
The source code in this repository is maintained for portfolio, archival, and educational reference purposes.