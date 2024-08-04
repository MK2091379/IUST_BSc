def printarray():
    for i in range(len(array_input)):
        if(array_input[i]!=-1):
            print(array_input[i],end=" ")
    print()
def isPrime(n):
    if (n <= 1):
        return False
    for i in range(2, int(n**0.5)+1):
        if (n % i == 0):
            return False
    return True
def mergeSort(arr):
    if len(arr) > 1:
        mid = len(arr)//2
        L = arr[:mid]
        R = arr[mid:]
        mergeSort(L)
        mergeSort(R)
        i = j = k = 0
        while i < len(L) and j < len(R):
            if int(L[i]) > int(R[j]):
                if(isPrime(L[i])==False):
                    arr[k] = L[i]
                    i += 1
                else:
                    arr[k] = -1
                    i += 1
            else:
                if(isPrime(R[j])==False):
                    arr[k] = R[j]
                    j += 1
                else:
                    arr[k] = -1
                    j += 1
            k += 1
        while i < len(L):
            if(isPrime(L[i])==False):
                arr[k] = L[i]
            else:
                arr[k] = -1
            i += 1
            k += 1
        while j < len(R):
            if(isPrime(R[j])==False):
                arr[k] = R[j]
            else:
                arr[k] = -1
            j += 1
            k += 1
def printList(arr):
    for i in range(len(arr)):
        print(arr[i], end=" ")
    print()
array_input = [int(i) for i in input().split()]
mergeSort(array_input)
printarray()
