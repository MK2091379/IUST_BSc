import random
class Point:
    def __init__(self, x , y):  
        self.x = x 
        self.y = y


def WriteArr(arr):
    for i in arr:
        for j in i:
            if(j>=10):
                print(j, end=' ')
            else:
                print(j, end='  ')
        print()


def kahad(arr,points):
    newArr = []
    for i in range(len(arr)):
        ISokX = True
        for k in points:
            if i == k.x:
                    ISokX = False
        if ISokX:
            col = []
            for j in range(len(arr[i])):
                ISokY = True
                for k in points:
                    if j == k.y:
                        ISokY = False
                if ISokY:
                    col.append(arr[i][j])
            newArr.append(col)
    return newArr
            
def Det(array):
    if len(array) == 0:
        return 1
    elif len(array) == 1:
        return int(array[0][0])
    elif len(array) == 2:
        return int((array[0][0] * array[1][1]) - (array[0][1] * array[1][0]))
    TheArr = [[],[]]
    TheArr[0].append(kahad(array,[Point(0,0)]))
    TheArr[0].append(kahad(array,[Point(0,len(array)-1)]))
    TheArr[1].append(kahad(array,[Point(len(array)-1,0)]))
    TheArr[1].append(kahad(array,[Point(len(array)-1,len(array)-1)]))
    TheArr11nn = kahad(array,[Point(0,0),Point(len(array)-1,len(array)-1)])

    newArr = []
    for i in range(2):
        col = []
        for j in range(2):
            col.append(Det(TheArr[i][j]))
        newArr.append(col)
    try:
        return int(Det(newArr) * (1/Det(TheArr11nn)))
    except:
        print('Zero Division')
        quit()

number = int(input())
array=[] 
for i in range(number): 
    col = [] 
    for j in range(number): 
      col.append(random.randrange(1,20)) 
    array.append(col) 
WriteArr(array)
print(Det(array))
