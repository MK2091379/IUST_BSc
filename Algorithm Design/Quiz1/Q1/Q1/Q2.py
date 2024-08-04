import sys
from sys import setrecursionlimit,stdin
from threading import stack_size
from numpy import zeros
setrecursionlimit(10**6)
stack_size(2**27)
def PrintingSubString(st, low, high):
	sys.stdout.write(st[low : high + 1])
	sys.stdout.flush()
	return ''
def LongestPalindiromicSubString(st):
	n = len(st)
	DP = [[0 for x in range(n)] for y in range(n)]
	MaximumLength = 1
	i = 0
	while (i < n) :
		DP[i][i] = True
		i = i + 1
	start = 0
	i = 0
	while i < n - 1 :
		if (st[i] == st[i + 1]) :
			DP[i][i + 1] = True
			start = i
			MaximumLength = 2
		i = i + 1
	k = 3
	while k <= n :
		i = 0
		while i < (n - k + 1) :
			j = i + k - 1
			if (DP[i + 1][j - 1] and
					st[i] == st[j]) :
				DP[i][j] = True
	
				if (k > MaximumLength) :
					start = i
					MaximumLength = k
			i = i + 1
		k = k + 1
	print(PrintingSubString(st, start,start + MaximumLength - 1) , MaximumLength)
st = "ABABABBABAAAAABBBA"
LongestPalindiromicSubString(st)

