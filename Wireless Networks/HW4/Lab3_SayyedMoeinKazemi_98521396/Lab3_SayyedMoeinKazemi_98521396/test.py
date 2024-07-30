import numpy as np
import matplotlib.pyplot as plt
import matplotlib.image as mpimg
Xs = []
Ys = []
rssi = []
with open("logs.txt") as file:
    for line in file:
        splited = line.split(',')
        Xs.append(int(splited[0]))
        Ys.append(int(splited[1]))
        rssi.append(int(splited[2]))
Xs = np.array(Xs)
Ys = np.array(Ys)
print(Xs)
img = mpimg.imread('house.png')
fig, ax = plt.subplots()
plt.imshow(img)
plt.scatter(Xs, Ys, c='g')
for index, coo in enumerate(rssi):
    ax.annotate(coo, (Xs[index], Ys[index]))
