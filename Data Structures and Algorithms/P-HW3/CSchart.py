import sys
import threading
sys.setrecursionlimit(10**6)
threading.stack_size(2**27)
def FindingCycle(adjacent):
    # Mark all the vertices as not visited and not part of recursion stack
    VisitedNodes = [0]*len(adjacent)
    RecursionStack = [0]*len(adjacent)
    # Call the recursive helper function to detect cycle in different DFS trees
    for i in range(len(adjacent)):
        if not VisitedNodes[i]:
            if DFStraversal(adjacent, i, VisitedNodes, RecursionStack):
                return 1
    return 0

def DFStraversal(adjacent, x, VisitedNodes, RecursionStack):
    # Mark the current node as visited and part of recursion stack
    VisitedNodes[x] = 1
    RecursionStack[x] = 1
    # Recur for all the vertices adjacent to this vertex
    for i in range(len(adjacent[x])):
        if not VisitedNodes[adjacent[x][i]] and DFStraversal(adjacent, adjacent[x][i], VisitedNodes, RecursionStack):
            return 1
        elif RecursionStack[adjacent[x][i]]:
            return 1
    RecursionStack[x] = 0 # remove the vertex from recursion stack
    return 0

def main():
    n = int(sys.stdin.readline())
    adjacent = [[] for j in range(n)]
    for i in range(100):
        x = str(sys.stdin.readline())
        if x!="":
            a, b = map(int, x.split())
            adjacent[a - 1].append(b - 1)
        else:
            break
    print(FindingCycle(adjacent))
threading.Thread(target=main).start()