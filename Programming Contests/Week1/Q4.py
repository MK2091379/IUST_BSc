n = int(input())
binary_n = str(bin(n)[2:])[::-1] 
counter = 0
for i in binary_n:
    if i =='1':
        counter+=1
print(counter)
if counter!=0:
    for i in range(len(binary_n)):
        if binary_n[i]=='1':
            if i!=len(binary_n)-1:
                print(i,end=" ")
            else:
                print(i)