inputs = input().split()
l = int(inputs[0])
point = int(inputs[1])
s = input()
for i in s:
    if i == 'x':
        if point != 0:
            point-=1
        else:
            continue
    else:
        point+=1
print(point)