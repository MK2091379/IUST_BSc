def printArr(arr):
    for x in arr:
        print(x , end= " ")
    print()
def insertionSort(arr):
    boolean = False
    for i in range(1, len(arr)): 
        key = arr[i] 
        j = i-1
        while j >= 0 and int(key) < int(arr[j]) : 
                arr[j + 1] = arr[j] 
                j -= 1
                boolean = True
        arr[j + 1] = key 
        if(boolean):
            printArr(arr)
            boolean = False
arr = [int(i) for i in input().split()]
insertionSort(arr)