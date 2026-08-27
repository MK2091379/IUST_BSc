# Logical Circuits & Digital Logic Design

A digital logic design, schematic capture, and circuit simulation repository developed for the **Logical Circuits** course. This repository models digital control circuitry and bus interfacing for alphanumeric Liquid Crystal Displays (LCDs) based on the **Hitachi HD44780 controller architecture**, exploring combinational logic, sequential synchronization, timing constraints, control line sequencing (Register Select, Read/Write, Enable), and interactive circuit simulation in **Proteus Design Suite**.

---

## 🛠 Tech Stack & Tools

- **EDA & Simulation Suite:** Labcenter Proteus Design Suite (Schematic Capture & ISIS Simulation Engine)
- **Target Hardware Architecture:** Alphanumeric LCD Driver (HD44780 Controller Protocol)
- **Circuit Paradigms:** Combinational & Sequential Logic, Parallel Bus Interfacing, Pulse Generation, Timing Diagrams & State Transition Analysis

---

## 📁 Repository Structure

### 🎛 Schematic & Simulation Artifacts
| Directory | Design Focus & Architecture | Primary Files |
| :--- | :--- | :--- |
| `LCDProject/LCDProject/LCDProject/` | Digital control circuitry, bus interfacing, and interactive schematic models for the alphanumeric LCD module | `LCDProject.pdsprj`, `.workspace`, `.pdsbak` |

---

## 🚀 Getting Started

### Prerequisites
- [Labcenter Electronics Proteus Design Suite](https://www.labcenter.com/) (Version 8.0 or higher recommended)

---

## 🧪 Simulation & Verification Guide

### 1. Opening the Schematic Project
1. Launch **Proteus Design Suite**.
2. Navigate to `File` $\rightarrow$ `Open Project...` and load:
   ```text
   Logical Circuits/LCDProject/LCDProject/LCDProject/LCDProject.pdsprj
   ```

---

### 2. Inspecting the Architecture
- Review the digital logic IC layouts, clock/pulse generation networks, and 8-bit/4-bit parallel data bus routings.
- Inspect the control line configurations:
  - **RS (Register Select):** Selects between command and data registers.
  - **R/W (Read/Write):** Configures data direction (write/read cycle).
  - **E (Enable):** Latches data on falling-edge clock transitions.

---

### 3. Executing the Dynamic Simulation
1. Click the **Play** (Run Simulation) button in the bottom-left control bar or press `F12`.
2. Toggle interactive logic state switches and input pins to generate control pulse sequences and observe data transmission across the bus.
3. Monitor real-time character rendering on the simulated alphanumeric LCD screen.
4. Utilize the built-in **Proteus Digital Logic Analyzer** and **Digital Oscilloscope** to measure signal timing margins, setup/hold times, and clock pulse widths.

---

## 📜 Academic Disclaimer
The schematic designs and simulation models in this repository are maintained for portfolio, archival, and educational reference purposes.