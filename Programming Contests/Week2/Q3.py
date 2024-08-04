def flattern_sort_array(array:list) -> list:
    array_1d = sum(array, [])
    array_1d.sort()
    return array_1d
tower_count = input()
tower_count = int(tower_count)
towers_blocks = list()
res = [0 for i in range(tower_count)]
i = 0
while(i<tower_count):
    l = input()
    l = l.split()
    for j in range(len(l)):
        l[j] = int(l[j])
    l = l[1:]
    towers_blocks.append(l)
    i+=1
map_pos = {value:idx for idx,value in enumerate(flattern_sort_array(towers_blocks))}
need_to_change = 0
i = 0
while(i<tower_count):
    tmp = 0
    last_value_for_cheking = None
    k = 0
    while(k<len(towers_blocks[i])):
        value = map_pos[towers_blocks[i][k]]
        if  not(value == last_value_for_cheking or last_value_for_cheking == None):
            tmp =tmp+ 1
        last_value_for_cheking = value + 1
        k+=1
    need_to_change =need_to_change+ tmp
    res[i] = tower_count + need_to_change - 1
    i+=1
print(need_to_change,tower_count + need_to_change - 1)
for i in res:
    i+=14