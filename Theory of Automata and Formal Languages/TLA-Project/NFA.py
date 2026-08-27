from pprint import pprint
from PySimpleAutomata import automata_IO
from collections import defaultdict
from disjoint_set import DisjointSet
import copy
class FARule(object):
    def __init__(self, state, character, next_state):
        self.state = state
        self.character = character
        self.next_state = next_state
    def applies_to(self, state, character):
        return self.state == state and self.character == character
    def follow(self):
        return self.next_state
    def __str__(self):
        state = self.state
        character = self.character
        next_state = self.next_state
        return '{state}-{character}-{next_state}'.format(**locals())
    __repr__ = __str__
class DFARulebook(object):
    def __init__(self, rules):
        self.rules = rules
    def next_state(self, state, character):
        return self.rule_for(state, character).follow()
    def rule_for(self, state, character):
        for rule in self.rules:
            if rule.applies_to(state, character):
                return rule
class DFA(object):
    def __init__(self, current_state, accept_states, rulebook):
        self.current_state = current_state
        self.accept_states = accept_states
        self.rulebook = rulebook
    def accepting(self):
        return self.current_state in self.accept_states
    def read_character(self, character):
        self.current_state = self.rulebook.next_state(self.current_state, character)
    def read_string(self, string):
        for character in string:
            self.read_character(character)
class DFADesign(object):
    def __init__(self, start_state, accept_states, rulebook):
        self.start_state = start_state
        self.accept_states = accept_states
        self.rulebook = rulebook
    def to_dfa(self):
        return DFA(self.start_state, self.accept_states, self.rulebook)
    def accepts(self, string):
        dfa = self.to_dfa()
        dfa.read_string(string)
        return dfa.accepting()
#_____________________________________________________________________________________________________________
def removeUnreachableStates():
    global DFA_states
    global DFA_finalStates
    global DFA_startState
    global transitionDict
    global DFA_newStates
    global DFA_newFinalStates
    g = defaultdict(list)
    for k,v in transitionDict.items():
        g[k[0]].append(v)
    stack = [DFA_startState]
    reachableStates =  set()
    while stack:
        state = stack.pop()
        if state not in reachableStates:
            stack += g[state]
        reachableStates.add(state)
    DFA_newStates = [state for state in DFA_states \
                            if state in reachableStates]
    DFA_newFinalStates = [state for state in DFA_finalStates \
                            if state in reachableStates]
    transitionDict = { k:v for k,v in transitionDict.items() \
                            if k[0] in reachableStates}
def makeSimpleDFA():
    global alphabet
    global DFA_startState
    global transitionDict
    global DFA_newStates
    global DFA_newFinalStates
    global DFA_newStartState
    removeUnreachableStates()
    def orderTuple(a,b):
        return (a,b) if a < b else (b,a)
    table = {}
    sortedStates = sorted(DFA_newStates)
    for i,item in enumerate(sortedStates):
        for item_2 in sortedStates[i+1:]:
            table[(item,item_2)] = (item in DFA_newFinalStates) != (item_2\
                                                     in DFA_newFinalStates)
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
    d = DisjointSet(DFA_newStates)
    for k,v in table.items():
        if not v:
            d.union(k[0],k[1])
    DFA_newStates = [str(x) for x in range(1,1+len(d.get()))]
    new_final_states = []
    DFA_newStartState = str(d.find_set(DFA_startState))
    for s in d.get():
        for item in s:
            if item in DFA_newFinalStates:
                new_final_states.append(str(d.find_set(item)))
                break
    transitionDict = {(str(d.find_set(k[0])),k[1]):str(d.find_set(v))  
                            for k,v in transitionDict.items()}
    DFA_newFinalStates = new_final_states
