n = int(input())
My_numbers = list(range(1,n+1))

def Bi_search (array, l, r, x): 
    if r >= l: 
  
        middle = l + (r - l) // 2
        if array[middle] == x: 
            My_numbers.remove(x)
            return True
        elif array[middle] > x: 
            return Bi_search(array, l, middle-1, x) 
        else: 
            return Bi_search(array, middle + 1, r, x) 
  
    else: 
        return False
for i in range(n-1):
    x =int(input())
    Bi_search(My_numbers,0,len(My_numbers),x)

print(My_numbers)