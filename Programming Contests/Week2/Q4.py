from heapq import heappush, _heapreplace_max,_heapify_max,_heappop_max
class MaxHeap:
    def __init__(self, list):
        self.list = [(item) for item in list]
        _heapify_max(self.list)
    def pop(self):
        val = _heappop_max(self.list)
        return val
    def push(self, val):
        heappush(val)
    def get_top(self):
        return self.list[0]
    def pop_push(self, val):
        _heapreplace_max(self.list, val)
    def count(self):
        return len(self.list)


test_case_count = input()
test_case_count = int(test_case_count)
res = [0 for i in range(test_case_count)]
i = 0
while(i<test_case_count):
    count = input()
    count = int(count)
    list_a = input()
    list_a = list_a.split()
    for j in range(len(list_a)):
        list_a[j] = int(list_a[j])
    list_b = input()
    list_b = list_b.split()
    for j in range(len(list_b)):
        list_b[j] = int(list_b[j])
    first_heap = MaxHeap(sorted(list_a))
    second_heap = MaxHeap(sorted(list_b))
    
    count_op = 0
    while not(first_heap.count() <= 0):
        top_a = first_heap.get_top()
        top_b = second_heap.get_top()
        if not(top_a != top_b):
            first_heap.pop()
            second_heap.pop()
            continue
        count_op=count_op+1
        if not(top_a <= top_b):
            first_heap.pop_push(len(str(top_a)))
        else:
            second_heap.pop_push(len(str(top_b)))
    res[i] = count_op
    i+=1
for k in res:
    print(k)