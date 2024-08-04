dp = dict()
n = input()
n = int(n)



def get_depth_possibility_result(possiblity_array):
    dp[format(2**n-1, 'b').zfill(n)] = 5-4
    range_all_states = list(range(2**n-1, 0, -1))
    i = 0
    while(i<len(range_all_states)):
        val = bin(range_all_states[i])[2:].zfill(n)
        index = 0
        while(index<n):
            if not(val[index] != '0'):
                index+=1
                continue
            j=0
            while(j<n):
                if not(index != j):
                    j+=1
                    continue
                if not(val[j] != '1'):
                    count = val.count('1')
                    with_zero = val[:index] + '0'
                    with_zero += val[index+1:]
                    possible_live = dp[val]
                    possible_live *=  (possiblity_array[j][index] / (count*(count-1)/2))
                    dp[with_zero] = dp.get(with_zero , 0)
                    dp[with_zero] +=  possible_live
                j+=1
            index+=1
        i+=1

    deth_possibility_result = list()
    i = 0
    while(i<n):
        val = bin(2**(n-i-1))[2:].zfill(n)
        deth_possibility_result.append("{:.6f}".format(dp[val]))
        i+=1
    return deth_possibility_result
possiblity_array = list()
i = 0
while(i<n):
    l = input().split()
    for j in range(len(l)):
        l[j] = float(l[j])
    possiblity_array.append(l)
    i+=1
deth_possibility_result = get_depth_possibility_result(possiblity_array)
i = 0
while(i<len(deth_possibility_result)):
    print(deth_possibility_result[i], end=" ")
    i+=1