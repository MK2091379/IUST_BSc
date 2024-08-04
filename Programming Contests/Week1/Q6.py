n = int(input())
fib = [1,2]
res=""
for i in range(2,n):
    if fib[i-1]+fib[i-2]<=n:
        fib.append(fib[i-1]+fib[i-2])
    else:
        break
for i in range(1,n+1):
    if i in fib:
        res+='+'
    else:
        res+='-'
print(res)  
    
    
