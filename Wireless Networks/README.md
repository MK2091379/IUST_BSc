# Wireless Networks

A comprehensive suite of computational models, packet analysis tools, and radio frequency (RF) propagation simulations developed for the **Wireless Networks** course. This repository explores cellular network capacity planning, SNR/SINR link budgets, IEEE 802.11 (Wi-Fi) MAC-layer frame dissection, packet capture inspection via **Scapy**, and 2D indoor RF signal attenuation modeling with wall-attenuation factors for RSSI coverage heatmap synthesis.

---

## 🛠 Tech Stack & Tools

- **Language & Runtime:** Python 3.8+
- **Traffic Analysis & Dissection:** Wireshark, TShark, Scapy, PyShark, PCAP Packet Traces
- **Scientific Computing & Imaging:** NumPy, Matplotlib, Pillow (PIL)
- **Protocols & Wireless Standards:** IEEE 802.11 (Wi-Fi) Protocol Stack, MAC Management/Control/Data Frames (Beacons, Probes, Associations)
- **RF & Propagation Models:** Free-Space Path Loss, Log-Distance Path Loss, Wall Attenuation Factor (WAF), RSSI Heatmap Grid Mapping

---

## 📁 Repository Structure

### 📚 Coursework & Laboratory Modules

| Directory | Topic & Focus | Primary Artifacts |
| :--- | :--- | :--- |
| `HW1/` | Theoretical link-budget calculations, Shannon capacity bounds, and cellular frequency reuse models | `98521396.py` |
| `HW2/` | Monitor-mode IEEE 802.11 packet captures covering management, control, and payload frames | `capturedPackets.pcap` |
| `HW3/` | Automated frame parser dissecting SSIDs, BSSIDs, RSSI values, and transmission metrics | `code.py`, `packets.pcap` |
| `HW4/` | Indoor RF propagation simulation with obstacle-loss modeling and 2D signal heatmap rendering | `test.py`, `house.png`, `output.png` |

---

## 🚀 Getting Started

### Prerequisites
- [Python 3.8+](https://www.python.org/downloads/)
- [Wireshark](https://www.wireshark.org/) (for interactive PCAP traffic inspection)

### Installation
Clone the repository and install the required packet analysis and scientific visualization packages:

```bash
# Clone the repository
git clone <repository_url>
cd <repository_name>

# Install dependencies
pip install scapy numpy matplotlib pillow pyshark
```

---

## 🧪 Execution & Simulation Guide

### 1. Cellular Capacity & Link Budget Calculations
Run the theoretical wireless modeling script:

```bash
cd HW1
python 98521396.py
```

---

### 2. Automated 802.11 Packet Dissection
Execute the Scapy-based PCAP parser to extract network metadata, channel utilization, and RSSI statistics:

```bash
cd HW3/MoeinKazemi_98521396/aaz2/aaz2
python code.py
```

---

### 3. Indoor RF Propagation & Heatmap Generation
Simulate indoor signal attenuation across floor-plan obstacles and export the 2D coverage heatmap:

```bash
cd HW4/Lab3_SayyedMoeinKazemi_98521396/Lab3_SayyedMoeinKazemi_98521396

# Run simulation (processes house.png and generates output.png)
python test.py
```

---

## 📜 Academic Disclaimer
The source code, simulation scripts, and packet captures in this repository are maintained for portfolio, archival, and educational reference purposes.