# Data Communication

A comprehensive suite of digital and analog data communication system simulations implemented in **MATLAB** and **GNU Octave**. This repository models the end-to-end physical layer communication pipeline, covering analog-to-digital signal conversion (sampling, uniform/non-uniform quantization, and Pulse Code Modulation [PCM]), baseband line coding, digital passband modulation schemes ($M$-ary ASK, FSK, PSK, QPSK, 16-QAM), AWGN channel characterization, Monte Carlo Bit Error Rate (BER) simulation against theoretical bounds ($Q$-function), and Nyquist pulse shaping with eye diagram analysis.

---

## 🛠 Tech Stack & Toolboxes

- **Environment & Runtimes:** MATLAB (R2020a+), GNU Octave
- **Toolboxes:** Communications Toolbox, Signal Processing Toolbox
- **Core Signal Paradigms:** Pulse Code Modulation (PCM), Baseband Line Coding, Digital Passband Modulation, AWGN Channel Modeling, Matched Filtering, Monte Carlo BER/SER Estimation, Nyquist ISI Criteria & Eye Diagrams

---

## 📁 Repository Structure

### 📚 Physical Layer Simulation Pipeline (`Proj/SeyyedMoein_Kazemi_98521396/`)

| Script | Pipeline Stage | Core Focus & Methodologies |
| :--- | :--- | :--- |
| `step1.m` | **Signal Sampling & PCM** | Nyquist-Shannon sampling verification, uniform/non-uniform quantization, and binary PCM encoding |
| `step2_part1.m` | **Baseband Line Coding** | Unipolar NRZ/RZ, Polar NRZ/RZ, Bipolar AMI, Manchester encoding, and Power Spectral Density (PSD) analysis |
| `step2_part2.m` | **Binary Passband Modulation** | Carrier wave modulation and coherent demodulation for BASK, BFSK, and BPSK |
| `step2_part3.m` | **$M$-ary Digital Modulation** | Multi-level digital modulation (QPSK, 16-QAM), constellation mapping, and I/Q signal decomposition |
| `step3_part1.m` | **Channel & Matched Filtering** | AWGN channel transmission with optimal matched filter and correlation receivers |
| `step3_part2.m` | **Monte Carlo BER/SER** | Empirical error rate calculation across variable Signal-to-Noise Ratio (SNR) and $E_b/N_0$ ranges |
| `step3_part3.m` | **Theoretical Benchmarking** | Performance curves comparing empirical BER against closed-form theoretical bounds ($Q$-function) |
| `step3_part4.m` | **Pulse Shaping & ISI** | Raised Cosine / Root Raised Cosine (RRC) filtering, Inter-Symbol Interference (ISI), and eye diagrams |

---

## 🚀 Getting Started

### Prerequisites
- **MATLAB:** Version R2020a or later with *Communications Toolbox* and *Signal Processing Toolbox*.
- **GNU Octave (Alternative):** Open-source compatibility package.

#### Install Octave Packages (Ubuntu/Debian)
```bash
sudo apt update
sudo apt install octave octave-signal octave-communications
```

---

## 🧪 Simulation & Execution Guide

### 1. Interactive Execution in MATLAB
Open MATLAB, set the working directory to the project source directory, and execute the pipeline steps sequentially:

```matlab
% Navigate to the project directory
cd('Proj/SeyyedMoein_Kazemi_98521396');

% Step 1: Sampling, Quantization & PCM Encoding
run('step1.m');

% Step 2: Line Coding & Digital Modulation Schemes
run('step2_part1.m'); % Baseband Line Codes & PSD
run('step2_part2.m'); % Binary Modulation (BASK, BFSK, BPSK)
run('step2_part3.m'); % M-ary Modulation (QPSK, 16-QAM)

% Step 3: Channel Simulation, BER Analysis & Pulse Shaping
run('step3_part1.m'); % AWGN Channel & Matched Filtering
run('step3_part2.m'); % Monte Carlo BER/SER Estimation
run('step3_part3.m'); % Empirical vs. Theoretical BER Benchmarking
run('step3_part4.m'); % Pulse Shaping Filter & Eye Diagram Analysis
```

---

### 2. Headless CLI Execution

Execute simulations directly from the command line without launching the GUI:

#### Using MATLAB CLI
```bash
cd "Proj/SeyyedMoein_Kazemi_98521396"

# Run BER performance evaluation headless
matlab -batch "step3_part3"
```

#### Using GNU Octave CLI
```bash
cd "Proj/SeyyedMoein_Kazemi_98521396"

# Run BER performance evaluation via Octave
octave --no-gui step3_part3.m
```

---

## 📜 Academic Disclaimer
The source code in this repository is maintained for portfolio, archival, and educational reference purposes.