from sys import setrecursionlimit
from threading import stack_size
setrecursionlimit(10**6)
stack_size(2**27)
def DepthFirstSerach(u, isVisited):
    global result, graph
    isVisited[u] = True
    currComponentNode = 0
    for i in range(len(graph[u])):
        v = graph[u][i]
        if (not isVisited[v]):
            subtreeNodeCount = DepthFirstSerach(v, isVisited)
            if (subtreeNodeCount % 2 == 0):
                result += 1
            else:
                currComponentNode += subtreeNodeCount
    return (currComponentNode + 1)
def func(N):
    isVisited = [False for i in range(N + 1)]
    DepthFirstSerach(0, isVisited)
    return result
n = int(input())
x = "0"
result = 0
edges = []
for i in range(n-1):
    x = input()
    y = list(map(int,x.split()))
    if(x!=""):
        edges.append(y)
    else:
        break
N = len(edges)
graph = [[] for i in range(n+1)]     
for i in range(N):
    graph[edges[i][0]].append(edges[i][1])
    graph[edges[i][1]].append(edges[i][0])
if(n%2==0):
    print(func(N))
else:
    print("-1")