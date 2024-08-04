n = input()
if(type(n) == int):
    pass
else:
    n = int(n)
if n != 1 and n != 2:
    print(n-1)
elif n == 1 or n == 2:
    print(n)
else:
    pass