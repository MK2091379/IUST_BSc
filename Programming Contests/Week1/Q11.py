n = int(input())
samples = []
for i in range(n):
    samples.append(input().split())
for i in samples:
    if(i[2][0]=='O'):
        if(i[2][-1]=='-'):
            print('valid')
        else:
            if((i[2][-1] in i[0]) or (i[2][-1] in i[1])):
                print('valid')
            else:
                print('invalid')
    else:
        if(len(i[2])==2):
            if((i[2][0] in i[0]) or (i[2][0] in i[1])):
                if(i[2][-1]=='-'):
                    print('valid')
                else:
                    if((i[2][-1] in i[0]) or (i[2][-1] in i[1])):
                        print('valid')
                    else:
                        print('invalid')
            else:
                print('invalid')
        else:
            if(((i[2][0] in i[0]) or (i[2][0] in i[1])) and ((i[2][1] in i[0]) or (i[2][1] in i[1]))):
                if(i[2][-1]=='-'):
                    print('valid')
                else:
                    if((i[2][-1] in i[0]) or (i[2][-1] in i[1])):
                        print('valid')
                    else:
                        print('invalid')
            else:
                print('invalid')