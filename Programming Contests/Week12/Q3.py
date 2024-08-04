n = int(input())

def count_tilings(n):
    a, b, c = 1, 0, 0
    for _ in range(n):
        a, b, c = b + c, a + c, a + b
    return a

print(count_tilings(n))
