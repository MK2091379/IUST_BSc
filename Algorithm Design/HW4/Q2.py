from sys import setrecursionlimit
from threading import stack_size
setrecursionlimit(10**6)
stack_size(2**27)
class MPST:
    vertex = 0
    parent = []
    value_min = []
    ismsp = []
    def __init__(self,vertex):
        self.vertex = vertex
        self.parent = [None for i in range(vertex)]
        self.value_min =[None for i in range(vertex)]
        self.ismsp = [None for i in range(vertex)]
        for i in range(vertex):
            self.value_min[i] = 9999999
            self.ismsp[i] = False
        self.value_min[0] = 0
    def GetmeMinimumWeightiIndex(self):
        minimumWeight = 999999.0
        index = 0
        for i in range(self.vertex):
            if(self.ismsp[i] == False and self.value_min[i]<minimumWeight):
                minimumWeight = self.value_min[i]
                index = i
        return index
    def mpst(self,maingraph):
        p = 1
        for i in range(self.vertex-1):
            index = self.GetmeMinimumWeightiIndex()
            self.ismsp[index] = True
            for j in range(self.vertex):
                if(maingraph[index][j]>0 and self.ismsp[j]==False and maingraph[index][j]<self.value_min[j]):
                    self.value_min[j] =maingraph[index][j]
                    self.parent[j] = index
        for i in range(self.vertex):
            if self.parent[i] != None:
                p *= maingraph[i][self.parent[i]]
        return p

num = int(input())
matrix_adj = [[None for i in range(num)] for j in range(num)]
graph_log = [[None for i in range(num)] for j in range (num)]
for i in range(num):

    inputs =input().split()
    for j in range(num):
        matrix_adj[i][j] = int(inputs[j])  
pro = MPST(num)
print(pro.mpst(matrix_adj))