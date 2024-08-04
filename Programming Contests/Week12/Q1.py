n = int(input())
arr = list(map(int, input().split()))

count_dict = {}
result = 0

for item in arr:
    if item in count_dict:
        if count_dict[item] == 1:
            result += 1
        count_dict[item] += 1
    else:
        count_dict[item] = 1

sorted_count_dict = sorted(count_dict.values())

count = 0
for item in sorted_count_dict:
    if item == 1:
        count += 1

result += count // 2
if count % 2 == 1:
    result += 1

print(result)