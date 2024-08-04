n = int(input())
prime = []
for i in range(n+1):
    prime.append(True)
p = 2
while(p ** 2 < n+1):
    if (prime[p]):
        for i in range(p ** 2, n + 1, p):
            prime[i] = False
    p += 1
c = 0
for p in range(2, n+1):
    if prime[p]:
        c += 1
print(c)