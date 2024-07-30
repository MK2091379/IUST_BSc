def DQS(array, low, high): 
    if low < high: 
        # LeftPivot means left pivot and RightPivot  
        # means right pivot 
        LeftPivot, RightPivot = partition(array, low, high) 
        DQS(array, low, LeftPivot - 1) 
        DQS(array, LeftPivot + 1, RightPivot - 1) 
        DQS(array, RightPivot + 1, high) 
def partition(array, low, high): 
    if array[low] > array[high]: 
        array[low], array[high] = array[high], array[low] 
    # p : left pivot 
    # q : right pivot. 
    j = k = low + 1
    g, p, q = high - 1, array[low], array[high] 
    while k <= g: 
        # If elements are less than the left pivot 
        if array[k] < p: 
            array[k], array[j] = array[j], array[k] 
            j += 1     
        # If elements are greater than or equal to the right pivot 
        elif array[k] >= q: 
            while array[g] > q and k < g: 
                g -= 1   
            array[k], array[g] = array[g], array[k] 
            g -= 1
              
            if array[k] < p: 
                array[k], array[j] = array[j], array[k] 
                j += 1   
        k += 1   
    j -= 1
    g += 1
    # Bring pivots to their appropriate positions. 
    array[low], array[j] = array[j], array[low] 
    array[high], array[g] = array[g], array[high] 
    # Returning the indices of the pivots 
    return j, g 
array = [ 24, 8, 42, 75, 29, 77, 38, 57 ] 
DQS(array, 0, 7) 
  
print('Sorted ayay: ', end = '') 
for i in array: 
    print(i, end = ' ') 
      
print() 