inputs = input().split()
n_states = int(inputs[0])
n_changes = int(inputs[2])
channels = []
for i in range(n_states):
    channels.append(input())
curr_states = channels[int(inputs[1])-1]
for i in range(n_changes):
    if channels.index(curr_states)<n_states-1:
        curr_states = channels[channels.index(curr_states)+1]
    else:
        curr_states = channels[0]
print(curr_states)