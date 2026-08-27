# Theory of Automata and Formal Languages

A comprehensive computational framework and visualization suite for finite state machines developed for the **Theory of Automata and Formal Languages** course. This repository focuses on fundamental automata transformations, featuring $\epsilon$-closure computation, Non-Deterministic Finite Automata (NFA) to Deterministic Finite Automata (DFA) conversion via the **Subset Construction (Powerset) algorithm**, DFA state minimization using equivalence partitioning, Disjoint Set Union (DSU) data structures for state merging, and automated export of **Graphviz (`.dot`)** state transition diagrams.

---

## 🛠 Tech Stack & Tools

- **Language & Runtime:** Python 3.8+
- **Graph Visualization:** Graphviz (DOT Graph Description Language)
- **Data Structures:** Disjoint Set Union (Union-Find with Path Compression & Union by Rank)
- **Core Automata Paradigms:** Non-Deterministic Finite Automata (NFA), Deterministic Finite Automata (DFA), $\epsilon$-NFA Transition Closure, Powerset Subset Construction, DFA Minimization (Table-Filling / Equivalence Partitioning), Dead-State Elimination

---

## 📁 Repository Structure

### 📚 Core Modules & Visualization Pipelines (`TLA-Project/`)

| File / Directory | Module Type | Focus & Core Functionality |
| :--- | :--- | :--- |
| `NFA.py` | **NFA Engine** | Transition evaluation, $\epsilon$-closure computation, and automated NFA-to-DFA subset construction |
| `DFA.py` | **DFA Engine** | Transition table evaluation, string acceptance verification, dead-state elimination, and DFA minimization |
| `disjoint_set.py` | **Data Structure** | Disjoint Set (Union-Find) structure for tracking and collapsing equivalent state partitions |
| `DFA-Graph/` | **Graph Artifacts** | Exported Graphviz `.dot` descriptors for standalone DFAs (`dfaout.dot`, `Minimized_dfaout.dot`) |
| `NFA-Graph/` | **Graph Artifacts** | Exported Graphviz `.dot` descriptors for NFAs, subset DFAs, and minimized state machines |

---

## 🚀 Getting Started

### Prerequisites
- [Python 3.8+](https://www.python.org/downloads/)
- [Graphviz](https://graphviz.org/download/) (required for compiling `.dot` graph descriptors into images)

#### Install Graphviz CLI
```bash
# Ubuntu / Debian
sudo apt update && sudo apt install -y graphviz

# macOS (Homebrew)
brew install graphviz

# Windows (Chocolatey / Scoop)
choco install graphviz
```

---

## 🧪 Execution & Verification Guide

### 1. Running Automata Simulations & Conversions
Navigate to the project source directory to execute state simulation, subset construction, and minimization routines:

```bash
cd TLA-Project

# Run NFA simulation and generate subset-constructed DFA models
python NFA.py

# Run DFA simulation, string acceptance tests, and minimization
python DFA.py
```

---

### 2. Rendering State Transition Graphs (Graphviz)
Convert the generated `.dot` transition graph files into PNG or SVG visual diagrams:

#### DFA Graph Rendering
```bash
cd TLA-Project

# Render unminimized DFA transition graph
dot -Tpng DFA-Graph/dfaout.dot -o DFA-Graph/dfaout.png

# Render minimized DFA transition graph
dot -Tpng DFA-Graph/Minimized_dfaout.dot -o DFA-Graph/Minimized_dfaout.png
```

#### NFA & Converted Automata Rendering
```bash
cd TLA-Project

# Render source NFA transition graph
dot -Tpng NFA-Graph/nfaout.dot -o NFA-Graph/nfaout.png

# Render converted DFA transition graph
dot -Tpng NFA-Graph/dfaout.dot -o NFA-Graph/dfaout.png

# Render final minimized DFA graph
dot -Tpng NFA-Graph/Minimized_dfaout.dot -o NFA-Graph/Minimized_dfaout.png
```

---

## 📜 Academic Disclaimer
The source code, algorithms, and graph artifacts in this repository are maintained for portfolio, archival, and educational reference purposes.