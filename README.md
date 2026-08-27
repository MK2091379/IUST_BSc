# Computer Engineering & Computer Science Coursework Portfolio

A comprehensive, centralized repository containing undergraduate-level academic coursework, laboratory implementations, hardware-software co-designs, theoretical simulations, and research projects. This portfolio spans foundational software engineering, low-level systems programming, hardware description and digital logic, artificial intelligence, networking, and digital signal processing.

---

## 🧭 Repository Navigation & Curricula Overview

### 1. Software Engineering, Algorithms & Theory
| Directory | Subject / Domain | Core Focus & Paradigms | Primary Tech Stack |
| :--- | :--- | :--- | :--- |
| `Advanced Programming` | Advanced Object-Oriented Design | OOP architecture, custom data structures, operator overloading, event-driven UI | C#, .NET Core, WPF, XAML |
| `Algorithm Design` | Algorithmic Paradigms & Analysis | Divide-and-conquer, greedy optimization, dynamic programming, backtracking | Python 3, C#, Roslyn (`csc`) |
| `Data Structures and Algorithms` | Abstract Data Types & Efficiency | Trees, heaps, graph traversals, dual-pivot sorting, Huffman compression | Python, C++17, C# (.NET Core) |
| `Discrete Mathematics` | Combinatorics & Formal Logic | Recurrences (Tower of Hanoi), permutation generators, relation closures | C (GCC), C# (.NET Core) |
| `Programming Contests & Algorithmic Problem Solving` | Competitive Programming | Segment trees, DSU, bitmask DP, graph pathfinding, computational geometry | Python 3 |
| `Theory of Automata and Formal Languages` | Formal Languages & State Machines | NFA-to-DFA subset construction, DFA state minimization, DSU equivalence partitions | Python 3, Graphviz (`.dot`) |

---

### 2. Systems Programming, Computer Architecture & Hardware
| Directory | Subject / Domain | Core Focus & Paradigms | Primary Tech Stack |
| :--- | :--- | :--- | :--- |
| `Computer Architecture` | ISA & Machine Organization | MIPS32 assembler (R/I/J formats), binary instruction decoding, bitwise mapping | Python 3, Jupyter Notebook |
| `Computer-Aided Design (CAD)` | Digital RTL & Hardware Synthesis | Combinational/sequential RTL, priority encoders, hardware stacks, FSM verification | VHDL, Vivado, ISE, Active-HDL, GHDL |
| `Embedded Systems` | Microcontroller Firmware | GPIO control, hardware timers, PWM modulation, ADC polling, serial telemetry | Embedded C/C++, Arduino Core, AVR |
| `Logical Circuits` | Digital Logic Design | Alphanumeric LCD controller (HD44780), bus timing, combinational/sequential logic | Proteus Design Suite (ISIS) |
| `Logical Circuits Laboratory` | Hardware Prototyping & Verification | 74xx/40xx IC logic gates, multiplexers, counters, shift registers, FSM design | Proteus Design Suite (ISIS) |
| `Microprocessors and Assembly Laboratory` | Low-Level Bare-Metal Firmware | Direct register I/O, ISR interrupts, timers/PWM, ADC, USART, matrix keypads | AVR Assembly, Embedded C, Proteus VSM |
| `Operating Systems` | Systems & Kernel Engineering | Unix shell scripts, POSIX IPC/threads, xv6 kernel syscalls, MLQ CPU scheduling | C (POSIX), MIT xv6, QEMU, x86 ASM |

---

### 3. Artificial Intelligence, Vision & Stochastic Modeling
| Directory | Subject / Domain | Core Focus & Paradigms | Primary Tech Stack |
| :--- | :--- | :--- | :--- |
| `Artificial Intelligence` | Classical & Modern AI Systems | State-space search, Minimax, RL (Q-Learning), HMM particle filters, neural networks | Python 3, Berkeley Pacman AI, NumPy |
| `Computational Intelligence` | Nature-Inspired & Metaheuristics | Multilayer Perceptrons (MLP), Genetic Algorithms (TSP), Fuzzy Systems, PSO | Python 3, Jupyter, NumPy, SciPy |
| `Computer Simulation` | Discrete-Event Simulation (DES) | Stochastic modeling, event-list scheduling, $M/M/1$ queue dynamics, Little's Law | Python 3, NumPy, Matplotlib |
| `Computer Vision` | Image Processing & Visual Recognition | Spatial/frequency filtering (FFT), SIFT/ORB homography, CNNs, optical flow | Python 3, OpenCV, PyTorch, Scikit-Image |

