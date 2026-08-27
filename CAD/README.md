# Computer-Aided Design (CAD)

A comprehensive repository of laboratory coursework, digital logic implementations, hardware design assignments, and final project files developed for the **Computer-Aided Design (CAD) of Digital Systems** course. This repository explores Register-Transfer Level (RTL) modeling in **VHDL**, combinational and sequential circuit design, Finite State Machines (FSMs), hardware stacks, and verification pipelines across standard Electronic Design Automation (EDA) suites.

---

## 🛠 Tech Stack & Tools

- **Hardware Description Language:** VHDL (IEEE 1164, `numeric_std` standard logic libraries)
- **EDA & Simulation Suites:** Xilinx Vivado Design Suite (`xsim`), Xilinx ISE Design Suite (`ISim`), Aldec Active-HDL
- **Open-Source Toolchain:** GHDL (VHDL Analyzer/Simulator), GTKWave (Waveform Viewer)

---

## 📁 Repository Structure

### 📚 Homework & Lab Assignments
| Directory | Design Focus & Architecture | Primary Files |
| :--- | :--- | :--- |
| `HW1/` | Combinational & sequential logic: priority encoders, demultiplexers, ALU components, hardware stack | `encoder_q1.vhd`, `demultiplexer.vhd`, `stack_q4.vhd` |
| `HW2/` | Modular RTL designs, structural hardware hierarchies, and ISim waveform configurations | `q1.vhd` – `q3.vhd`, `q1_tb.vhd` – `q3_tb.vhd` |
| `HW3/` | Complex digital subsystems, Finite State Machines (FSMs), and Active-HDL waveform environments | `q1_entity.vhd`, `q2.vhd` – `q4.vhd`, `.asdb`, `.awc` |

### 🖥 Final Project
| Directory | Design Focus & Architecture | Simulation Target |
| :--- | :--- | :--- |
| `Project/` | End-to-end digital hardware system architecture with top-level integration and system testbenches | `Main_tb.vhd` (Vivado behavioral simulation) |

---

## 🚀 Getting Started

### Prerequisites
- [Xilinx Vivado](https://www.xilinx.com/products/design-tools/vivado.html) or [Xilinx ISE Design Suite](https://www.xilinx.com/products/design-tools/ise-design-suite.html)
- [Aldec Active-HDL](https://www.aldec.com/en/products/fpga_simulation/active-hdl) *(Optional, for Active-HDL waveform inspection)*
- [GHDL](https://github.com/ghdl/ghdl) & [GTKWave](http://gtkwave.sourceforge.net/) *(Recommended for lightweight local CLI simulation)*

---

## 🧪 Simulation & Verification

### 1. Final Project Behavioral Simulation (Xilinx Vivado)

#### Option A: GUI Mode
1. Launch **Xilinx Vivado**.
2. Open the project file located at `Project/Project/CAD_Final/CAD_Final.xpr`.
3. In the Flow Navigator, click **Run Simulation** $\rightarrow$ **Run Behavioral Simulation**.

#### Option B: CLI Batch Execution (Windows)
```cmd
cd "Project/Project/CAD_Final/CAD_Final.sim/sim_1/behav/xsim"

# Compile, elaborate, and simulate
compile.bat
elaborate.bat
simulate.bat
```

---

### 2. Standalone Verification with GHDL & GTKWave
To analyze, elaborate, and simulate standalone modules (`HW1`–`HW3`) using the open-source GHDL toolchain:

```bash
# 1. Analyze design and testbench entities
ghdl -a <DesignFile>.vhd <TestbenchFile>.vhd

# 2. Elaborate testbench entity
ghdl -e <TestbenchEntityName>

# 3. Execute simulation and export waveform data to VCD format
ghdl -r <TestbenchEntityName> --vcd=waveform.vcd

# 4. Inspect waveforms in GTKWave
gtkwave waveform.vcd
```

---

## 📜 Academic Disclaimer
The source code in this repository is maintained for portfolio, archival, and educational reference purposes.