def findTheOrder(w, s): 
    # Storing the rows
    Persons = []
    # Storing the width along with their index or row number
    Seats = [[] for i in range(len(w))]
    for i in range(len(w)):
        Seats[i] = [w[i], i + 1]
    # Sorting seats
    Seats = sorted(Seats)
    # Storing the seats and row for men's seat
    Q = []
    # Storing the index of row upto which men have taken seat
    index = 0
    # Iterate the string
    for i in range(2 * len(w)):
        if (s[i] == '0'):
            # enqueue the row number at index in vector and heap
            Persons.append(Seats[index][1])
            Q.append(Seats[index])
            # Increment the index to let the next man in the next minimum width vacant row
            index += 1
        else:
            # If woman then take top of element of the max heap
            Persons.append(Q[-1][1])
            # dequeue
            del Q[-1]
        Q = sorted(Q)
    # Print the values
    for i in Persons:
        print(i, end = " ")
arr = [ 2, 1, 3 ]
s = "001011"
findTheOrder(arr, s)