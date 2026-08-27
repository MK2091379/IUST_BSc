# Compilers

A comprehensive suite of assignments and projects developed for the **Compiler Design** course, implemented using **ANTLR4** and **Python**. This repository covers lexical analysis, Context-Free Grammar (CFG) specification, Abstract Syntax Tree (AST) construction, parse-tree listener and visitor traversal patterns, Domain-Specific Language (DSL) grammars, and automated static code analysis engines for Object-Oriented software metric extraction.

---

## 🛠 Tech Stack

- **Languages:** Python 3.x, Java (JRE / JDK for ANTLR toolchain)
- **Parser Generator:** ANTLR 4 (ANother Tool for Language Recognition)
- **Runtime:** `antlr4-python3-runtime`
- **Core Concepts:** Lexical & Syntactic Analysis, AST Traversal (Visitor & Listener Patterns), Context-Free Grammars, Static Code Analysis, Software Metrics

---

## 📁 Repository Structure

### 📚 Homework & Grammar Specifications
| Directory | Focus & Grammar Design | Key Artifacts |
| :--- | :--- | :--- |
| `HW1/` | Java grammar parsing, DSL grammars (URLs, Connection Strings), and AST metric analysis | `JavaLexer.g4`, `JavaParserLabeled.g4`, `url.g4`, `Connection_String.g4` |
| `HW2/` | Formal CFG design, resolving ambiguities, operator precedence, and associativity | `Question3.g4` |
| `HW3/` | Advanced grammar engineering and structural syntax validation | `Q2.g4` |

### 🖥 Projects & Static Analysis
| Directory | Focus & Architecture | Primary Scripts |
| :--- | :--- | :--- |
| `Project_P2/` | Static analysis engine extracting class, method, variable, and file-level metrics | `count_decl_*.py`, `test1.py` – `test4.py` |
| `scoring other groups P2 of project/` | Automated benchmarking harness to evaluate and validate peer implementations | `test1.py` – `test4.py` |

---

## 🚀 Getting Started

### Prerequisites
- [Python 3.8+](https://www.python.org/downloads/)
- [Java Runtime Environment (JRE) / JDK 11+](https://www.oracle.com/java/technologies/downloads/) (required to run the ANTLR tool)
- ANTLR 4 complete tool JAR
- Python ANTLR runtime:

```bash
pip install antlr4-python3-runtime
```

---

## 🧪 Execution Guide

### 1. Generating Lexer and Parser Code from Grammars
Regenerate Python target files from ANTLR4 `.g4` definitions:

```bash
# Generate Python lexer, parser, listener, and visitor from Java grammar
antlr4 -Dlanguage=Python3 -visitor -listener HW1/grammer/JavaLexer.g4 HW1/grammer/JavaParserLabeled.g4 -o HW1/gen/

# Generate parsers for custom DSL grammars
antlr4 -Dlanguage=Python3 HW1/grammer/Connection_String.g4
antlr4 -Dlanguage=Python3 HW1/grammer/url.g4
```

---

### 2. Running HW1 Software Metric Extraction
```bash
# Execute Java source metric extractor
cd "HW1/New folder/New folder/Compiler_Proj1/Compiler_Proj1/softwareMetric"
python main.py

# Run main parser pipeline
cd ..
python main.py
```

---

### 3. Project Phase 2: Static Analysis Engine
Navigate to the Phase 2 directory to calculate declaration metrics or run unit test suites:

```bash
cd "Project_P2/g4-phase2/g4-phase2"

# Run individual metric extractors
python count_decl_class_method.py
python count_decl_class_variable.py
python count_decl_executable_unit.py
python count_decl_file.py

# Run test verification suites
python test1.py
python test2.py
python test3.py
python test4.py
```

---

### 4. Peer Evaluation Benchmarks
```bash
cd "scoring other groups P2 of project/g4-phase2(1)/g4-phase2"

# Run evaluation benchmarks against test suites
python test1.py
python test2.py
python test3.py
python test4.py
```

---

## 📜 Academic Disclaimer
The source code in this repository is maintained for portfolio, archival, and educational reference purposes.