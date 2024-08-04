def print_sequence(n, k=2):
	if n%2 == 0:
		print(int(n/2),int(n/2))
		exit()
	b = int(n / (k * (k + 1) / 2))
	if b == 0:
		print (f"1 {n-1}")
		exit()
	#else:
	#	r = 1
	#	x = 1
	#	while x ** 2 <= n:
	#		if n % x != 0:
	#			x = x + 1
	#			continue
	#		elif x <= b and x > r:
	#			r = x
	#			#x = x + 1
	#		elif n / x <= b and n / x > r :
	#			r = n / x
	#			#x = x + 1
	#		x = x + 1
	#	i = 1
	#	while i < k :
	#		print (int(r * i), end = " ")
	#		i = i + 1
	#		
	#	last_term = n - (r * (k * (k - 1) / 2))
	#	print (int(last_term))
	print(int(b),int(n-b))
n = int(input())
print_sequence(n)
