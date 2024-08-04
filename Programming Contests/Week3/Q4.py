n = int(input())
homes = input()
inputs = list(map(int,input().split()))
s = inputs[0]
t = inputs[1]
if (s>t):
    homes = homes[t:s]
else:
    homes = homes[s:t]
splited_homes = homes.split('P')
counter = 0
pows = [1,2,4,8,16,32,64,128,256,512,1024,2048,4096]
for i in splited_homes:
    binary=bin(len(i))[2:]
    counter += binary.count('1')
print(counter)






