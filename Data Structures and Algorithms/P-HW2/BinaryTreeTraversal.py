import sys
import threading
sys.setrecursionlimit(10**6)
threading.stack_size(2**27)
class Tree:
  def ReadingTree(self):
    self.value = [0 for i in range(10000)]
    self.leftChild = [0 for i in range(10000)]
    self.rightChild = [0 for i in range(10000)]
    for i in range(10000):
      x = sys.stdin.readline().split()
      if (len(x)!=0):
        self.value[i] = int(x[0])
        self.leftChild[i] = int(x[1])
        self.rightChild[i] = int(x[2])
      else:
            break
  def BinaryTreeInOrderTraversal(self, root):
    if self.leftChild[root] != -1:
      self.BinaryTreeInOrderTraversal(self.leftChild[root])
    print(self.value[root],end=" ")
    if self.rightChild[root] != -1:
      self.BinaryTreeInOrderTraversal(self.rightChild[root])
    return
  def BinaryTreePreOrderTraversal(self, root):
    print(self.value[root],end=" ")
    if self.leftChild[root] != -1:
      self.BinaryTreePreOrderTraversal(self.leftChild[root])
    if self.rightChild[root] != -1:
      self.BinaryTreePreOrderTraversal(self.rightChild[root])
    return
  def BinaryTreePostOrderTraversal(self, root):
    if self.leftChild[root] != -1:
      self.BinaryTreePostOrderTraversal(self.leftChild[root])
    if self.rightChild[root] != -1:
      self.BinaryTreePostOrderTraversal(self.rightChild[root])
    print(self.value[root],end=" ")
    return 
def main():
  BinaryTree = Tree()
  BinaryTree.ReadingTree()
  BinaryTree.BinaryTreeInOrderTraversal(0)
  print()
  BinaryTree.BinaryTreePreOrderTraversal(0)
  print()
  BinaryTree.BinaryTreePostOrderTraversal(0)
  print()
threading.Thread(target=main).start()

