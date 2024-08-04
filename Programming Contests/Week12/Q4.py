from collections import defaultdict

def count_cycles(graph):
    def dfs(v, visited, stack):
        nonlocal count
        visited[v] = True
        stack[v] = True
        for u in graph[v]:
            if not visited[u]:
                dfs(u, visited, stack)
            elif stack[u]:
                count += 1
        stack[v] = False

    count = 0
    visited = [False] * n
    stack = [False] * n
    for v in range(n):
        if not visited[v]:
            dfs(v, visited, stack)
    return count

n, m = map(int, input().split())
edges = [tuple(map(int, input().split())) for _ in range(m)]

graph = defaultdict(list)
for u, v in edges:
    graph[u - 1].append(v - 1)
    graph[v - 1].append(u - 1)

print(count_cycles(graph))
