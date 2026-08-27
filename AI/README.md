# Artificial Intelligence

A comprehensive suite of foundational and advanced Artificial Intelligence projects implemented in Python, based on the **UC Berkeley CS188 Pacman AI** framework. This repository explores classical search algorithms, adversarial multi-agent systems, reinforcement learning, probabilistic state estimation, Hidden Markov Models (HMMs), Bayesian networks, and custom neural network architectures.

---

## 🛠 Tech Stack

- **Language:** Python
- **Libraries & Modules:** NumPy, Tkinter (GUI)
- **AI Domains:** State-Space Search, Game Theory, Reinforcement Learning, Probabilistic Graphical Models, Machine Learning & Neural Networks

---

## 📁 Repository Structure

| Directory | Focus & Core Concepts | Key Modules / Topics |
| :--- | :--- | :--- |
| `Project 0/tutorial/` | Python fundamentals, data structures, autograder workflows | `addition.py`, `buyLotsOfFruit.py`, `shop.py` |
| `Project 1/search/` | State-space search algorithms & heuristic pathfinding | `DFS`, `BFS`, `UCS`, `A* Search`, Manhattan Heuristics |
| `Project 2/multiagent/` | Adversarial games & multi-agent decision making | `Minimax`, `Alpha-Beta Pruning`, `Expectimax`, Evaluation Functions |
| `Project 3/reinforcement/` | Model-based and model-free Reinforcement Learning | `Value Iteration`, `Q-Learning`, `Approximate Q-Learning` |
| `Project 4/tracking/` | Probabilistic state estimation & hidden state inference | `Exact Inference (Forward Algorithm)`, `Particle Filtering`, `Joint Particle Filtering` |
| `Project 5/machinelearning/` | Supervised learning & neural network architectures | Non-linear Regression, Digit Recognition (MNIST), Language ID |

---

## 🚀 Getting Started

### Prerequisites
- Python (v3.6+)
- NumPy (for Machine Learning tasks)
- Tkinter (standard with most Python installations for GUI visualization)

---

## 🧪 Execution & Simulation

### 1. Running the Automated Testing Suite
Each project includes an automated test framework (`autograder.py`) to validate algorithmic correctness against predefined test cases.

```bash
# Run the complete test suite for a project
python autograder.py

# Run a specific question or test case
python autograder.py -q <QuestionNumber>
```

---

### 2. Interactive Simulations & Demos

#### Project 1 — Search Algorithms
```bash
cd "Project 1/search"

# Run A* Search with Manhattan Heuristic
python pacman.py -l mediumMaze -p SearchAgent -a fn=astar,heuristic=manhattanHeuristic
```

#### Project 2 — Multi-Agent Adversarial Games
```bash
cd "Project 2/multiagent"

# Run Minimax Agent
python pacman.py -p MinimaxAgent -l minimaxClassic -a depth=3

# Run Alpha-Beta Pruning Agent (headless over 10 iterations)
python pacman.py -p AlphaBetaAgent -l trappedClassic -a depth=3 -q -n 10
```

#### Project 3 — Reinforcement Learning
```bash
cd "Project 3/reinforcement"

# Value Iteration on Gridworld
python gridworld.py -a value -i 100 -k 10

# Q-Learning with Epsilon-Greedy Exploration
python pacman.py -p PacmanQAgent -x 2000 -n 2010 -l smallGrid

# Approximate Q-Learning with Linear Feature Extractors
python pacman.py -p ApproximateQAgent -a extractor=SimpleExtractor -x 50 -n 60 -l mediumGrid
```

#### Project 4 — Ghostbusters (Probabilistic State Tracking)
```bash
cd "Project 4/tracking"

# Exact Inference (Forward Algorithm)
python busters.py -p ExactInference -l bigHunt

# Particle Filtering
python busters.py -p ParticleFilter -k 300 -l oneHunt
```

#### Project 5 — Machine Learning & Neural Networks
```bash
cd "Project 5/machinelearning"

# Run Neural Network Digit Classification (MNIST)
python autograder.py -q q2

# Run Language Identification Model
python autograder.py -q q4
```

---

## 📜 Academic Disclaimer
The source code in this repository is maintained for portfolio, archival, and educational reference purposes.