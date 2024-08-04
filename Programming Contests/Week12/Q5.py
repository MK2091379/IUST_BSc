def CountTriplets(a, n):
	ans = 0
	for i in range (n):
		cnt = 0
		for j in range (i + 1 , n):
			if (a[j] > a[i]):
				cnt += 1
			else:
				ans += cnt
	return ans
if __name__ == "__main__":
    n = int(input())
    a = list(map(int, input().split())) 
    print (CountTriplets(a, n))
