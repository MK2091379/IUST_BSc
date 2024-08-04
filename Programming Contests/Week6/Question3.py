import bisect
def lis(arr):
  if len(arr) == 0:
    return 0
  l = [arr[0]]
  
  for element in arr[1:]:
    pos = bisect.bisect(l, element)
    if pos == len(l):      
      if element > l[pos - 1]:
        l.append(element)
    else:
      if element != l[pos - 1]:
        l[pos] = element
  return len(l)
n = int(input())
lst = list(map(int, input().split()))
print(lis(lst))