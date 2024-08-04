def sum(l):
    s = 0
    for i in l:
        s+=i
    return s
inputs = input().split()
for i in range(len(inputs)):
    inputs[i] = int(inputs[i])
n = inputs[0]
m = inputs[1]
dp = []
for i in range(m):
    l = []
    for j in range(n):
        if j == 0:
            l.append(1)
        else:
            l.append(0)
    dp.append(l)
j = 1
while(j<n):
        dp[0][j] = dp[0][j-1] + j+1
        j+=1
i = 1
while(i<m):
    j = 1
    while(j<n):
        states = sum(dp[i-1][0:j+1])
        dp[i][j] = dp[i][j-1] + states
        j+=1
    i+=1

print(dp[m-1][n-1] % (10**9 +7))