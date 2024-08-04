from collections import defaultdict
res = []
n, q = map(int, input().split())
adj = defaultdict(list)
depth = [0] * (n + 1)
parent = [0] * (n + 1)

parents = list(map(int, input().split()))
for i in range(2, n + 1):
    p = parents[i - 2]
    adj[p].append(i)
    adj[i].append(p)

def dfs(u, p):
    parent[u] = p
    for v in adj[u]:
        if v == p:
            continue
        depth[v] = depth[u] + 1
        dfs(v, u)

def lca(u, v):
    while u != v:
        if depth[u] > depth[v]:
            u, v = v, u
        v = parent[v]
    return u

dfs(1, 0)
for _ in range(q):
    u, v = map(int, input().split())
    res.append(lca(u, v))
for i in res:
    print(i)