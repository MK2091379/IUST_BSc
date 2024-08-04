def is_eulerian(n, edges):
    degree = [0] * n
    for u, v in edges:
        degree[u-1] += 1
        degree[v-1] += 1
    for d in degree:
        if d % 2 == 1:
            return "NO"
    return "YES"
n , m = map(int,input().split())
edges = []
for i in range(m):
    x , y = map(int,input().split())
    temp = [x,y]
    edges.append(temp)
print(is_eulerian(n, edges))