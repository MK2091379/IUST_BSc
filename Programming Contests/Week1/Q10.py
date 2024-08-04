from operator import index
from pickletools import read_stringnl_noescape


from collections import Counter
def common(str1,str2):
    dict1 = Counter(str1)
    dict2 = Counter(str2)
    commonDict = dict1 & dict2
    if len(commonDict) == 0:
        return
    commonChars = list(commonDict.elements())
    #commonChars = sorted(commonChars)
    #print (''.join(commonChars))
    return commonChars
inputs = input().split()
first_str = inputs[0]
second_str = inputs[1]
#a = set(first_str)
#b = set(second_str)
#common_chars=list(a&b)
common_chars=common(first_str,second_str)
pos_of_first_com_char_in_first_str = first_str.index(common_chars[0])
pos_of_first_com_char_in_second_str = second_str.index(common_chars[0])
output = [[] for i in range(len(second_str))]
for i in range(len(second_str)):
    if i == pos_of_first_com_char_in_second_str:
        for j in first_str:
            output[i].append(j)
    else:
        for j in range(len(first_str)):
            if j == pos_of_first_com_char_in_first_str:
                output[i].append(second_str[i])
            else:
                output[i].append('.')
for i in range(len(output)):
    for j in range(len(output[0])):
        if j != len(output[0])-1:
            print(output[i][j],end='')
        else:
            print(output[i][j])