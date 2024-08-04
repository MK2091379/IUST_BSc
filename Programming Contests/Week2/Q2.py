test_case_count = input()
test_case_count = int(test_case_count)
i = 0
res = []
while(i<test_case_count):
    str_length = input()
    str_length = int(str_length)
    str_for_detect = input()
    str_for_detect = str(str_for_detect)
    max_unique_charachter = 0
    map_charachters = dict()
    j = 0
    while(j<len(str_for_detect)):
        map_charachters[str_for_detect[j]] = map_charachters.get(str_for_detect[j],0) + 1
        j+=1
    right_section_map_charachters = map_charachters
    left_section_map_charachters = dict()
    tmp = str_for_detect[:len(str_for_detect) - 1]
    j = 0
    while(j<len(tmp)):
        right_section_map_charachters[tmp[j]] = right_section_map_charachters[tmp[j]] -1
        if right_section_map_charachters[tmp[j]] == 0:
            right_section_map_charachters.pop(tmp[j])
        left_section_map_charachters[tmp[j]] = left_section_map_charachters.get(tmp[j],0) + 1
        count_unique_char_right_section = len(right_section_map_charachters)
        count_unique_char_left_section = len(left_section_map_charachters)
        if(max_unique_charachter>count_unique_char_left_section + count_unique_char_right_section):
            max_unique_charachter = max_unique_charachter
        else:
            max_unique_charachter = count_unique_char_left_section + count_unique_char_right_section
        j+=1
    res.append(max_unique_charachter)
    i+=1
for i in res:
    print(i)

