# Computer Vision & Digital Image Processing

A comprehensive collection of computer vision algorithms, digital image processing pipelines, and deep learning implementations developed for the **Computer Vision** coursework. This repository covers spatial and frequency domain transformations, morphological filtering, feature extraction and matching (SIFT/ORB), homography and panorama stitching, classical image segmentation, optical flow tracking, and Convolutional Neural Networks (CNNs) in **PyTorch**.

---

## 🛠 Tech Stack

- **Language & Runtime:** Python 3.10+
- **Interactive Computing:** JupyterLab / Jupyter Notebook
- **Core Vision & Image Processing:** OpenCV (`cv2`), Scikit-image (`skimage`), NumPy, SciPy
- **Deep Learning & Modeling:** PyTorch, Torchvision, Scikit-learn
- **Visualization:** Matplotlib, Seaborn

---

## 📁 Repository Structure

### 📚 Homework & Laboratory Modules
| Directory | Focus & Core Methodologies | Key Topics & Algorithms |
| :--- | :--- | :--- |
| `HW1/` | Spatial domain processing & color spaces | Color space conversions (RGB/HSV/Gray), histogram equalization, 2D spatial convolutions |
| `HW2/` | Frequency domain analysis & medical imaging | 2D Fast Fourier Transform (FFT), Ideal/Butterworth/Gaussian filters, aortic angiogram contrast enhancement |
| `HW3/` | Edge detection & feature extraction | Sobel, Laplacian of Gaussian (LoG), Canny edge detector, Hough Transform (lines/circles), Harris Corner Detection |
| `HW4/` | Feature matching & geometric transformations | SIFT, ORB, FLANN/BFMatcher, RANSAC outlier rejection, planar homography, image stitching |
| `HW5/` | Classical image segmentation | Otsu thresholding, K-Means color clustering, region growing, Watershed algorithm |
| `HW6/` | Deep learning for visual recognition | Custom CNN architectures, PyTorch pipelines, transfer learning, feature map activations |
| `HW7/` | Motion analysis & semantic segmentation | Dense/sparse optical flow (Lucas-Kanade, Horn-Schunck), object tracking, semantic segmentation models |

### 🔬 Capstone Project
| Directory | Focus & Architecture | Primary Artifacts |
| :--- | :--- | :--- |
| `PROJ/` | End-to-end computer vision research pipeline integrating classical processing and deep learning | Source scripts, model weights, experiment notebooks |

---

## 🚀 Getting Started

### Prerequisites & Environment Setup
It is recommended to use [Conda](https://docs.conda.io/en/latest/) to manage dependencies and avoid binary conflicts with OpenCV and PyTorch.

```bash
# 1. Create and activate a dedicated conda environment
conda create -n cv-env python=3.10 -y
conda activate cv-env

# 2. Install core dependencies and acceleration libraries
pip install numpy scipy opencv-python matplotlib scikit-image scikit-learn torch torchvision jupyterlab
```

---

## 🧪 Execution Guide

### 1. Interactive Exploration via JupyterLab
Launch JupyterLab from the root of the repository to explore the notebooks interactively:

```bash
jupyter lab
```

---

### 2. Headless Notebook Execution
To execute and evaluate individual notebooks directly from the terminal without launching the browser UI:

```bash
# Execute Homework 1 (Spatial Domain Processing)
jupyter nbconvert --to notebook --execute "HW1/hw1/ComputerVision_HW1.ipynb"

# Execute Homework 2 (Frequency Domain & Angiogram Enhancement)
jupyter nbconvert --to notebook --execute "HW2/Homework 2/Aortic angiogram processing.ipynb"

# Execute Homework 3 (Edge Detection & Feature Extraction)
jupyter nbconvert --to notebook --execute "HW3/hw3/Q2.ipynb"
```

---

## 📜 Academic Disclaimer
The source code in this repository is maintained for portfolio, archival, and educational reference purposes.