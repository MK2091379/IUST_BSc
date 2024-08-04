inputs = input()
inputs = inputs.split()
for i in range(len(inputs)):
    inputs[i] = int(inputs[i])
n = inputs[0]
m = inputs[1]
matrix = []
for i in range(n):
    matrix.append([])
    for j in range(n):
        matrix[i].append(0)
_ = 0
while(_<m):
    inputs = input()
    inputs = inputs.split()
    for i in range(len(inputs)):
        inputs[i] = int(inputs[i])
    x = inputs[0]
    y = inputs[1]
    x -= 1
    y -= 1
    matrix[x][y] = 1
    matrix[y][x] = 1
    _+=1
i = 0
while(i<len(matrix)):
    j = 0
    while(j<len(matrix[i])):
        print(matrix[i][j], end='')
        j+=1
    print()
    i+=1