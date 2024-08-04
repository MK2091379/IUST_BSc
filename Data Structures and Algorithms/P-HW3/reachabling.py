import sys
import threading
sys.setrecursionlimit(10**6)
threading.stack_size(2**27)
def DFStraversal(adjacent, x, VisitedNode, stack):
    # Mark the current node as visited
    VisitedNode[x] = 1
    
    # Recur for all the vertices adjacent to this vertex
    for i in range(len(adjacent[x])):
        if not VisitedNode[adjacent[x][i]]:
            VisitedNode[adjacent[x][i]] = 1
            DFStraversal(adjacent, adjacent[x][i], VisitedNode, stack)

    # All vertices reachable from x are processed by now, push x to Stack
    stack.append(x)

def reverseEdges(adjacent):
    r_adjacent = [[] for _ in range(len(adjacent))]
    for i in range(len(adjacent)):
        for j in range(len(adjacent[i])):
            r_adjacent[adjacent[i][j]].append(i)
    return r_adjacent

def number_of_strongly_connected_components(adjacent):
    result = 0
    stack = []

    # Mark all the vertices as not visited (For first DFS)
    VisitedNode = [0] * len(adjacent)

    # Fill vertices in stack according to their finishing times
    for i in range(len(adjacent)):
        if not VisitedNode[i]:
            DFStraversal(adjacent, i, VisitedNode, stack)

    # get the reversed adj list
    r_adjacent = reverseEdges(adjacent)

    # Mark all the vertices as not visited (For second DFS)
    VisitedNode = [0] * len(adjacent)

    # Now process all vertices in order defined by Stack
    while stack:
        x = stack.pop()
        if not VisitedNode[x]:
            DFStraversal(r_adjacent, x, VisitedNode, [])
            result+=1
    return result

def main():
    n = int(input())
    adjacent = [[] for j in range(n)]
    for i in range(100):
        x = str(sys.stdin.readline())
        if x!="":
            a, b = map(int, x.split())
            adjacent[a - 1].append(b - 1)
        else:
            break
    print(number_of_strongly_connected_components(adjacent))
threading.Thread(target=main).start()