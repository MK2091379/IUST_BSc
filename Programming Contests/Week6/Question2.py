from multiprocessing.sharedctypes import Value


def Minimum(x,y):
    if x>y:
        return y
    else:
        return x
n = input()
n = int(n)
lst = input().split()
for i in range(len(lst)):
    lst[i] = int(lst[i])
value_list = []
for i in range(len(lst)+2):
    value_list.append(0)
for i in range(len(lst) -1, -1, -1):
    value_list[i] = lst[i] + Minimum(value_list[i+1], value_list[i+2])
print(Minimum(value_list[0], value_list[1]))