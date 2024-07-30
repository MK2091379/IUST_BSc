from sys import maxsize 
from math import log2,ceil
class MaxHeap: 
    def __init__(self, MaximumSize): 
        self.MaximumSize = MaximumSize 
        self.length = 0
        self.Heap = [0] * (self.MaximumSize + 1) 
        self.Heap[0] = maxsize 
        self.head = 1
    # returning the position of parent of the current node 
    def parent(self, position): 
        return position // 2
        # O(1)
    # returning the position of the left child of the current node 
    def leftChild(self, position): 
        return 2 * position
        # O(1)
    # returning the position of the right child of the current node 
    def rightChild(self, position): 
        return (2 * position) + 1
        # O(1)
    # returning true if the passed node is a leaf node 
    def isLeaf(self, position): 
        if position>= (self.length//2) and position <= self.length: 
            return True
        return False
        # O(1)
    # swaping two node
    def swap(self, fposition, sposition): 
        self.Heap[fposition], self.Heap[sposition] = (self.Heap[sposition],  
                                            self.Heap[fposition]) 
        # O(1)
    # heapifying the current node 
    def Heapify(self, position): 
        # If the node is a non-leaf node and smaller than any of its child 
        if not self.isLeaf(position): 
            if (self.Heap[position] < self.Heap[self.leftChild(position)] or
                self.Heap[position] < self.Heap[self.rightChild(position)]): 
                # Swap with the left child and heapify the left child 
                if (self.Heap[self.leftChild(position)] >  
                    self.Heap[self.rightChild(position)]): 
                    self.swap(position, self.leftChild(position)) 
                    self.Heapify(self.leftChild(position)) 
                # Swap with the right child and heapify the right child 
                else: 
                    self.swap(position, self.rightChild(position)) 
                    self.Heapify(self.rightChild(position)) 
        # O(tree height)
    # adding the node in heap 
    def add(self, element): 
        if self.length >= self.MaximumSize: 
            return
        self.length += 1
        self.Heap[self.length] = element 
        current = self.length 
        while (self.Heap[current] >  
               self.Heap[self.parent(current)]): 
            self.swap(current, self.parent(current)) 
            current = self.parent(current) 
        # O(tree height)
    # printing the contents of the heap 
    def PrintHeap(self): 
        for i in range(1, (self.length // 2) + 1): 
            print(" PARENT : " + str(self.Heap[i]) + 
                  " LEFT CHILD : " + str(self.Heap[2 * i]) +
                  " RIGHT CHILD : " + str(self.Heap[2 * i + 1])) 
        # O(tree height/2)
    # removing and returning the maximum element of the heap 
    def returnMax(self): 
        popped = self.Heap[self.head] 
        self.Heap[self.head] = self.Heap[self.length] 
        self.length -= 1
        self.Heapify(self.head) 
        return popped 
        # O(tree height)
if __name__ == "__main__": 
    elements = [int(i) for i in input().split()]
    print('The maxHeap is ') 
    maxHeap = MaxHeap(2**ceil(log2(len(elements))) - 1) 
    for i in elements:
        maxHeap.add(i) 
    maxHeap.PrintHeap() 
    print("The Max val is " + str(maxHeap.returnMax()))