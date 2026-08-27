# Cybersecurity

A comprehensive suite of applied cybersecurity implementations and cryptographic systems developed in **Python**. This repository covers foundational and modern cryptographic primitives, symmetric and asymmetric encryption algorithms, cryptographic hash functions, Message Authentication Codes (MACs), Public-Key Infrastructure (PKI), digital signatures, and the implementation of an end-to-end secure peer-to-peer communication protocol over network sockets.

---

## 🛠 Tech Stack

- **Language & Runtime:** Python 3.8+
- **Cryptographic Libraries:** `pycryptodome`, `cryptography`
- **Networking:** Python `socket` API (TCP/IP)
- **Symmetric Cryptography:** AES, DES, 3DES, Block Cipher Modes (CBC, CTR, ECB), PKCS#7 Padding
- **Asymmetric Cryptography:** RSA (Key Generation, Modular Arithmetic), Diffie-Hellman Key Agreement
- **Integrity & Authentication:** SHA-256, HMAC, Digital Signatures

---

## 📁 Repository Structure

### 📚 Coursework & Projects
| Directory | Focus & Cryptographic Paradigms | Primary Modules / Scripts |
| :--- | :--- | :--- |
| `MiniProj1/` | Symmetric encryption, block cipher modes (CBC, CTR, ECB), PKCS#7 padding, and hash-based integrity verification | `main.py` |
| `MiniProj2/` | Public-key cryptography, RSA key generation, modular arithmetic, Diffie-Hellman key exchange, and digital signatures | `main.py` |
| `FinalProj/` | Secure peer-to-peer encrypted socket channel with automated key exchange, session derivation, and authenticated handshakes | `UserA.py`, `UserB.py` |

---

## 🚀 Getting Started

### Prerequisites
- [Python 3.8+](https://www.python.org/downloads/)

### Installation & Environment Setup
Clone the repository, create a virtual environment, and install the required dependencies:

```bash
# Create and activate a virtual environment
python -m venv venv

# On Linux/macOS:
source venv/bin/activate
# On Windows:
venv\Scripts\activate

# Install required cryptographic libraries
pip install pycryptodome cryptography
```

---

## 🧪 Execution Guide

### 1. Running Mini Projects

#### Mini Project 1: Symmetric Encryption & Hashing
```bash
cd "MiniProj1"
python main.py
```

#### Mini Project 2: Public-Key Cryptography & Key Exchange
```bash
cd "../MiniProj2"
python main.py
```

---

### 2. Running Final Project: Secure Peer-to-Peer Protocol
The final project simulates an encrypted, tamper-proof communication channel across a TCP socket between two independent endpoints (**User A** and **User B**).

1. **Terminal 1 (Host / Receiver - User A):**
   ```bash
   cd "FinalProj"
   python UserA.py
   ```

2. **Terminal 2 (Client / Initiator - User B):**
   ```bash
   cd "FinalProj"
   python UserB.py
   ```

3. **Verification:**
   Observe the automated cryptographic handshake, public key exchange, shared secret generation via Diffie-Hellman, and subsequent authenticated message transmission across the socket interface.

---

## 📜 Academic Disclaimer
The source code in this repository is maintained for portfolio, archival, and educational reference purposes.