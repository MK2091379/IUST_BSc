# Signals & Systems

A comprehensive collection of computational scripts, mathematical simulations, and signal processing workflows developed for the **Signals and Systems** course. Implemented in **MATLAB** and **GNU Octave**, this repository covers Continuous-Time (CT) and Discrete-Time (DT) signal representations, Linear Time-Invariant (LTI) system characterization, time-domain convolution, Continuous-Time Fourier Series (CTFS) harmonic reconstruction, Gibbs phenomenon analysis, Continuous-Time Fourier Transform (CTFT), and frequency-domain filtering.

---

## 🛠 Tech Stack & Toolboxes

- **Environment & Runtimes:** MATLAB (R2018b+), GNU Octave (v6.x+)
- **Toolbox:** Signal Processing Toolbox
- **Core Signal Paradigms:** Continuous-Time (CT) & Discrete-Time (DT) Modeling, LTI Systems & Impulse Responses, Discrete/Continuous Convolution, Fourier Series Decomposition (CTFS), Fourier Transforms (CTFT/DTFT), Harmonic Synthesis & Gibbs Phenomenon, Frequency-Domain Filtering

---

## 📁 Repository Structure

### 📚 Coursework & Simulation Modules

| Directory / Script | Topic & Focus | Core Concepts & Analysis |
| :--- | :--- | :--- |
| `HW1.m` | **Elementary Signals & Operations** | Signal generation, transformations (time shifting, scaling, reversal), unit step, impulse, and complex exponentials |
| `HW2/SayyedMoeinKazemi.m` | **LTI Systems & Convolution** | Impulse response evaluation, numerical convolution, step response simulation, and causality/stability testing |
| `HW3/Fourier_Series.m` | **Fourier Series & Gibbs Effect** | Numerical calculation of CTFS coefficients, harmonic signal synthesis, and Gibbs phenomenon demonstrations |
| `HW3/Question1.m` | **Harmonic Convergence** | Spectral reconstruction and convergence analysis of truncated harmonic series approximations |
| `HW3/Question2.m` | **Spectral Characterization** | Magnitude and phase spectrum profiling across variable fundamental frequencies, periods, and duty cycles |
| `HW4/HW/HW/P-HW.m` | **Fourier Transform & Filtering** | Continuous-Time Fourier Transform (CTFT) analysis, continuous spectra plotting, and Low-Pass/Band-Pass filter design |

---

## 🚀 Getting Started

### Prerequisites
- [MATLAB](https://www.mathworks.com/products/matlab.html) (R2018b or later recommended) with the **Signal Processing Toolbox**.
- [GNU Octave](https://octave.org/) (version 6.x or later) as an open-source alternative.

#### Optional: Install GNU Octave (Ubuntu/Debian)
```bash
sudo apt update
sudo apt install -y octave octave-signal
```

---

## 🧪 Simulation & Execution Guide

### 1. Interactive Execution in MATLAB Desktop
1. Launch **MATLAB**.
2. Set the working directory to the project repository root.
3. Execute the simulation scripts directly in the MATLAB Command Window or Editor:

```matlab
% 1. Run elementary signal operations
run('HW1.m');

% 2. Run LTI system and convolution analysis
run('HW2/SayyedMoeinKazemi.m');

% 3. Run Fourier Series harmonic reconstruction
run('HW3/Fourier_Series.m');
run('HW3/Question1.m');
run('HW3/Question2.m');

% 4. Run Continuous-Time Fourier Transform & filtering
run('HW4/HW/HW/P-HW.m');
```

---

### 2. Headless CLI Execution

Execute simulations directly from the command line without launching the GUI:

#### Using MATLAB CLI
```bash
# Run CTFT and filter simulation
matlab -batch "run('HW4/HW/HW/P-HW.m')"

# Run Fourier Series harmonic synthesis
matlab -batch "run('HW3/Fourier_Series.m')"
```

#### Using GNU Octave CLI
```bash
# Run elementary signals script
octave --no-gui HW1.m

# Run Fourier Series reconstruction
octave --no-gui HW3/Fourier_Series.m
```

---

## 📜 Academic Disclaimer
The simulation scripts and analytical models in this repository are maintained for portfolio, archival, and educational reference purposes.