--- 

### 4. Networks, Security, Communications & Signal Processing
| Directory | Subject / Domain | Core Focus & Paradigms | Primary Tech Stack |
| :--- | :--- | :--- | :--- |
| `Compilers` | Language Recognition & Parsing | ANTLR4 grammars (Java, DSLs), AST traversal (Visitor/Listener), static metrics | Python 3, Java, ANTLR4 Runtime |
| `Computer Networks Lab` | SDN Emulation & Socket Programming | Mininet topologies, POSIX sockets (TCP/UDP), NAT (`iptables`), RIP routing | C, Python, Mininet, Quagga, Wireshark |
| `Cybersecurity` | Applied Cryptography & PKI | AES/DES block modes, RSA key generation, Diffie-Hellman, secure socket protocol | Python 3, `pycryptodome`, Sockets |
| `Data Communication` | Physical Layer Modeling | PCM, baseband line codes, $M$-ary modulation (PSK/QAM), AWGN, Monte Carlo BER | MATLAB, GNU Octave |
| `Database Systems` | Relational Engineering & DDL/DML | ER/EER modeling, schema normalization, stored procedures, triggers, views | PostgreSQL, MySQL, T-SQL, PL/pgSQL |
| `Signals and Systems` | Linear System & Fourier Analysis | Continuous/discrete LTI systems, convolution, CTFS synthesis, CTFT, filtering | MATLAB, GNU Octave |
| `Wireless Networks` | RF Modeling & Packet Dissection | IEEE 802.11 frame parsing (Scapy), link budgets, 2D indoor RF heatmap models | Python 3, Scapy, Wireshark, Pillow |

---

### 5. Research & Capstone
| Directory | Project Title | Description | Primary Tech Stack |
| :--- | :--- | :--- | :--- |
| `Final Thesis` | Secure Data Transmission & Compression System | Bandwidth-efficient, encrypted socket channel combining Huffman coding with AES/OTP | Python 3, `pycryptodome`, Tkinter, Sockets |

---

## 🛠 Unified Technology Stack

```
Languages:            Python, C, C++, C#, Java, VHDL, AVR Assembly, x86 Assembly, SQL, MATLAB / Octave, Bash
Frameworks & SDKs:    .NET Core / Framework, WPF, PyTorch, Arduino Core, xv6 Kernel, ANTLR4
EDA & Simulation:     Xilinx Vivado / ISE, Aldec Active-HDL, GHDL, GTKWave, Proteus Design Suite (VSM/ISIS), QEMU, Mininet
Libraries & Tools:    NumPy, SciPy, Pandas, Matplotlib, OpenCV, Scikit-Learn, Scapy, PyCryptodome, Graphviz, Wireshark
Databases:            PostgreSQL, MySQL, Microsoft SQL Server
```

---

## 🚀 Environment Setup & Global Prerequisites

Because this repository houses multi-language environments and specialized toolchains, ensure the core compilers and interpreters are available on your host system (Linux / Ubuntu or WSL2 recommended):

```bash
# 1. Update Package Lists and Install Build Essentials
sudo apt update && sudo apt install -y \
    build-essential \
    gdb \
    python3 \
    python3-pip \
    python3-venv \
    gcc-avr \
    binutils-avr \
    avr-libc \
    ghdl \
    gtkwave \
    graphviz \
    wireshark \
    tcpdump \
    mininet \
    openvswitch-switch \
    qemu-system-x86

# 2. Install .NET SDK (6.0+)
# Follow official Microsoft instructions: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

# 3. Python Virtual Environment Setup (Recommended)
python3 -m venv venv
source venv/bin/activate
pip install --upgrade pip
```

---

## 📖 Sub-Module Execution
Each subfolder in this repository contains its own self-contained codebase, documentation, and specific execution commands. Refer to the individual `README.md` file located inside each respective directory for detailed setup instructions, test cases, and simulation steps.

---

## 📜 Academic Integrity & Disclaimer
The source code, hardware designs, schematic models, and simulation pipelines preserved in this repository are maintained for portfolio presentation, personal archival, and educational reference purposes.