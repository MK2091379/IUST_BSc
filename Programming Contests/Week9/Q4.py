from collections import deque

n, m = map(int, input().split())
a = list(map(int, input().split()))

graph = [[] for _ in range(n)]
for _ in range(m):
    u, v = map(int, input().split())
    graph[u - 1].append(v - 1)
    graph[v - 1].append(u - 1)

def bfs(start):
    visited = [False] * n
    q = deque([start])
    visited[start] = True
    power = a[start]
    while q:
        u = q.popleft()
        for v in graph[u]:
            if not visited[v]:
                if power > a[v]:
                    power += a[v]
                    visited[v] = True
                    q.append(v)
                else:
                    return max(0, a[v] - power + 1)
    return 0

for i in range(n):
    print(bfs(i), end=' ')
