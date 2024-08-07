# -*- coding: utf-8 -*-
"""HW1_SayyedMoeinKazemi_98521396.ipynb

Automatically generated by Colaboratory.

Original file is located at
    https://colab.research.google.com/drive/1CRZieAWwv-YsWFYROJiBUyARo4x93g-p
"""
from sys import setrecursionlimit,stdin,maxsize
from threading import stack_size
from numpy import array, zeros
setrecursionlimit(10**6)
stack_size(2**27)
def minCost(array, k): 
    length = len(array)
    x= list()
    x = [maxsize] * (length) 
    x[0] = 0
    i = 0
    while i<length: 
        j = i+1
        while j < i + k + 1 and j < length: 
            x[j] = min(x[j], x[i] + abs(array[i] - array[j]))
            j += 1
        i+=1
    return x[length - 1] 
l = [int(i) for i in input().split()]
array = [int(i) for i in input().split()] 
print(minCost(array,l[1]))