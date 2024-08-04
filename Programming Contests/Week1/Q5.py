n = int(input())+1
while(True):
    if len(set(str(n))) < len(str(n)):
        n+=1
        continue
    else:
        print(n)
        break