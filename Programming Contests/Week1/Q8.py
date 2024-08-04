balls = input()
zeros = []
for i in balls:
    if i == '0':
        zeros.append(i)
if(len(zeros)>len(balls)-len(zeros)):
    print((len(balls)-len(zeros))*2)
else:
    print(len(zeros)*2)
