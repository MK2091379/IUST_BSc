n = input()
n = int(n)
numbers = input().split()
for i in range(len(numbers)):
    numbers[i] = int(numbers[i])
count_negative = []
for i in numbers:
    if i<0:
        count_negative.append(i)
print((len(count_negative) * (len(numbers) - len(count_negative))) +  (len(count_negative) * (len(count_negative) - 1)))