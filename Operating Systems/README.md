# Operating Systems

A comprehensive repository of low-level systems programming, concurrent software architectures, and kernel-level extensions developed for the **Operating Systems** course. This repository spans user-space POSIX systems programming—including shell scripting, stream redirection, concurrent TCP socket servers, and multi-threaded synchronization—to kernel-space development on the **MIT xv6 Unix-like operating system**, featuring custom system calls, process table instrumentation, and CPU scheduling frameworks (Multi-Level Queue, Priority Scheduling, and dynamic aging).

---

## 🛠 Tech Stack & Tools

- **Languages:** C (POSIX C99 / GNU C), x86 Assembly, Bash Shell Scripting
- **Kernel & Emulation:** MIT xv6 Operating System, QEMU (`qemu-system-x86`), Bochs
- **Concurrency & IPC:** POSIX Threads (`pthread`), Mutexes, Condition Variables, Unix Pipes, `dup2` Stream Redirection, TCP Sockets
- **Kernel Subsystems:** CPU Scheduling (MLQ, Priority, Aging), Process Table Instrumentation, Custom System Calls
- **Toolchains:** GCC, GNU Make, GDB

---

## 📁 Repository Structure

### 💻 User-Space Systems Programming & Concurrency
| Directory | Domain & Focus | Primary Files |
| :--- | :--- | :--- |
| `HW0_1/` | Linux automation, server health monitoring, and regex log parsing | `server_status.sh`, `count_names.sh` |
| `HW0_2/` | Pointer arithmetic, dynamic memory allocation, and POSIX syscall abstractions | `Q1.c`, `Q2.c`, `Q3.c` |
| `P-HW2/` | Process lifecycle control (`fork`/`exec`), `dup2` I/O redirection, and TCP socket servers | `redirect.c`, `server.c` |
| `P-HW3/` | Multi-threaded synchronization, race conditions, and mutex coordination | `q2.c`, `q3.c` |

### 🧩 MIT xv6 Kernel Enhancements
| Directory | Kernel Component | Implementations & Test Utilities |
| :--- | :--- | :--- |
| `P-P1/` | **Syscalls & Process Table** | Custom system calls, process tracking (`my_struct.h`), and user-space process lister (`ps.c`) |
| `P-P2/` | **Advanced CPU Scheduling** | Multi-Level Queue (MLQ) scheduling, priority assignment (`nice`), execution accounting, and benchmarks (`testmlq.c`, `testnice.c`, `testspri.c`, `testwaitx.c`) |

---

## 🚀 Getting Started

### Prerequisites
Ensure your environment (Ubuntu/Debian Linux or WSL2) has GCC, GNU Make, GDB, and the QEMU x86 system emulator installed:

```bash
sudo apt update
sudo apt install -y build-essential gdb qemu-system-x86
```

---

## 🧪 Build & Execution Guide

### 1. User-Space Systems Programming

#### Linux Monitoring Scripts
```bash
chmod +x HW0_1/script-templates-q1\ \(1\)/script-templates-q1\ \(1\)/server_status.sh
./HW0_1/script-templates-q1\ \(1\)/script-templates-q1\ \(1\)/server_status.sh
```

#### Process Redirection & Socket Servers
```bash
# Build and run stream redirection demo
cd P-HW2/2/q1
make && ./redirect

# Build and start concurrent TCP server
cd ../q2
make && ./server
```

#### Multi-Threaded Synchronization Programs
```bash
# Compile with POSIX threads library
gcc -Wall -Wextra -pthread P-HW3/q2.c -o q2_exec
./q2_exec
```

---

### 2. xv6 Kernel Emulation (QEMU)

#### Booting the Kernel
```bash
# Navigate to xv6 kernel project directory
cd P-P2/xv6-public-phase_3_2/xv6-public-phase_3

# Compile kernel and boot headless inside QEMU
make qemu-nox
```

#### Running Kernel Benchmarks & Scheduler Tests
Inside the running xv6 shell terminal:

```bash
# Test Multi-Level Queue (MLQ) scheduling behavior
$ testmlq

# Test static priority scheduling
$ testspri

# Test process nice values and priority preemption
$ testnice

# Test extended wait syscall with execution/wait-time accounting
$ testwaitx
```

#### Exiting QEMU
To cleanly exit the QEMU emulator session, press:
```text
Ctrl + A, then release and press X
```

---

## 📜 Academic Disclaimer
The source code and kernel modifications in this repository are maintained for portfolio, archival, and educational reference purposes.