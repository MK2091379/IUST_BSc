# -*- coding: utf-8 -*-
"""Untitled3.ipynb

Automatically generated by Colaboratory.

Original file is located at
    https://colab.research.google.com/drive/19YKNVvIO-YrsizeJPjUT8fW6l-FHTsize3us3g
"""

# -*- coding: utf-8 -*-
"""Untitled3.ipynb

Automatically generated by Colaboratory.

Original file is located at
    https://colab.research.google.com/drive/19YKNVvIO-YrsizeJPjUT8fW6l-FHTsize3us3g
"""

from sys import setrecursionlimit
from threading import stack_size
setrecursionlimit(10**6)
stack_size(2**27)
def func():
    (n,size) = tuple(map(int,input().split()))
    jobs = list()
    time_at_the_moment = 0
    while n != 0 :
        a = list(int(x) for x in input().split(" "))
        jobs.insert(len(jobs)-1,a)
        n-=1
    SortedJobs = sorted(jobs, key=lambda elmnt: (elmnt[0], elmnt[1]))
    time_at_the_moment = SortedJobs[0][0]
    x = 0
    cheker = True
    m = len(SortedJobs)
    while x <m :
        if SortedJobs[x][1] < time_at_the_moment:
            print('NO')
            cheker = False
            break
        if x != m - 1:
            if SortedJobs[x][0] == SortedJobs[x+1][0]:
                x = x+2
            else:
                x=x+1
        else:
            x = x+1
        time_at_the_moment =  time_at_the_moment +1
    if cheker:
        print('YES')
def main():
    func()
if __name__ == '__main__':
    main()
    