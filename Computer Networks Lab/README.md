# Computer Networks Lab

A comprehensive repository of hands-on laboratory implementations, network topology configurations, and performance analyses developed for the **Computer Networks Laboratory** course. This repository focuses on Software-Defined Network (SDN) emulation using **Mininet**, low-level POSIX socket programming in **C**, Layer 2/3 device characterization, kernel-level packet filtering with `iptables`, Man-in-the-Middle (MITM) simulations, TCP/UDP throughput vs. goodput benchmarking, and dynamic routing configurations using the **Quagga** routing suite.

---

## 🛠 Tech Stack & Tools

- **Languages & Toolchains:** C (POSIX Sockets, Network System Calls), Python (Mininet API), GCC, GNU Make
- **Network Emulation & Routing:** Mininet, Open vSwitch, Quagga Routing Suite (Zebra Kernel Manager, RIPv2 / `ripd`)
- **Kernel Networking & Security:** Linux Networking (`iptables`, `sysctl`, `iproute2`), Reverse Path Filtering (RPF), NAT / IP Masquerading
- **Protocol Analysis & Inspection:** Wireshark, `tcpdump`

---

## 📁 Repository Structure

### 📚 Laboratory Modules
| Directory | Focus & Network Paradigms | Key Artifacts |
| :--- | :--- | :--- |
| `az 1 - File Python Avalie/` | Mininet Python API fundamentals and custom LAN topology generation | `lanTopology.py` |
| `az 2 - MITM/` | Man-in-the-Middle (MITM) attacks, ARP cache poisoning, and RPF kernel management | `disableRPF.sh`, `lanConfig.py` |
| `az 3 - Network Devices/` | Collision vs. broadcast domains across Hubs, Switches, and Multi-Subnet Routers | `topo1.py`, `topo2.py` |
| `az 4 - NAT/` | Network Address Translation (NAT) & IP masquerading via `iptables` rules | `topo2_int.py` |
| `az5 - TCP UDP Conjestion_Points/` | C socket programming (TCP/UDP), packet loss, and buffer congestion analysis | `Makefile`, `tcpserver`, `tcpclient`, `lab5_network.py` |
| `az6 - TCP UDP FLOW and Goodput/` | Sliding window flow dynamics, bottleneck latency, and throughput vs. goodput metrics | `lab6_network.py` |
| `az7 - Quaga and Routing/` | Dynamic Autonomous System routing using Quagga (Zebra & RIP daemon) | `lab7_network.py` |

---

## 🚀 Getting Started

### Prerequisites
Ensure your environment (Ubuntu/Debian Linux recommended) has Mininet, Open vSwitch, Quagga, and standard build utilities installed:

```bash
sudo apt update
sudo apt install -y mininet openvswitch-switch quagga quagga-doc wireshark tcpdump build-essential
```

---

## 🧪 Execution & Simulation Guide

### Lab 1: Custom LAN Topology Generation
```bash
cd "az 1 - File Python Avalie"
sudo python lanTopology.py
```

---

### Lab 2: MITM & Reverse Path Filtering (RPF)
```bash
cd "az 2 - MITM"

# Disable Reverse Path Filtering on the Linux kernel
sudo bash disableRPF.sh

# Launch the MITM network topology
sudo python lanConfig.py
```

---

### Lab 3: Layer 2 & Layer 3 Network Device Characterization
```bash
cd "az 3 - Network Devices"

# Topology 1: Hub vs. Switch domain analysis
sudo python topo1.py

# Topology 2: Multi-subnet routing and IP forwarding
sudo python topo2.py
```

---

### Lab 4: Network Address Translation (NAT)
```bash
cd "az 4 - NAT"
sudo python topo2_int.py
```

---

### Lab 5: TCP & UDP Congestion Analysis

#### 1. Compile C Sockets
```bash
# Build TCP client/server binaries
cd "az5 - TCP UDP Conjestion_Points/lab5/tcp"
make

# Build UDP client/server binaries
cd "../udp"
make
```

#### 2. Launch Topology & Execute Sockets
```bash
cd ".."
sudo python lab5_network.py
```
*Inside the Mininet CLI / node terminal windows:*
```bash
# On Server Node:
./tcpserver <Port>

# On Client Node:
./tcpclient <Server_IP> <Port>
```

---

### Lab 6: TCP/UDP Flow Control & Goodput Optimization
```bash
cd "az6 - TCP UDP FLOW and Goodput"
sudo python lab6_network.py
```

---

### Lab 7: Dynamic Routing with Quagga (RIPv2 & Zebra)
```bash
cd "az7 - Quaga and Routing/lab7"
sudo python lab7_network.py
```

---

### 🧹 Environment Cleanup
If a Mininet simulation crashes or interfaces remain locked, clean the virtual bridges and controller processes:

```bash
sudo mn -c
```

---

## 📜 Academic Disclaimer
The source code in this repository is maintained for portfolio, archival, and educational reference purposes.