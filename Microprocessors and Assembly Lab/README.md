# Microprocessors & Assembly Laboratory

A comprehensive repository of bare-metal firmware implementations, peripheral device drivers, and hardware co-simulations developed for the **Microprocessors and Assembly Laboratory** course. This repository focuses on low-level embedded software engineering for **Microchip/Atmel 8-bit AVR microcontrollers** (ATmega16/ATmega32) using **AVR Assembly** and **Embedded C**, covering direct register manipulation, memory-mapped I/O, hardware timers, ISR-driven interrupts, PWM generation, multi-channel ADC conversion, full-duplex USART serial communication, and dynamic Proteus VSM co-simulation.

---

## 🛠 Tech Stack & Tools

- **Languages:** AVR Assembly Language, Embedded C
- **Architectures:** 8-bit AVR RISC (Microchip / Atmel ATmega16 & ATmega32)
- **IDEs & Compilers:** Microchip Studio (Atmel Studio), CodeVisionAVR, `avr-gcc` / `avr-libc` toolchain, AVRA
- **Simulation & EDA:** Labcenter Proteus Design Suite (VSM Hardware/Firmware Co-Simulation)
- **Peripherals & Drivers:** GPIO, Hardware Timers/Counters (Normal, CTC, Fast PWM), External Interrupts (INT0–INT2), ADC, USART, EEPROM
- **Display & Interface Hardware:** 8×16 LED Dot Matrix, Multiplexed 7-Segment Displays, 4×4 Matrix Keypads, DIP Switches

---

## 📁 Repository Structure

### ⚙️ AVR Assembly & Hardware Simulation
| Directory | Target Hardware & Paradigms | Primary Files |
| :--- | :--- | :--- |
| `HW1/` – `HW2/` | ALU operations, register file allocation, status flags, bitwise masking, and port I/O | `Tamrin2.asm`, `Circuit.pdsprj` |
| `HW3/` | Modular assembly routines, automated batch build scripting, and Proteus co-simulation | `Tamrin3.asm`, `AvrBuild.bat`, `Tamrin3.pdsprj` |

### 🔌 Embedded C Firmware & Peripheral Interfacing
| Directory | Target Peripheral & Domain | Key Source / Projects |
| :--- | :--- | :--- |
| `HW4/` | Multiplexed 7-segment display controller and DIP switch state decoder | `tamrin4.c`, `7seg-dipswitch-02.pdsprj` |
| `HW5/` | Dynamic column-scanning and row-multiplexing 8×16 LED Dot Matrix driver | `HW5.c`, `LED_MATRIX_8x16.pdsprj` |
| `HW6/` | Hardware Timer/Counter configurations (Normal, CTC, and Fast PWM modes) | `98521396-lab6.c` |
| `HW7/` | External hardware interrupt handlers (INT0, INT1, INT2) and asynchronous ISRs | `98521396-lab7.c` |
| `HW8/` | Full-duplex USART serial communication drivers and character buffering | `hw^.c` |
| `HW9/` | Multi-channel Analog-to-Digital Converter (ADC) sampling and sensor acquisition | `98521396-aaz9.c` |
| `HW10/` | 4×4 matrix keypad row-column scanning algorithms and key decoding | `98521396-hw10.c` |
| `HW11/` | Peripheral bus interfacing, timer synchronization, and EEPROM read/write logic | `98521396-aaz11.c` |
| `HW12/` | Multi-peripheral embedded system integration and precision waveform synthesis | `98521396-AAz12.c` |

### 📝 Examinations & Practice
| Directory | Focus & Description |
| :--- | :--- |
| `Sample_Exams/` | Practical laboratory examination problems, timing verification routines, and embedded problem sets |

---

## 🚀 Getting Started

### Prerequisites
- [Proteus Design Suite](https://www.labcenter.com/) (Version 8.x or higher)
- [Microchip Studio](https://www.microchip.com/en-us/tools-resources/develop/microchip-studio) (formerly Atmel Studio) or [CodeVisionAVR](https://www.hpinfotech.ro/)
- GNU AVR Toolchain (`avr-gcc`, `avr-libc`, `binutils-avr`) for command-line builds:

```bash
# Ubuntu / Debian
sudo apt update
sudo apt install -y gcc-avr binutils-avr avr-libc avrdude
```

---

## 🧪 Build & Co-Simulation Guide

### 1. Compiling Firmware via CLI (`avr-gcc`)
Compile Embedded C source files to generate Intel HEX binaries for simulation:

```bash
# 1. Compile C source for ATmega32 with an 8 MHz clock frequency
avr-gcc -mmcu=atmega32 -DF_CPU=8000000UL -Os -o firmware.elf <PathToSource>.c

# 2. Extract Intel HEX binary image
avr-objcopy -O ihex -R .eeprom firmware.elf firmware.hex
```

---

### 2. Interactive Hardware/Firmware Co-Simulation in Proteus

1. Launch **Proteus Design Suite**.
2. Open the desired schematic co-simulation project (e.g., `HW4/.../7seg-dipswitch-02.pdsprj` or `HW5/.../LED_MATRIX_8x16.pdsprj`).
3. Double-click the target microcontroller component (e.g., **ATmega32**) to open the **Edit Component** property panel.
4. Set the **Program File** field to the compiled `.hex` or `.cof` binary.
5. Verify the **Clock Frequency** matches the target configuration (e.g., `8.000000MHz` or `16.000000MHz`).
6. Click **Play** (bottom-left toolbar) or press `F12` to run the real-time simulation.
7. Interact with input devices (DIP switches, matrix keypads, potentiometers) and observe dynamic outputs across LED arrays, 7-segment displays, and the **Proteus Virtual Terminal / Digital Oscilloscope**.

---

## 📜 Academic Disclaimer
The source code, schematics, and simulation models in this repository are maintained for portfolio, archival, and educational reference purposes.