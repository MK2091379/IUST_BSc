inputs = input().split()
n_bottles = int(inputs[0])
liquid_capacity = int(inputs[1])
bottles_capacity = []
for i in range(n_bottles):
    bottles_capacity.append(int(input()))
if(liquid_capacity<=sum(bottles_capacity)):
    print('YES')
else:
    print('NO')