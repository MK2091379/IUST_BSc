def min_pipes(n, m, pairs):
    # Initialize the number of pipes needed to 0
    pipes = 0
    
    # Create a list to keep track of visited cities
    visited = [False] * n
    
    # Iterate through the important pairs
    for a, b in pairs:
        # If city a has not been visited yet
        if not visited[a-1]:
            # Increment the number of pipes needed
            pipes += 1
            # Mark city a as visited
            visited[a-1] = True
        
        # If city b has not been visited yet
        if not visited[b-1]:
            # Increment the number of pipes needed
            pipes += 1
            # Mark city b as visited
            visited[b-1] = True
    
    return pipes

# Example usage:
n = 4
m = 5
pairs = [(1, 2), (1, 3), (1, 4),(2, 3),(2, 4)]
print(min_pipes(n, m, pairs)) # Output: 3
