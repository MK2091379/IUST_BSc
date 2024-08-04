from itertools import count


cnt = input()
cnt = int(cnt)
pis = input()
pis = pis.split()
for i in range(len(pis)):
    pis[i] = int(pis[i])
temp = cnt
temp -=1
temp *=100
sum = 0
for i in pis:
    sum+=i
if(sum-temp > 0):
    print(sum-temp,end = ' ')
else:
    print(0,end = ' ')
min = 9999999999
for i in pis:
    if i<min:
        min = i
print(min)