#_____________________________________________________________________________________________________________
class NFARulebook(object):
    def __init__(self, rules):
        self.rules = rules
    def next_states(self, states, character):
        nexts = []
        for state in states:
            nexts += self.follow_rules_for(state, character) 
        return set(nexts)
    def follow_rules_for(self, state, character):
        return [rule.follow() for rule in self.rules_for(state, character)]
    def rules_for(self, state, character):
        return [rule for rule in self.rules if rule.applies_to(state, character)]
    def follow_free_moves(self, states):
        more_states = self.next_states(states, None)
        if more_states.issubset(states):
            return states
        else:
            return self.follow_free_moves(states.union(more_states))
    def alphabet(self):
        return(list(set([rule.character for rule in self.rules if  not rule.character == None])))
class NFA(object):
    def __init__(self, current_states, accept_states, rulebook):
        self._current_states = current_states
        self.accept_states = accept_states
        self.rulebook = rulebook
    @property
    def current_states(self):
        return self.rulebook.follow_free_moves(self._current_states)
    def accepting(self):
        if [state for state in self.current_states if state in self.accept_states]:
            return True
        else:
            return False
    def read_character(self, character):
        self._current_states = self.rulebook.next_states(self.current_states, character)
    def read_string(self, string):
        for character in string:
            self.read_character(character)
class NFADesign(object):
    def __init__(self, start_state, accept_states, rulebook):
        self.start_state = start_state
        self.accept_states = accept_states
        self.rulebook = rulebook
    def to_nfa(self, current_states = None):
        if current_states == None:
            current_states = set([self.start_state])
        return NFA(current_states, self.accept_states, self.rulebook)
    def accepts(self, string):
        nfa = self.to_nfa()
        nfa.read_string(string)
        return nfa.accepting()
class NFASimulation(object):
    def __init__(self, nfa_design):
        self.nfa_design = nfa_design
    def next_state(self, state, character):
        nfa = self.nfa_design.to_nfa(state)
        nfa.read_character(character)
        return nfa.current_states
    def rules_for(self, state):
        return [FARule(state, character, self.next_state(state, character))
                for character in self.nfa_design.rulebook.alphabet()]
    def discover_states_and_rules(self, states):
        rules = []
        for state in states:
            rules += self.rules_for(state)  
        more_states = [rule.follow() for rule in rules]
        temp = []
        for s in more_states:
            if s not in states:
                temp += [s]
        if temp:        
            return self.discover_states_and_rules(states + temp)
        else:
            return [states, rules]
    def to_dfa_design(self):
        start_state = self.nfa_design.to_nfa().current_states
        states, rules = self.discover_states_and_rules([set(start_state)])
        accept_states = [state for state in states if self.nfa_design.to_nfa(state).accepting()]
        return DFADesign(start_state, accept_states, DFARulebook(rules))
