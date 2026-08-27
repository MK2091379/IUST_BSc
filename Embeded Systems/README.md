# Embedded and Real-Time Systems

A repository of embedded software implementations, hardware-software co-design projects, and microcontroller firmware developed for the **Embedded Systems** course. This repository explores real-time peripheral control, sensor data acquisition pipelines, hardware timers, Pulse-Width Modulation (PWM) signal generation, Analog-to-Digital Conversion (ADC), and serial telemetry on microcontroller architectures.

---

## 🛠 Tech Stack & Tools

- **Languages:** C / C++ (Embedded Systems)
- **Frameworks & Runtimes:** Arduino Core Framework, AVR Architecture
- **Hardware Peripherals:** GPIO, Hardware Timers, PWM, ADC, UART Serial Communication
- **Toolchains & IDEs:** Arduino IDE (v2.x), Arduino CLI (`arduino-cli`), AVR-GCC

---

## 📁 Repository Structure

### 🎛 Firmware Modules
| Directory | Target / Module | Focus & Implementation | Primary Files |
| :--- | :--- | :--- | :--- |
| `Proj/` | Microcontroller Core | Peripheral initialization, sensor polling loops, PWM control, and serial telemetry | `sketch_jun15a.ino` |

---

## 🚀 Getting Started

### Prerequisites
- [Arduino IDE](https://www.arduino.cc/en/software) (version 1.8.x / 2.x+) or [Arduino CLI](https://arduino.github.io/arduino-cli/)
- Target microcontroller development board (e.g., Arduino Uno, Mega, Nano, or compatible AVR/ARM target)
- Appropriate USB-to-UART bridge drivers (e.g., CH340, FTDI, CP210x)

---

## 🧪 Build & Flash Guide

### 1. GUI Method: Arduino IDE
1. Launch **Arduino IDE**.
2. Open the project source file: `File` $\rightarrow$ `Open...` $\rightarrow$ `Proj/sketch_jun15a.ino`.
3. Select your target development board under `Tools` $\rightarrow$ `Board` (e.g., *Arduino Uno*).
4. Select the active serial communication port under `Tools` $\rightarrow$ `Port` (e.g., `COM3` on Windows or `/dev/ttyACM0` on Linux).
5. Click **Verify** (`Ctrl+R` / `Cmd+R`) to compile the firmware binary.
6. Click **Upload** (`Ctrl+U` / `Cmd+U`) to flash the binary to the microcontroller.
7. Open the **Serial Monitor** (`Ctrl+Shift+M`) at the configured baud rate to observe diagnostic outputs and real-time telemetry.

---

### 2. CLI Method: Arduino CLI

Compile and flash firmware directly from the terminal:

```bash
# 1. Compile sketch for the target board architecture (e.g., Arduino Uno)
arduino-cli compile --fqbn arduino:avr:uno Proj/

# 2. Flash compiled binary to the connected microcontroller
# Linux/macOS:
arduino-cli upload -p /dev/ttyACM0 --fqbn arduino:avr:uno Proj/
# Windows:
# arduino-cli upload -p COM3 --fqbn arduino:avr:uno Proj/

# 3. Open serial communication stream for telemetry inspection
arduino-cli monitor -p /dev/ttyACM0
```

---

## 📜 Academic Disclaimer
The source code and firmware in this repository are maintained for portfolio, archival, and educational reference purposes.