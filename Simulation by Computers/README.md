# Computer Simulation

A comprehensive discrete-event simulation (DES) framework and queueing theory modeling suite developed for the **Computer Simulation** course. This repository explores stochastic process modeling, pseudo-random variate generation, event scheduling algorithms, simulation clock advancement mechanisms, and empirical performance evaluation for single-server queueing systems ($M/M/1$), validating empirical wait times, queue lengths, and server utilization against theoretical queueing formulations (Little's Law).

---

## 🛠 Tech Stack

- **Language & Runtime:** Python 3.8+
- **Interactive Computing:** Jupyter Notebook / JupyterLab
- **Scientific Computing & Visualization:** NumPy, Matplotlib
- **Simulation & Stochastic Paradigms:** Discrete-Event Simulation (DES), Event Scheduling & State-Space Tracking, $M/M/1$ Queueing Dynamics, Little's Law, Monte Carlo Estimation

---

## 📁 Repository Structure

### 📚 Simulation Engine & Analytical Notebooks

| Script / Notebook | Module Type | Focus & Core Methodologies |
| :--- | :--- | :--- |
| `main.py` | **Core DES Engine** | Event-driven state transitions, customer arrival/departure processing, future event list (FEL) management, and statistical accumulator tracking |
| `SingleServerQueue.ipynb` | **Interactive Modeling** | Parametric $M/M/1$ queue experiments across varying arrival ($\lambda$) and service ($\mu$) rates, theoretical vs. empirical distribution comparisons, and steady-state convergence analysis |

---

## 🚀 Getting Started

### Prerequisites
- [Python 3.8+](https://www.python.org/downloads/)

### Installation & Environment Setup
Clone the repository and install the required numerical computing and visualization packages:

```bash
# Clone the repository
git clone <repository_url>
cd <repository_name>

# Install dependencies
pip install numpy matplotlib jupyter jupyterlab
```

---

## 🧪 Execution & Simulation Guide

### 1. Running the Standalone DES Engine
Execute the command-line discrete-event simulation engine to run standard queueing experiments and view summary metrics:

```bash
python main.py
```

---

### 2. Interactive Exploration via Jupyter Notebook
Launch JupyterLab or Jupyter Notebook to run parametric experiments, analyze transient vs. steady-state behavior, and plot distribution curves:

```bash
jupyter lab
# or
jupyter notebook SingleServerQueue.ipynb
```

---

### 3. Headless Notebook Execution
To execute and evaluate the simulation notebook directly from the command line:

```bash
jupyter nbconvert --to notebook --execute SingleServerQueue.ipynb
```

---

## 📜 Academic Disclaimer
The simulation scripts and analytical models in this repository are maintained for portfolio, archival, and educational reference purposes.