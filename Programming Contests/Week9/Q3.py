from collections import defaultdict

res = []
test_case_count = input()
test_case_count = int(test_case_count)
_ = 0
while(_<test_case_count):
    graph = defaultdict(list)
    #n , m , s ,t = input().split()
    inputs = input().split()
    for i in range(len(inputs)):
        inputs[i] = int(inputs[i])
    n = inputs[0]
    m = inputs[1]
    s = inputs[2]
    t = inputs[3]
    counter = 0
    while(counter<m):
        inputs = input().split()
        x = 0
        y = 0
        for i in range(len(inputs)):
            inputs[0] = int(inputs[0])
            inputs[1] = int(inputs[1])
        x = inputs[0]
        y = inputs[1]
        i , j = x - 1, y - 1
        graph[i].append(j)
        counter+=1
    visited = []
    for i in range(n):
        visited.append(False)
    open = t - 1
    target = s - 1
    queue = [[open]]
    result = -1
    while queue:
        check = queue.pop(0)
        node = check[-1]
        if not(not(visited[node])):
            continue
        visited[node] = True
        for i in range(len(graph[node])):
            queue.append(check + [graph[node][i]])
            if not(graph[node][i] != target):
                result = len(check)
                queue = []
                break
    _+=1
       
    res.append(result)
for i in res:
    print(i)