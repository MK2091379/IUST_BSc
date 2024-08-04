n = int(input())
screen = []
tmp = ['.' for i in range(n+4)]
for i in range(n):
    line = [x for x in input()]
    line = ['.','.'] + line
    line +=['.','.']
    screen.append(line)
screen = [['.' for i in range(n+4)]] + [['.' for i in range(n+4)]] + screen + [['.' for i in range(n+4)]] + [['.' for i in range(n+4)]]
for i in range(2,len(screen)-2):
    for j in range(2,len(screen[i])-2):
        if screen[i][j] != '#' and screen[i][j] != 'A' and screen[i][j] != 'L':
            screen[i][j] = 'A'
            if (screen[i-2][j-1] != '#' and screen[i-2][j-1] != 'A') : screen[i-2][j-1] = 'L' 
            if (screen[i-1][j-2] != '#' and screen[i-1][j-2] != 'A') : screen[i-1][j-2] = 'L'
            if (screen[i+1][j-2] != '#' and screen[i+1][j-2] != 'A') : screen[i+1][j-2] = 'L'
            if (screen[i+2][j-1] != '#' and screen[i+2][j-1] != 'A') : screen[i+2][j-1] = 'L'
            
            if (screen[i-2][j+1] != '#' and screen[i-2][j+1] != 'A') : screen[i-2][j+1] = 'L'
            if (screen[i-1][j+2] != '#' and screen[i-1][j+2] != 'A') : screen[i-1][j+2] = 'L'
            if (screen[i+1][j+2] != '#' and screen[i+1][j+2] != 'A') : screen[i+1][j+2] = 'L'
            if (screen[i+2][j+1] != '#' and screen[i+2][j+1] != 'A') : screen[i+2][j+1] = 'L'
for i in range(2,len(screen)-2):
    for j in range(2,len(screen[i])-2):
        if(screen[i][j] == 'L') : print('.',end='') 
        else : print(screen[i][j],end = '')
    print()
            
            