# Computer Architecture

A comprehensive repository of coursework implementations and simulations developed for the **Computer Architecture** course. This repository focuses on the **MIPS32 Instruction Set Architecture (ISA)**, featuring custom assembly-to-binary translation engines, instruction decoding across R, I, and J formats, register file mapping, immediate/branch address resolution, and fundamental computer organization concepts.

---

## 🛠 Tech Stack

- **Language & Environment:** Python 3.x, Jupyter Notebook / JupyterLab
- **Libraries:** NumPy
- **Architecture & Paradigms:** MIPS32 ISA, Assembly Language, Machine Code Encoding, Bitwise Manipulation, Instruction Decoding

---

## 📁 Repository Structure

### 📚 Coursework & Modules
| Directory | Focus & Architecture | Primary Artifacts |
| :--- | :--- | :--- |
| `HW1/` | Two-pass MIPS32 Assembler translating R-type, I-type, and J-type instructions into 32-bit machine code bitstrings | `HW1_SayyedMoeinKazemi_98521396.ipynb` |

---

## 🚀 Getting Started

### Prerequisites
- [Python 3.8+](https://www.python.org/downloads/)
- JupyterLab or Jupyter Notebook

### Installation
Clone the repository and install the necessary dependencies:

```bash
pip install numpy jupyterlab
```

---

## 🧪 Execution & Usage

### 1. Launching the Assembler Notebook
Open and run the interactive MIPS32 Assembler notebook:

```bash
jupyter notebook HW1/HW1_SayyedMoeinKazemi_98521396.ipynb
```

---

### 2. Translation Overview & Example

The assembler parses MIPS32 assembly statements and encodes them into standard 32-bit binary strings:

#### Sample Assembly Input (`program.asm`)
```assembly
add  $t0, $s1, $s2
addi $t1, $s0, 100
lw   $t2, 4($s3)
beq  $t0, $t1, label
j    target
```

#### Encoded Binary Output (32-bit Bitstrings)
```text
000000 10001 10010 01000 00000 100000  # add  $t0, $s1, $s2 (R-type)
001000 10000 01001 0000000001100100    # addi $t1, $s0, 100 (I-type)
100011 10011 01010 0000000000000100    # lw   $t2, 4($s3)   (I-type)
000100 01000 01001 [ 16-bit offset ]   # beq  $t0, $t1, label (I-type)
000010 [ 26-bit target address ]       # j    target          (J-type)
```

---

## 📜 Academic Disclaimer
The source code in this repository is maintained for portfolio, archival, and educational reference purposes.