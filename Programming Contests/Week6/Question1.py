from json.tool import main
from tkinter.tix import MAIN

string = input()
n = len(string)
lower_list = []
lower_count = 0
i = 0
while(i<len(string)):
    lower_list+=[lower_count]
    if not(string[i].isupper()):
        lower_count += 1
    i+=1
upper_list = []
upper_count = 0
i = 0
for char in reversed(string):
    upper_list+=[upper_count]
    if not(char.islower()):
        upper_count += 1
merged_list = []
i = 0
while(i<n):
    merged_list.append(lower_list[i] + upper_list[n-1-i])
    i+=1
j = 9999999999999
for i in merged_list:
    if i<j:
        j = i
print(j)
