from collections import deque

def bfs(graph, start):
    visited = set()
    queue = deque([(start, 0)])
    distances = [0] * len(graph)
    while queue:
        node, distance = queue.popleft()
        if node not in visited:
            visited.add(node)
            distances[node] = distance
            for neighbor in graph[node]:
                if neighbor not in visited:
                    queue.append((neighbor, distance + 1))
    return distances

def tree_diameter(n, edges):
    graph = [[] for _ in range(n)]
    for u, v in edges:
        graph[u-1].append(v-1)
        graph[v-1].append(u-1)
    u = bfs(graph, 0).index(max(bfs(graph, 0)))
    v = bfs(graph, u).index(max(bfs(graph, u)))
    return u, v

def connected_components(n, edges):
    u, v = tree_diameter(n, edges)
    graph = [[] for _ in range(n)]
    for x, y in edges:
        graph[x-1].append(y-1)
        graph[y-1].append(x-1)
    d1 = bfs(graph, u)
    d2 = bfs(graph, v)
    result = []
    for k in range(1, n+1):
        count = 0
        for w in range(n):
            if d1[w] >= k and d2[w] >= k:
                count += 1
        result.append(count)
    return result
n = int(input())
edges = []
for i in range(n-1):
    x , y = map(int,input().split())
    temp = [x,y]
    edges.append(temp)
s = connected_components(n, edges)
for i in s:
    print(i,end=' ')