x,y = map(int,input().split())
Matrix = [[None for i in range(y)]for j in range(x)]
for i in range(x):
    theRow = input()
    for j in range(y):
        Matrix[i][j] = theRow[j]
starLocation = [(i,j) for i in range(x) for j in range(y) if Matrix[i][j] == "*"] 
rowNbr = [-1, 0, 0, 1];
colNbr = [0, -1, 1, 0];    
for element in starLocation:
    S = []
    Counter  = 0
    isVisited = set()
    S.append(element)
    while S:
        Counter += 1
        S_peeked = S.pop()
        if(0<=S_peeked[0]+rowNbr[0]<x and 0<=S_peeked[1]+colNbr[0]<y):
            if Matrix[S_peeked[0]+rowNbr[0]][S_peeked[1]+colNbr[0]]=='.' and (S_peeked[0]+rowNbr[0],S_peeked[1]+colNbr[0]) not in isVisited:
                S.append((S_peeked[0]+rowNbr[0],S_peeked[1]+colNbr[0]))
                isVisited.add((S_peeked[0]+rowNbr[0],S_peeked[1]+colNbr[0]))
        if(0<=S_peeked[0]+rowNbr[1]<x and 0<=S_peeked[1]+colNbr[1]<y):
            if Matrix[S_peeked[0]+rowNbr[1]][S_peeked[1]+colNbr[1]]=='.' and (S_peeked[0]+rowNbr[1],S_peeked[1]+colNbr[1]) not in isVisited:
                S.append((S_peeked[0]+rowNbr[1],S_peeked[1]+colNbr[1]))
                isVisited.add((S_peeked[0]+rowNbr[1],S_peeked[1]+colNbr[1]))
        if(0<=S_peeked[0]+rowNbr[2]<x and 0<=S_peeked[1]+colNbr[2]<y):
            if Matrix[S_peeked[0]+rowNbr[2]][S_peeked[1]+colNbr[2]]=='.' and (S_peeked[0]+rowNbr[2],S_peeked[1]+colNbr[2]) not in isVisited:
                S.append((S_peeked[0]+rowNbr[2],S_peeked[1]+colNbr[2]))
                isVisited.add((S_peeked[0]+rowNbr[2],S_peeked[1]+colNbr[2]))
        if(0<=S_peeked[0]+rowNbr[3]<x and 0<=S_peeked[1]+colNbr[3]<y):
            if Matrix[S_peeked[0]+rowNbr[3]][S_peeked[1]+colNbr[3]]=='.' and (S_peeked[0]+rowNbr[3],S_peeked[1]+colNbr[3]) not in isVisited:
                S.append((S_peeked[0]+rowNbr[3],S_peeked[1]+colNbr[3]))
                isVisited.add((S_peeked[0]+rowNbr[3],S_peeked[1]+colNbr[3]))
    Matrix[element[0]][element[1]] = str(Counter%10)
for x in Matrix:
    s = "".join(x)
    print(s)		