#_____________________________________________________________________________________________________________
#def set_transition_dict():
#        dict_states = {r: {c: 'empty' for c in DFA_states} for r in DFA_states}
#        for i in DFA_states:
#            for j in DFA_states:
#                indices = [ii for ii, v in enumerate(transition_funct[i]) if v == j]
#                if len(indices) != 0:
#                    dict_states[i][j] = '+'.join([str(alphabet[v]) for v in indices])
#        ds = dict_states
#        transition_dict = copy.deepcopy(dict_states)
#    def get_intermediate_states():
#        return [state for state in DFA_states if state not in ([DFA_startState] + DFA_finalState)]
#    def get_predecessors(state):
#        return [key for key, value in ds.items() if state in value.keys() and value[state] != 'empty' and key != state]
#    def get_successors(state):
#        return [key for key, value in ds[state].items() if value != 'empty' and key != state]
#    def get_if_loop(state):
#        if ds[state][state] != 'empty':
#            return ds[state][state]
#        else:
#            return ''
#    def toregex():
#        intermediate_states = get_intermediate_states()
#        dict_states = ds
#        for inter in intermediate_states:
#            predecessors = get_predecessors(inter)
#            successors = get_successors(inter)
#            for i in predecessors:
#                for j in successors:
#                    inter_loop = get_if_loop(inter)
#                    dict_states[i][j] = '+'.join(('(' + dict_states[i][j] + ')', ''.join(('(' + dict_states[i][
#                        inter] + ')', '(' + inter_loop + ')' + '*', '(' + dict_states[inter][j] + ')'))))
#            dict_states = {r: {c: v for c, v in val.items() if c != inter} for r, val in dict_states.items() if
#                           r != inter}
#            ds = copy.deepcopy(dict_states)
#        init_loop = dict_states[DFA_startState][DFA_startState]
#        init_to_final = dict_states[DFA_startState][DFA_finalState[0]] + '(' + dict_states[DFA_finalState[0]][
#            DFA_finalState[0]] + ')' + '*'
#        final_to_init = dict_states[DFA_finalState[0]][DFA_startState]
#        re = '(' + '(' + init_loop + ')' + '+' + '(' + init_to_final + ')' + '(' + final_to_init + ')' + ')' + '*' + '(' + init_to_final + ')'
#        return re
reg_exp = ''
def get_input_symbol():
    global DFA_states 
    global DFA_alphabet 
    global DFA_finalStates 
    global DFA_startState 
    global DFA_Transitions
    input_symbols = {st: {to: '' for to in DFA_states} for st in DFA_states}
    for val in DFA_Transitions:
        if input_symbols[val[0]][val[1]] == '':
            input_symbols[val[0]][val[1]] = val[2]
        else:
            input_symbols[val[0]][val[1]] += '+' + val[2]
    return input_symbols
def get_pred_succ(state, input_symbols):
    global DFA_states
    global DFA_alphabet
    global DFA_finalStates
    global DFA_startState
    global DFA_Transitions
    predecessors = []
    successors = []
    curr_dict_for_from = {st: {to: v for to, v in val.items() if to == state} for st, val in input_symbols.items()}
    for predecessor in DFA_states:
        if predecessor not in curr_dict_for_from.keys() or predecessor == state:
            continue
        if curr_dict_for_from[predecessor][state] != '':
            predecessors.append(predecessor)
    for successor in DFA_states:
        if successor not in input_symbols[state].keys() or state == successor:
            continue
        if input_symbols[state][successor] != '':
            successors.append(successor)
    return predecessors, successors
def check_self_loop(state):
    global DFA_states
    global DFA_alphabet
    global DFA_finalStates
    global DFA_startState
    global DFA_Transitions
    if input_symbols[state][state] == '':
        return False
    return True
def DFA_to_regex(input_symbols, state_intitial, state_final):
    global DFA_states
    global DFA_alphabet
    global DFA_finalStates
    global DFA_startState
    global DFA_Transitions
    for state in DFA_states:
        if state == state_intitial or state == state_final:
            continue
        predecessors, successors = get_pred_succ(state, input_symbols)
        for predecessor in predecessors:
            if predecessor in input_symbols.keys():
                for successor in successors:
                    if successor in input_symbols[predecessor].keys():

                        pre_suc_input_exp = ''
                        self_loop_input_exp = ''
                        from_pre_input_exp = ''
                        to_suc_input_exp = ''
                        if input_symbols[predecessor][successor] != '':
                            pre_suc_input_exp = '(' + input_symbols[predecessor][successor] + ')'
                        if check_self_loop(state):
                            self_loop_input_exp = '(' + input_symbols[state][state] + ')' + '*'
                        if input_symbols[predecessor][state] != '':
                            from_pre_input_exp = '(' + input_symbols[predecessor][state] + ')'
                        if input_symbols[state][successor] != '':
                            to_suc_input_exp = '(' + input_symbols[state][successor] + ')'
                        new_pre_suc_input_exp = from_pre_input_exp + self_loop_input_exp + to_suc_input_exp
                        if pre_suc_input_exp != '':
                            new_pre_suc_input_exp += ('+' + pre_suc_input_exp)
                        input_symbols[predecessor][successor] = new_pre_suc_input_exp
        input_symbols = {st: {to: v for to, v in inp.items() if to != state} for st, inp in input_symbols.items() if st != state}
    return input_symbols[state_intitial][state_final]
