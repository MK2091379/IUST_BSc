res = []
inputs = input()
inputs = inputs.split()
for i in range(len(inputs)):
    inputs[i] = int(inputs[i])
n = inputs[0]
m = inputs[1]
dict = dict()
_ = 0
while(_<m):
    inputs = input()
    inputs = inputs.split()
    for i in range(len(inputs)):
        inputs[i] = inputs[i]
    x = inputs[0]
    y = inputs[1]
    dict[x + '_' + y] = 1
    _+=1

q = input()
q = int(q)
_ = 0
while(_<q):
    inputs = input()
    inputs = inputs.split()
    for i in range(len(inputs)):
        inputs[i] = inputs[i]
    x = inputs[0]
    y = inputs[1]
    if not(dict.get(x + '_' + y, 0) != 1 and dict.get(y + '_' + x, 0) != 1):
        res.append("NO")
    else:
        res.append("YES")
    _+=1
for i in res:
    print(i)