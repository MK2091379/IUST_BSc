class Node:   
    def __init__(self, value):
        self.value = value
        self.left = None
        self.right = None  
# Structure to storing node pair onto stack
class Node_Stack:
    def __init__(self, left, right):
        self.left = left
        self.right = right
def newNode(value):
    new_node = Node(value)
    return new_node
# printing tree in InorderTraversal form
def InorderTraversal(node):
    if (not node):
        return;
    InorderTraversal(node.left);
    print(node.value, end=' ');
    InorderTraversal(node.right);
def MergeTrees(firstTree, secondTree):
    if (not firstTree):
        return secondTree;
    if (not secondTree):
        return firstTree;
    s = []
    temp = Node_Stack(firstTree, secondTree)
    s.append(temp);
    n = None
    while (len(s) != 0):
        n = s[-1]
        s.pop();
        if (n.left == None or n.right == None):
            continue;
        n.left.value += n.right.value;
        if (n.left.left == None):
            n.left.left = n.right.left;
        else:
            t=Node_Stack(n.left.left, n.right.left)
            s.append(t);
        if (n.left.right == None):
            n.left.right = n.right.right;
        else:
            t=Node_Stack(n.left.right, n.right.right)
            s.append(t);
    return firstTree;
if __name__=='__main__':
    ''' first Binary Tree
            1
          /   \
         2     3
        / \     \
       4   5     6
    '''
    root1 = newNode(1);
    root1.left = newNode(2);
    root1.right = newNode(3);
    root1.left.left = newNode(4);
    root1.left.right = newNode(5);
    root1.right.right = newNode(6);
    ''' second Binary Tree
           4
         /   \
        1     7
       /     /  \
      3     2    6   '''
    root2 = newNode(4);
    root2.left = newNode(1);
    root2.right = newNode(7);
    root2.left.left = newNode(3);
    root2.right.left = newNode(2);
    root2.right.right = newNode(6);
    root3 = MergeTrees(root1, root2);
    print("The Merged Binary Tree in inorder traversal is:");
    InorderTraversal(root3);