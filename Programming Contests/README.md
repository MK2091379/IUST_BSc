# Programming Contests & Algorithmic Problem Solving

A curated collection of algorithmic solutions and advanced data structure implementations developed for competitive programming and contest preparation (**ICPC**, **Codeforces**, **LeetCode**, and **AtCoder**). The repository is structured chronologically by weekly problem sets, progressing from fundamental problem-solving techniques to advanced combinatorial optimization, dynamic programming, graph theory, tree data structures, number theory, string algorithms, and computational geometry in **Python 3**.

---

## 🛠 Tech Stack & Core Domains

- **Language & Runtime:** Python 3.8+ (Standard Library: `collections`, `heapq`, `itertools`, `bisect`, `math`, `sys`)
- **Advanced Data Structures:** Disjoint Set Union (DSU with Path Compression & Union by Rank), Segment Trees, Fenwick Trees (Binary Indexed Trees), Heaps / Priority Queues, Prefix Trees (Tries)
- **Dynamic Programming (DP):** 1D/2D Tabulation & Memoization, Bitmask DP, Tree DP, Range / Interval DP, Knapsack Variants
- **Graph Theory & Trees:** BFS / DFS, Dijkstra, Bellman-Ford, Minimum Spanning Trees (Kruskal & Prim), Topological Sorting, Cycle Detection
- **Algorithmic Paradigms:** Greedy Choice, Divide and Conquer, Binary Search on Answer, Two Pointers, Sliding Window, Coordinate Compression
- **Mathematics & Number Theory:** Modular Arithmetic, Fast Modular Exponentiation, Extended Euclidean Algorithm, Sieve of Eratosthenes, Combinatorics, Game Theory
- **String Algorithms & Geometry:** Rolling Hashing, KMP String Matching, Convex Hull, Computational Geometry Primitives

---

## 📁 Repository Structure

### 📚 Weekly Problem Sets & Curated Solutions

| Directory | Algorithmic Paradigms & Focus Areas | Primary Files |
| :--- | :--- | :--- |
| `Week1/` | Mathematical sequences, modular arithmetic, array manipulation, and I/O parsing | `Q1.py` – `Q14.py` |
| `Week2/` | Two pointers, sliding window optimizations, greedy sorting, and coordinate compression | `Q1.py` – `Q4.py` |
| `Week3/` | Divide-and-conquer strategies, state backtracking, and binary search over solution spaces | `Q1.py` – `Q4.py` |
| `Week4/` | Classical dynamic programming: memoization, state transitions, and space-optimized tabulation | `Q1.py` – `Q5.py` |
| `Week6/` | Graph representations, tree traversals, cycle detection, and unweighted shortest paths (BFS/DFS) | `Question1.py` – `Question3.py` |
| `Week7/` | Weighted graphs, Minimum Spanning Trees (Kruskal/Prim), Dijkstra's algorithm, and Topological Sort | `Q1.py`, `Q2.py`, `Q6.py` |
| `Week8/` | Hierarchical data structures: Disjoint Set Union (DSU), Segment Trees, and Range Query Updates | `Q1.py` – `Q7.py` |
| `Week9/` | String algorithms, pattern matching, polynomial rolling hashing, and Prefix Trees (Tries) | `Q1.py` – `Q5.py` |
| `Week10/` | Prime factorization, modular inverses, combinatorial counting, and game-theoretic state analysis | `1.py`, `2.py` |
| `Week11/` | Advanced DP: Bitmask DP state-space reduction, Tree DP, and Interval/Range Dynamic Programming | `Q1.py` – `Q5.py` |
| `Week12/` | Computational geometry, Convex Hull generation, advanced heuristics, and integrated contest problems | `Q1.py` – `Q5.py` |

---

## 🚀 Getting Started

### Prerequisites
Ensure **Python 3.8+** is installed on your system:

```bash
python3 --version
```

---

## 🧪 Execution & Testing Guide

### 1. Interactive CLI Execution
Run any standalone problem solution directly via the Python interpreter:

```bash
# Execute a Week 1 problem with interactive console input
cd Week1
python3 Q1.py

# Execute a Week 4 Dynamic Programming solution
cd ../Week4
python3 Q1.py
```

---

### 2. Testing via Standard I/O Redirection

#### File-Based Input Redirection
Feed input test vectors from a text file directly into the script:

```bash
python3 Week8/Q1.py < input.txt
```

#### Terminal Pipe Redirection
Pass raw test cases via standard output pipes:

```bash
echo -e "5\n1 2 3 4 5" | python3 Week2/Q1.py
```

---

### 3. Batch Automated Testing
Sequentially test all solutions within a specific weekly module:

```bash
# Run all solution scripts in the Week1 directory
for script in Week1/*.py; do
    echo "Executing $script..."
    python3 "$script" < /dev/null
done
```

---

## 📜 Academic Disclaimer
The algorithmic solutions and data structure implementations in this repository are maintained for competitive programming preparation, portfolio, and educational reference purposes.