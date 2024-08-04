from collections import defaultdict

n = input()
n = int(n)
s = input()

graph = defaultdict(list)
i = 0
while(i<len(s)):
    next_ind = s.rfind(s[i],i+1)
    if not(next_ind == i or next_ind == -1):
        graph[i].append(next_ind)
    i+=1
i = 0
while(i<n):
    if not(i <= 0):
        graph[i].append(i-1)
    if not(i >= n - 1):
        graph[i].append(i+1)
    i+=1
    


queue = [(0, 0)]
visited = [False for i in range(n)]
visited[0] = True
results = list()
while queue:
    u, dist = queue.pop(0)
    if not(u != n-1):
        results.append(dist)
    for i in range(len(graph[u])):
        if not(visited[graph[u][i]]):
            visited[graph[u][i]] = True
            queue.append((graph[u][i], dist+1))
print(min(results))