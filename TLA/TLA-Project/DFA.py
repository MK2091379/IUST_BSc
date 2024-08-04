from PySimpleAutomata import automata_IO 
from collections import defaultdict
from disjoint_set import DisjointSet
class FARule():
    def __init__(self, state, character, nextState):
        self.state = state
        self.character = character
        self.nextState = nextState
    def appliesTo(self, state, character):
        return self.state == state and self.character == character
    def followingState(self):
        return self.nextState
class DFARulebook():
    def __init__(self, rules):
        self.rules = rules
    def nextState(self, state, character):
        return self.ruleFor(state, character).followingState()
    def ruleFor(self, state, character):
        for rule in self.rules:
            if rule.appliesTo(state, character):
                return rule
class DFA():
    def __init__(self, currentState, acceptStates, rulebook):
        self.currentState = currentState
        self.acceptStates = acceptStates
        self.rulebook = rulebook
    def accepting(self):
        return self.currentState in self.acceptStates
    def readCharacter(self, character):
        self.currentState = self.rulebook.nextState(self.currentState, character)
    def readString(self, string):
        for character in string:
            self.readCharacter(character)
class DFADesign():
    def __init__(self, startState, acceptStates, rulebook):
        self.startState = startState
        self.acceptStates = acceptStates
        self.rulebook = rulebook
    def toDFA(self):
        return DFA(self.startState, self.acceptStates, self.rulebook)
    def isAcceptByDFA(self, string):
        dfa = self.toDFA()
        dfa.readString(string)
        return dfa.accepting()
#____________________________________________________________________________________________________________________________________________
def removeUnreachableStates():
    global states
    global finalStates
    global startState
    global transitionDict
    global newStates
    global newFinalStates
    g = defaultdict(list)
    for k,v in transitionDict.items():
        g[k[0]].append(v)
    stack = [startState]
    reachableStates =  set()
    while stack:
        state = stack.pop()
        if state not in reachableStates:
            stack += g[state]
        reachableStates.add(state)
    newStates = [state for state in states \
                            if state in reachableStates]
    newFinalStates = [state for state in finalStates \
                            if state in reachableStates]
    transitionDict = { k:v for k,v in transitionDict.items() \
                            if k[0] in reachableStates}
def makeSimpleDFA():
    global alphabet
    global startState
    global transitionDict
    global newStates
    global newFinalStates
    global newStartState
    removeUnreachableStates()
    def orderTuple(a,b):
        return (a,b) if a < b else (b,a)
    table = {}
    sortedStates = sorted(newStates)
    for i,item in enumerate(sortedStates):
        for item_2 in sortedStates[i+1:]:
            table[(item,item_2)] = (item in newFinalStates) != (item_2\
                                                     in newFinalStates)
    flag = True
    while flag:
        flag = False
        for i,item in enumerate(sortedStates):
            for item_2 in sortedStates[i+1:]:
                if table[(item,item_2)]:
                    continue
                for w in alphabet:
                    t1 = transitionDict.get((item,w),None)
                    t2 = transitionDict.get((item_2,w),None)
                    if t1 is not None and t2 is not None and t1 != t2:
                        marked = table[orderTuple(t1,t2)]
                        flag = flag or marked
                        table[(item,item_2)] = marked
                        if marked:
                            break
    d = DisjointSet(newStates)
    for k,v in table.items():
        if not v:
            d.union(k[0],k[1])
    newStates = [str(x) for x in range(1,1+len(d.get()))]
    new_final_states = []
    newStartState = str(d.find_set(startState))
    for s in d.get():
        for item in s:
            if item in newFinalStates:
                new_final_states.append(str(d.find_set(item)))
                break
    transitionDict = {(str(d.find_set(k[0])),k[1]):str(d.find_set(v))  
                            for k,v in transitionDict.items()}
    newFinalStates = new_final_states
#____________________________________________________________________________________________________________________________________________ 
if __name__ == '__main__':
    newStates = []
    newFinalStates = []
    newStartState = None
    states = [str(i) for i in input().split()]
    alphabet = [str(i) for i in input().split()]
    finalStates = [str(i) for i in input().split()]
    startState = states[0]
    transitionNumber = int(input())
    Transitions = []
    for i in range(transitionNumber):
        transition = [str(i) for i in input().split()]
        Transitions.append(transition)
    Input = 0
    while(Input!=5):
        print("1-accepting string")
        print("2-minimizing DFA")
        print("3-draw main DFA")
        print("4-draw minimized DFA")
        print("5-exite")
        Input = int(input())
        if Input == 1 :
            objects = []
            for i in Transitions:
                obj = FARule(i[0], i[2], i[1])
                objects.append(obj)
            rulebook = DFARulebook(objects)
            dfa_design = DFADesign(startState, finalStates, rulebook)
            string = input()
            print(dfa_design.isAcceptByDFA(string))
        elif Input == 2 :
            transitionDict = {}
            for i in Transitions:
                current_state = i[0]
                terminal = i[2]
                next_state = i[1]
                transitionDict[(current_state,terminal)] = next_state
            makeSimpleDFA()
        elif Input == 3 :
            dfa = {}
            dfa['alphabet'] = set(alphabet)
            dfa['states'] = set(states)
            ss = []
            ss.append(startState)
            dfa['initial_state'] = set(ss)
            dfa['accepting_states'] = set(finalStates)
            trans = {}
            for i in Transitions:
                trans[(i[0] , i[2])] = i[1]
            dfa['transitions'] = trans
            automata_IO.dfa_to_dot(dfa,'dfaout' , '.\\DFA-Graph\\')
        elif Input == 4 :
            minimizedDFA = {}
            minimizedDFA['alphabet'] = set(alphabet)
            minimizedDFA['states'] = set(newStates)
            newss = []
            newss.append(newStartState)
            minimizedDFA['initial_state'] = set(newStartState)
            minimizedDFA['accepting_states'] = set(newFinalStates)
            minimizedDFA['transitions'] = transitionDict
            automata_IO.dfa_to_dot(minimizedDFA,'Minimized_dfaout' , '.\\DFA-Graph\\')
        elif Input == 5 :
            exit(0)
        else:
            print("wrong input")