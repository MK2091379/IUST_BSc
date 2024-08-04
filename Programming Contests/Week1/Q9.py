n_groups = int(input())
people = map(int,input().split())
for i in people:
    if i<=3:
        print('*'*i)
    else:
        print('*')
