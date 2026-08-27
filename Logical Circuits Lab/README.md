# Logical Circuits Laboratory

A comprehensive collection of digital logic experiments, circuit schematics, and interactive simulations developed for the **Logical Circuits Laboratory** course. This repository explores the design, modular hierarchy, analysis, and verification of combinational and sequential digital systems using **Proteus Design Suite (ISIS)**, covering fundamental logic gates, MSI components (multiplexers, decoders, counters, shift registers), Finite State Machines (FSMs), and display bus interfaces.

---

## 🛠 Tech Stack & Tools

- **EDA & Simulation Suite:** Labcenter Proteus Design Suite (Schematic Capture & ISIS Interactive Simulation)
- **IC Standards & Components:** TTL 74xx Series, CMOS 40xx Series
- **Combinational Logic:** Multiplexers (MUX), Demultiplexers (DEMUX), Encoders, Decoders, XOR Parity Trees, Arithmetic Logic Circuits
- **Sequential Logic:** Latches, Flip-Flops (D, JK, T), Synchronous/Asynchronous Counters, Shift Registers, Finite State Machines (FSMs)
- **Display & Bus Interfacing:** 7-Segment Displays/Decoders, Alphanumeric LCD Drivers (HD44780 Architecture)

---

## 📁 Repository Structure

### 📚 Homework Assignments (`HW1` – `HW7`)
| Directory | Focus & Circuit Paradigms | Primary Files |
| :--- | :--- | :--- |
| `HW1/` | Basic logic gate synthesis, XOR trees, and 8-to-1 Multiplexer implementations | `8to1MUX.pdsprj`, `XOR-Gate.pdsprj` |
| `HW2/` | Advanced combinational logic design and display bus control circuitry | `LCD-Lab-P2.pdsprj` |
| `HW3/` | Sub-circuit cascading, Boolean function realization, and digital signal decoding | `HW3_Q5-2.pdsprj`, `HW3_Q6.pdsprj`, `HW3_Q71.pdsprj` |
| `HW4/` | Multi-stage digital logic network simulation and verification | `HW.pdsprj` |
| `HW5/` | Medium-Scale Integration (MSI) logic design and multi-bit data processing | `HW5.pdsprj` |
| `HW6/` | Sequential binary counters and clocked state transition analysis | `tamrin_Haftegi.pdsprj` |
| `HW7/` | Integrated digital control system with alphanumeric display output | `HW-LAST.pdsprj` |

### 🔬 In-Class Laboratory Experiments (`Assignment1` – `Assignment10`)
| Session Directory | Circuit Focus & Objectives | Key Project Files |
| :--- | :--- | :--- |
| `in-class Assignment1/` | Logic gate truth tables, Boolean synthesis, and 8-to-1 MUX trees | `8to1MUX.pdsprj`, `XOR-Gate.pdsprj` |
| `in-class Assignment2/` | MUX hierarchies (2:1, 4:1 MUX), XOR logic, and basic display drivers | `2to1MUX.pdsprj`, `4to1MUX.pdsprj`, `LCD-Lab-S3-E1.pdsprj` |
| `in-class Assignment3/` | Combinational arithmetic circuits, data routing, and bus steering | `LCD-Lab-S5-Q1.pdsprj`, `LCD-Lab-S5-Q2.pdsprj` |
| `in-class Assignment4/` | Multi-stage combinational sub-blocks and logic gate minimization | `s6_1.pdsprj` – `s6_4.pdsprj` |
| `in-class Assignment5/` | Memory elements, latches, flip-flop timing diagrams, and edge-triggering | `s7-1.pdsprj` – `s7-4.pdsprj` |
| `in-class Assignment6/` | Synchronous and asynchronous binary counters and register transfer logic | `s8.pdsprj` |
| `in-class Assignment7/` | Modular digital subsystem integration and timing verification | `New Project (4).pdsprj` |
| `in-class Assignment8/` | Multi-bit shift registers and sequential pattern detector circuits | `s11.pdsprj` |
| `in-class Assignment9/` | Signal timing sequence generators and display driver integration | `LCD-LAB-12KHORDAD.pdsprj` |
| `in-class Assignment10/` | Complex sequential state machines (FSMs) and transient response analysis | `S8.pdsprj` |

### 📝 Final Examination
| Directory | Focus & Description | Primary Artifacts |
| :--- | :--- | :--- |
| `FinalExam/` | Multi-variable digital logic design, state mapping, and analytical verification | `Question4.pdsprj`, `Question4.xlsx` |

---

## 🚀 Getting Started

### Prerequisites
- [Labcenter Electronics Proteus Design Suite](https://www.labcenter.com/) (Version 8.0 or higher recommended)

---

## 🧪 Simulation & Verification Guide

### 1. Opening a Schematic Project
1. Launch **Proteus Design Suite**.
2. Navigate to `File` → `Open Project...` and select the target `.pdsprj` file:
   - *Example (Homework):* `HW1/LCD-Lab-P1/LCD-Lab-P1/8to1MUX.pdsprj`
   - *Example (Final Exam):* `FinalExam/FinalExam/Question4.pdsprj`

---

### 2. Running Dynamic Circuit Simulations
1. Review IC pin assignments, pull-up/pull-down resistor networks, and logic state probes.
2. Click the **Play** button in the bottom-left control toolbar or press `F12` to initiate interactive simulation.
3. Toggle interactive logic state switches (`DSTATE`) and clock inputs to observe real-time state changes on output LEDs, 7-segment displays, and LCD modules.
4. Open the **Proteus Logic Analyser** or **Digital Oscilloscope** windows to evaluate signal timings, propagation delays, setup/hold margins, and clock transitions.

---

## 📜 Academic Disclaimer
The schematic designs and simulation models in this repository are maintained for portfolio, archival, and educational reference purposes.