def start_has_incoming():
    global DFA_states
    global DFA_alphabet
    global DFA_finalStates
    global DFA_startState
    global DFA_Transitions
    check = False
    initial_state = DFA_startState
    for dfa_transition in DFA_Transitions:
        if dfa_transition[0] == initial_state:
            check = True
            break
    return check
def end_has_outgoing():
    global DFA_states
    global DFA_alphabet
    global DFA_finalStates
    global DFA_startState
    global DFA_Transitions
    check = False
    if len(DFA_finalStates) > 1:
        return True
    final_state = DFA_finalStates[0]
    for dfa_transition in DFA_Transitions:
        if dfa_transition[0] == final_state:
            check = True
            break
    return check
def handle_start_incoming():
    global DFA_states
    global DFA_alphabet
    global DFA_finalStates
    global DFA_startState
    global DFA_Transitions
    if start_has_incoming():
        DFA_states.append("Qi")
        DFA_Transitions.append(["Qi", DFA_startState,"$"])
        DFA_startState = ["Qi"]
def handle_final_outgoing():
    global DFA_states
    global DFA_alphabet
    global DFA_finalStates
    global DFA_startState
    global DFA_Transitions
    if end_has_outgoing():
        DFA_states.append("Qf")
        for final_state in DFA_finalStates:
            DFA_Transitions.append([final_state,"Qf", "$"])
        DFA_finalStates = ["Qf"]
def out_regex(regexp):
    global DFA_states
    global DFA_alphabet
    global DFA_finalStates
    global DFA_startState
    global DFA_Transitions
    return regexp
