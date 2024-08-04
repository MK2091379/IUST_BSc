n = int(input())
states = []
counter = 0
for i in range(n):
    states.append(int(input()))
x = states[0]
for i in range(1,n):
    if x == states[i] :
        continue
    else:
        x = states[i]
        counter +=1
print(counter)
