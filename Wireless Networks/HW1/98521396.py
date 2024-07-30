import numpy as np
from cProfile import label
import matplotlib.pyplot as plt
import math

x1= np.arange(0,50,0.1)

l=[]
for i in x1:
    l.append(math.log(1+10**(i/10),2))

plt.xlabel('SNR - axis')

plt.ylabel('CAPACITY - axis')
plt.plot(x1,l,label="shanon")

points = [13,17,20,23,26,29,32,36,38]
symbol = [2,3,4,5,6,7,8,9,10]
j=0

for i in points:
    plt.scatter(points,symbol,label=f"{2**symbol[j]} -Qam(BER=10^-6)",marker='*',color="red",s=50)
    j+=1
plt.legend()
plt.show()