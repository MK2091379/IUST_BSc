class Node: 
    def __init__(self, value): 
        self.value = value 
        self.neighbor = None
class LinkedList: 
    def __init__(self): 
        self.first = None
    def adding(self, NewValue): 
        NewNode = Node(NewValue) 
        if self.first is None: 
            self.first = NewNode 
            return
        currentNode = self.first 
        while currentNode.neighbor is not None: 
            currentNode = currentNode.neighbor
        #adding new node at the end of linkedlist
        currentNode.neighbor = NewNode   
    def Merging(self, l, r): 
        result = None
        if l == None:
            return r 
        if r == None: 
            return l
        if l.value <= r.value: 
            result = l
            result.neighbor = self.Merging(l.neighbor, r) 
        else: 
            result = r 
            result.neighbor = self.Merging(l, r.neighbor) 
        return result 
    def mergeSort(self, f): 
        if f == None or f.neighbor == None: 
            return f 
        #Mid of the linkedlist  
        Mid = self.extractMid(f) 
        neighbortoMid = Mid.neighbor
        # assign the neighbor of Mid node to None 
        Mid.neighbor = None
        left = self.mergeSort(f)  
        right = self.mergeSort(neighbortoMid)  
        SortedLinkedList = self.Merging(left, right) 
        if SortedLinkedList.neighbor!=None:
            print(SortedLinkedList.value,end="->")
            printList(SortedLinkedList.neighbor)
        else:
            print(SortedLinkedList.value)
        return SortedLinkedList  
    def extractMid(self, first): 
        if (first == None): 
            return first 
        oneStep = first 
        twoStep = first 
        while (twoStep.neighbor != None and 
               twoStep.neighbor.neighbor != None): 
            oneStep = oneStep.neighbor
            twoStep = twoStep.neighbor.neighbor
        return oneStep 
def printList(first): 
    if first is None: 
        print(' ') 
        return
    currentNode = first 
    outPut = ""
    while currentNode:
        outPut += str(currentNode.value) + "->" 
        currentNode = currentNode.neighbor
    print(outPut[:len(outPut)-2])
if __name__ == '__main__': 
    li = LinkedList()  
    inPut = input()
    inPut = inPut.split("->")
    counter = 0
    while counter<len(inPut):
        li.adding(int(inPut[counter]))
        counter+=1
    li.first = li.mergeSort(li.first) 