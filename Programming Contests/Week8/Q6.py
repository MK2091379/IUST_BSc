from collections import deque
def bfs(graph, start):
    visited = set()
    queue = deque([(start, 0)])
    max_distance = 0
    max_node = start
    while queue:
        node, distance = queue.popleft()
        if node not in visited:
            visited.add(node)
            if distance > max_distance:
                max_distance = distance
                max_node = node
            for neighbor in graph[node]:
                if neighbor not in visited:
                    queue.append((neighbor, distance + 1))
    return max_node, max_distance

def tree_diameter(n, edges):
    graph = [[] for _ in range(n)]
    for u, v in edges:
        graph[u-1].append(v-1)
        graph[v-1].append(u-1)
    u, _ = bfs(graph, 0)
    _, diameter = bfs(graph, u)
    return diameter
n = int(input())
edges = []
for i in range(n-1):
    x , y = map(int,input().split())
    temp = [x,y]
    edges.append(temp)
print(tree_diameter(n, edges))