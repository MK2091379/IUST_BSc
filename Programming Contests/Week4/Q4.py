n = int(input())
queue = list(map(int,input().split()))
counter = 0
for i in range(1,len(queue)):
    if(queue[i]>=queue[i-1]):
        pass
    else:
        x = queue[i-1]
        y =queue[i]
        counter+=(x-y)
        queue[i]+=(x-y)
print(counter)