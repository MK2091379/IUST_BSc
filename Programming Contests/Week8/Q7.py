def dfs(graph, u, visited):
    for v in graph[u]:
        visited[v] += 1
        if visited[v] > 1:
            return False
        if not dfs(graph, v, visited):
            return False
    return True

def check_simple_paths(v, edges):
    graph = [[] for _ in range(v)]
    for u, w in edges:
        graph[u-1].append(w-1)
    for u in range(v):
        visited = [0] * v
        if not dfs(graph, u, visited):
            return "No"
    return "Yes"
v,e = map(int,input().split())
edges = []
for i in range(e):
    x , y = map(int,input().split())
    temp = [x,y]
    edges.append(temp)
print(check_simple_paths(v, edges))