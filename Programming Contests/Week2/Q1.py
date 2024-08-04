from math import ceil
n = input()
n = int(n)
k = 0
res = []
while(k<n):
    count = input()
    count = int(count)
    lengths = []
    inputs = input()
    lengths = inputs.split()      
    for i in range(len(lengths)):
        lengths[i] = int(lengths[i]) 
    count_op = 0
    min_val = lengths[-len(lengths)]
    max_div = (min_val * 2)
    max_div-=1
    j = 0
    while(j<len(lengths)):  
        tmp = lengths[j] / max_div
        tmp = ceil(tmp)
        tmp-=1
        count_op = count_op + tmp
        j+=1
    res.append(count_op)
    k+=1
for i in res:
    print(i)