#_____________________________________________________________________________________________________________
if __name__ == '__main__':
    states = [str(i) for i in input().split()]
    alphabet = [str(i) for i in input().split()]
    finalStates = [str(i) for i in input().split()]
    startState = states[0]
    transitionNumber = int(input())
    Transitions = []
    for i in range(transitionNumber):
        transition = [str(i) for i in input().split()]
        Transitions.append(transition)
    objects = []
    for i in Transitions:
        if i[2] == "lambda":
            obj = FARule(i[0], None, i[1])
        else:
            obj = FARule(i[0], i[2], i[1])
        objects.append(obj)
    rulebook = NFARulebook(objects)
    nfa_design = NFADesign(startState, finalStates, rulebook)
    Input = 0
    while(Input!=5):
        print("NFA Part:")
        print("1-accepting string")
        print("2-creat equivalent DFA")
        print("3-draw NFA")
        print("4-convert NFA to regex")
        print("5-exite")
        Input = int(input())
        if Input == 1 :
            string = input()
            simulation = NFASimulation(nfa_design)
            dfa_design = simulation.to_dfa_design()
            print(dfa_design.accepts(string))
        elif Input ==2 :
            DFA_newStates = []
            DFA_newFinalStates = []
            DFA_newStartState = None
            DFA_states = []
            DFA_alphabet = alphabet
            DFA_finalStates = []
            DFA_startState = "{'" + str(startState) + "'}"
            DFA_Transitions = []
            simulation = NFASimulation(nfa_design)
            dfa_design = simulation.to_dfa_design()
            l = dfa_design.to_dfa().rulebook.rules
            for i in l:
                x = str(i).split("-")
                if(x[0] == 'set()'):
                    x[0] = "empty"
                if(x[2]== 'set()'):
                    x[2]= "empty"
                if x[0] not in DFA_states:
                    DFA_states.append(str(x[0]))
                if x[2] not in DFA_states:
                    DFA_states.append(str(x[2]))
                DFA_Transitions.append([x[0],x[2],x[1]])
            for i in finalStates:
                for j in DFA_states:
                    if i in j :
                        DFA_finalStates.append(j)
            DFA_part_input = 0
            while(DFA_part_input!=5):
                print("DFA Part:")
                print("1-accepting string")
                print("2-minimizing DFA")
                print("3-draw main DFA")
                print("4-draw minimized DFA")
                print("5-exite")
                DFA_part_input = int(input())
                if DFA_part_input == 1 :
                    simulation = NFASimulation(nfa_design)
                    dfa_design = simulation.to_dfa_design()
                    string = input()
                    print(dfa_design.accepts(string))
                elif DFA_part_input == 2 :
                    transitionDict = {}
                    for i in DFA_Transitions:
                        current_state = i[0]
                        terminal = i[2]
                        next_state = i[1]
                        transitionDict[(current_state,terminal)] = next_state
                    print(transitionDict)
                    makeSimpleDFA()
                elif DFA_part_input == 3 :
                    dfa = {}
                    dfa['alphabet'] = set(DFA_alphabet)
                    dfa['states'] = set(DFA_states)
                    ss = []
                    ss.append(DFA_startState)
                    dfa['initial_state'] = set(ss)
                    dfa['accepting_states'] = set(DFA_finalStates)
                    trans = {}
                    for i in DFA_Transitions:
                        trans[(i[0] , i[2])] = i[1]
                    dfa['transitions'] = trans
                    automata_IO.dfa_to_dot(dfa,'dfaout' , '.\\NFA-Graph\\')
                elif DFA_part_input == 4 :
                    minimizedDFA = {}
                    minimizedDFA['alphabet'] = set(DFA_alphabet)
                    minimizedDFA['states'] = set(DFA_newStates)
                    newss = []
                    newss.append(DFA_newStartState)
                    minimizedDFA['initial_state'] = set(DFA_newStartState)
                    minimizedDFA['accepting_states'] = set(DFA_newFinalStates)
                    minimizedDFA['transitions'] = transitionDict
                    automata_IO.dfa_to_dot(minimizedDFA,'Minimized_dfaout' , '.\\NFA-Graph\\')
                elif DFA_part_input == 5 :
                    break
                else:
                    print("wrong input")
        elif Input == 3:
            nfa = {}
            nfa['alphabet'] = set(alphabet)
            nfa['states'] = set(states)
            ss = []
            ss.append(startState)
            nfa['initial_state'] = {str(startState)}
            nfa['accepting_states'] = set(finalStates)
            trans = {}
            for i in Transitions:
                trans[(i[0] , i[2])] = i[1]
            nfa['transitions'] = trans
            automata_IO.dfa_to_dot(nfa,'nfaout' , '.\\NFA-Graph\\')
        elif Input == 4:
            #transition_matrix = [list(map(str, input().split())) for _ in range(len(DFA_states))]
            #transition_funct = dict(zip(states, transition_matrix))
            #r = ''
            #for f in DFA_finalStates:
            #    r+= '+' + toregex()
            #print(r[1:])
            DFA_states = []
            DFA_alphabet = alphabet
            DFA_finalStates = []
            DFA_startState = "{'" + str(startState) + "'}"
            DFA_Transitions = []
            simulation = NFASimulation(nfa_design)
            dfa_design = simulation.to_dfa_design()
            l = dfa_design.to_dfa().rulebook.rules
            for i in l:
                x = str(i).split("-")
                if(x[0] == 'set()'):
                    x[0] = "empty"
                if(x[2]== 'set()'):
                    x[2]= "empty"
                if x[0] not in DFA_states:
                    DFA_states.append(str(x[0]))
                if x[2] not in DFA_states:
                    DFA_states.append(str(x[2]))
                DFA_Transitions.append([x[0],x[2],x[1]])
            for i in finalStates:
                for j in DFA_states:
                    if i in j :
                        DFA_finalStates.append(j)
            handle_start_incoming()
            handle_final_outgoing()

            input_symbols = get_input_symbol()
            reg_exp = DFA_to_regex(input_symbols, DFA_startState[0], DFA_finalStates[0])
            print(out_regex(reg_exp))
