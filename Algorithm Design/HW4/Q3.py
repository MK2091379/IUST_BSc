
class MST:
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
    def mst(self,maingraph):
        p = 0
        for i in range(self.vertex):
            index = self.GetmeMinimumWeightiIndex()
            self.ismsp[index] = True
            for j in range(self.vertex):
                if(maingraph[index][j]>0 and self.ismsp[j]==False and maingraph[index][j]<self.value_min[j]):
                    self.value_min[j] =maingraph[index][j]
                    self.parent[j] = index
        for i in range(self.vertex):
            if self.parent[i] != None:
                p += maingraph[i][self.parent[i]]
        return p
def manhaManhattan_Distance(point1,point2):
    return abs(point1[0] - point2[0]) + abs(point1[1] - point2[1])
num = int(input())
point = [None for i in range(num)]
matrix_adj =[[None for i in range(num)] for j in range(num)]
for i in range(num):
    poin = input().split()
    x = int(poin[0])
    y = int(poin[1])
    point[i] = [x,y]
for i in range(num):
    for j in range(num):
        matrix_adj[i][j] = manhaManhattan_Distance(point[i], point[j])
pro = MST(num)
print(pro.mst(matrix_adj))