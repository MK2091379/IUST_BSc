# analysis.py
# -----------
# Licensing Information:  You are free to use or extend these projects for
# educational purposes provided that (1) you do not distribute or publish
# solutions, (2) you retain this notice, and (3) you provide clear
# attribution to UC Berkeley, including a link to http://ai.berkeley.edu.
# 
# Attribution Information: The Pacman AI projects were developed at UC Berkeley.
# The core projects and autograders were primarily created by John DeNero
# (denero@cs.berkeley.edu) and Dan Klein (klein@cs.berkeley.edu).
# Student side autograding was added by Brad Miller, Nick Hay, and
# Pieter Abbeel (pabbeel@cs.berkeley.edu).


######################
# ANALYSIS QUESTIONS #
######################

# Set the given parameters to obtain the specified policies through
# value iteration.

def question2():
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    answerDiscount = 0.9
    answerNoise = 0.0
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    return answerDiscount, answerNoise
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1

def question3a():
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    answerDiscount = 0.1
    answerNoise = 0
    answerLivingReward = 0.5
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    return answerDiscount, answerNoise, answerLivingReward
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    # If not possible, return 'NOT POSSIBLE'

def question3b():
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    answerDiscount = 0.1
    answerNoise = 0.1
    answerLivingReward = 0.5
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    return answerDiscount, answerNoise, answerLivingReward
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    # If not possible, return 'NOT POSSIBLE'

def question3c():
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    answerDiscount = 0.1
    answerNoise = 0.0
    answerLivingReward = 5
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    return answerDiscount, answerNoise, answerLivingReward
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    # If not possible, return 'NOT POSSIBLE'

def question3d():
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    answerDiscount = 0.1
    answerNoise = 0.1
    answerLivingReward = 5
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    return answerDiscount, answerNoise, answerLivingReward
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    # If not possible, return 'NOT POSSIBLE'

def question3e():
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    answerDiscount = 0.1
    answerNoise = 0.0
    answerLivingReward = 100
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    return answerDiscount, answerNoise, answerLivingReward
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    # If not possible, return 'NOT POSSIBLE'

def question8():
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    answerEpsilon = 0.4
    answerLearningRate = 0.8
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1

    return 'NOT POSSIBLE'
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    # If not possible, return 'NOT POSSIBLE'

if __name__ == '__main__':
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
    print('Answers to analysis questions:')
    import analysis
    for q in [q for q in dir(analysis) if q.startswith('question')]:
        response = getattr(analysis, q)()
        print('  Question %s:\t%s' % (q, str(response)))
    MOEIN = 0
    MATIN = 0
    AMIN = 0
    for i in range(100):
        MOEIN +=1
    while(MOEIN!=0):
        AMIN+=1
        MOEIN-=1
    for i in range(100):
        MATIN+=1
