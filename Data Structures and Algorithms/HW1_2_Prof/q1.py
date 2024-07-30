global N 
N = 4
def returnSolution(The_board): 
	for i in range(N): 
		for j in range(N): 
			print (The_board[i][j], end = " ") 
		print() 
def safeness(The_board, row, column): 
	for i in range(column): 
		if The_board[row][i] == 1: 
			return False
	for i, j in zip(range(row, -1, -1), 
					range(column, -1, -1)): 
		if The_board[i][j] == 1: 
			return False
	for i, j in zip(range(row, N, 1), 
					range(column, -1, -1)): 
		if The_board[i][j] == 1: 
			return False
	return True
def solvingNQUtil(The_board, column): 
	if column >= N: 
		return True
	for i in range(N): 

		if safeness(The_board, i, column): 
			The_board[i][column] = 1 
			input("Press Enter to continue...")
			returnSolution(The_board)
			if solvingNQUtil(The_board, column + 1) == True: 
				return True
			The_board[i][column] = 0
			input("Press Enter to continue...")
			returnSolution(The_board)
	return False 
def solvingNQ(): 
	The_board = [ [0, 0, 0, 0], 
			[0, 0, 0, 0], 
			[0, 0, 0, 0], 
			[0, 0, 0, 0] ] 
	if solvingNQUtil(The_board, 0) == False: 
		print ("Solution does not exist") 
		return False
	#returnSolution(The_board) 
	return True
solvingNQ() 
