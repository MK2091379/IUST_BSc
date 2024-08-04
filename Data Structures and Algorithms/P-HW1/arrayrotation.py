def rotateArr1(arr,n,d):
    d = d%n
    tmp = arr[:d]
    arr = arr[d:]
    arr = arr+ tmp
    for x in arr:
        print(x , end= " ")
    print()
def rotateArr2(arr,n,d):
    for i in range(d):
        tmp = arr[0]
        for j in range(1,n):
            arr[j-1] = arr[j]
        arr[n-1 ] =tmp
    for x in arr:
        print(x , end= " ")
    print()
array_input = [int(i) for i in input().split()]
rotate = int(input())
rotateArr2(array_input,len(array_input),rotate)