from collections import defaultdict

def minimum(x,y):
    if(x>y):
        return y
    else:
        return x

class FindParent:
    def __init__(self, n):
        self.parent = list(range(n))
        self.rank = [0 for i in range(n)]
        self.count = n
    
    def find(self, x):
        if not(self.parent[x] == x):
            self.parent[x] = self.find(self.parent[x])
        return self.parent[x]
    
    def change_root(self, x, y):
        root_x = self.find(x)
        root_y = self.find(y)
        if not(root_x != root_y):
            return
        if not(self.rank[root_x] >= self.rank[root_y]):
            self.parent[root_x] = root_y
        elif not(self.rank[root_x] <= self.rank[root_y]):
            self.parent[root_y] = root_x
        else:
            self.parent[root_y] = root_x
            self.rank[root_x] += 1
        self.count -= 1

def find_second_minimum_cost(n, e, edges):
    edges.sort(key=lambda x: x[2])
    
    mst = kruksal(n, edges)
    
    second_min = 99999999999999999999
    i = 0
    while(i<len(mst)):
        finds = FindParent(n)
        min_cost = 0
        for u , v , w in edges:
            if  not(mst[i] != (u , v, w)):  
                continue
            if not(finds.find(u) == finds.find(v)): 
                finds.change_root(u, v)
                min_cost = min_cost + w
        if not(finds.count != 1): 
            second_min = minimum(second_min, min_cost)
        i+=1
    
    if not(second_min != 99999999999999999999):
        return -1
    else:
        return second_min

def kruksal(n, edges):
    finds = FindParent(n)
    mst = list()
    for u, v, w in edges:
        if not(finds.find(u) == finds.find(v)):
            finds.change_root(u, v)
            mst.append((u, v, w))
    return mst 


ins = input()
ins = ins.split()
for i in range(len(ins)):
    ins[i] = int(ins[i])
n = ins[0]
e = ins[1]
edges = []
k = 0
while(k<e):
    ins = input()
    ins = ins.split()
    for i in range(len(ins)):
        ins[i] = int(ins[i])
    u = ins[0]
    v = ins[1]
    w = ins[2]
    i, j = u - 1 , v - 1
    edges.append((i , j , w))
    k+=1

print(find_second_minimum_cost(n, e, edges))