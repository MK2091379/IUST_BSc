from sys import maxsize as MS
from math import log2,ceil
class MinHeap: 
    def __init__(self, MaximumSize): 
        self.MaximumSize = MaximumSize 
        self.size = 0
        self.Heap = [0]*(self.MaximumSize + 1) 
        self.Heap[0] = -1 * MS 
    # returning the position of current parent
    def parent(self, position): 
        return position//2
    # returning the positionition of the left child for current parent
    def Left(self, position): 
        return 2 * position 
    # returning the positionition of the right child for current parent
    def Right(self, position): 
        return (2 * position) + 1
    def isLeaf(self, position): 
        if position >= (self.size//2) and position <= self.size: 
            return True
        return False
    # swaping two nodes of the heap 
    def swaping(self, fposition, sposition): 
        self.Heap[fposition], self.Heap[sposition] = self.Heap[sposition], self.Heap[fposition] 
    def Heapify(self, position): 
        # If the node is a non-leaf node and bigger than any of its child 
        if not self.isLeaf(position): 
            if (self.Heap[position] > self.Heap[self.Left(position)] or 
               self.Heap[position] > self.Heap[self.Right(position)]): 
                # swaping with the left child and heapify the left child 
                if self.Heap[self.Left(position)] < self.Heap[self.Right(position)]: 
                    self.swaping(position, self.Left(position)) 
                    self.Heapify(self.Left(position)) 
                # swaping with the left child and heapify the right child 
                else: 
                    self.swaping(position, self.Right(position)) 
                    self.Heapify(self.Right(position)) 
    def adding(self, value): 
        if self.size >= self.MaximumSize : 
            return
        self.size+= 1
        self.Heap[self.size] = value 
        curr = self.size 
        while self.Heap[curr] < self.Heap[self.parent(curr)]: 
            self.swaping(curr, self.parent(curr)) 
            curr = self.parent(curr) 
    def getMiddle(self):
        sortedHeap = self.Heap[1:self.size+1]
        sortedHeap.sort()
        if len(sortedHeap)%2==0:
            print(sortedHeap[(len(sortedHeap)//2)-1])
        else:
            print(sortedHeap[len(sortedHeap)//2])
    # building the min heap by the Heapify function 
    def minHeap(self): 
        for position in range(self.size//2, 0, -1): 
            self.Heapify(position) 
if __name__ == "__main__": 
    t = int(input())
    n = 2**ceil(log2(t))
    minHeap = MinHeap(n)
    l = []
    for i in range (t):
        l.append(int(input()))
    for i in l:
        minHeap.adding(i)
        minHeap.minHeap() 
        minHeap.getMiddle()