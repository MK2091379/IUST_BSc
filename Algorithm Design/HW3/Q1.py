from sys import setrecursionlimit
from threading import stack_size
setrecursionlimit(10**6)
stack_size(2**27)
inputs = [int(i) for i in input().split(", ")]
n = inputs[0]
start = inputs[1]
m1 = inputs[2]
m2 = inputs[3]
pointer = 0
l = []
l.append(start)
while(True):
    if(0<l[pointer] + m1 <= n):
        if(l[pointer] + m1 not in l):
            l.append(l[pointer] + m1)
    if(0<l[pointer] - m1 <= n):
        if(l[pointer] - m1 not in l):
            l.append(l[pointer] - m1)
    if(0<l[pointer] + m2 <= n):
        if(l[pointer] + m2 not in l):
            l.append(l[pointer] + m2)
    if(0<l[pointer] - m2 <= n):
        if(l[pointer] - m2 not in l):
            l.append(l[pointer] - m2)
    pointer+=1
    if(pointer>=len(l)):
        break
l.sort()
print(len(l))
for i in l:
    print(i,end = " ")
print()