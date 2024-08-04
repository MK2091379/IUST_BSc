inputs = list(map(int,input().split()))
k = inputs[1]
n = inputs[0]
from math import comb
C = comb(n, k) % ((10**9)+7)
print(int(C))