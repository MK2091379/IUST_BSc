from sys import setrecursionlimit,stdin
from threading import stack_size
from numpy import zeros
setrecursionlimit(10**6)
stack_size(2**27)
def left(task):
    return [task[0]+1,task[1]-1]
def right(task):
    return [task[0]+1,task[1]+1]
def current(task):
    return [task[0]+1,task[1]]
def func(tasks):
    inorderTask = []
    result = ""
    #OrdinaryBowlPlace = 0
    #MagicBowlPlace = 0
    #lastTime = int(tasks[len(tasks)-1][0])
    for i in range(len(tasks)):
        if((tasks[i][0] == tasks[i][1]) or (tasks[i] == left(tasks[i-1])) or (tasks[i] == right(tasks[i-1])) or (tasks[i] == current(tasks[i-1]))):
            continue
        else:
            if len(inorderTask) == 0:
                inorderTask = tasks[i]
            else:
                if tasks[i][0] > inorderTask[0] and tasks[i][1]>inorderTask[1]:
                    inorderTask = tasks[i]
                else:
                    result = "NO"
                    break
        result = "YES"
    print(result)
n = input()
tasks = []
while(True):
    task = [int(i) for i in stdin.readline().split()]
    if len(task) == 0:
        break
    else:
        tasks.append(task)
func(tasks)
        
