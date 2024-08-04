n = int(input())
edges = [tuple(map(int, input().split())) for _ in range(n - 1)]

tree = [[] for _ in range(n)]
for u, v in edges:
    tree[u - 1].append(v - 1)
    tree[v - 1].append(u - 1)

subtree_size = [0] * n

def dfs(node, parent):
    subtree_size[node] = 1
    for child in tree[node]:
        if child != parent:
            dfs(child, node)
            subtree_size[node] += subtree_size[child]

dfs(0, -1)

result = 0
for size in subtree_size[1:]:
    if size % 2 == 0:
        result += 1

print(result if n % 2 == 0 else -1)
