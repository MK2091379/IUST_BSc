def fact(n):
    s = 1
    for i in range(2,n+1):
        s = s * i
    return s
def comb(n,k):
    return fact(n)/(fact(k)*fact(n-k)) 
NUMS = list()
NUMS.append(0)
NUMS.append(1)
NUMS.append(2)
NUMS.append(9)
inputs = input().split()
for i in range(len(inputs)):
    inputs[i] = int(inputs[i])
n = inputs[0]
k = inputs[1]
count_p = 1
i = 0
while(i<k):
    count_p += comb(n, i+1) * NUMS[i]
    i+=1

print(int(count_p))
