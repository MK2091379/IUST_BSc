import matplotlib.pyplot as plt 
import numpy as np
import math 
from time import sleep
class expression: 
    def __init__(self, capacity): 
        self.top = -1 
        self.capacity = capacity 
        self.array = [] 
        self.output = [] 
        self.precedence = {'+':1, '-':1, '*':2, '/':2, '!':2,'~':3, '^':4} 
    def isEmpty(self): 
        return True if self.top == -1 else False
    def peek(self): 
        return self.array[-1] 
    def pop(self): 
        if not self.isEmpty(): 
            self.top -= 1
            return self.array.pop() 
        else: 
            return "$"
    def push(self, op): 
        self.top += 1
        self.array.append(op)  
    def isOperand(self, ch): 
        return ch.isalpha() 
    def notGreater(self, i): 
        try: 
            a = self.precedence[i] 
            b = self.precedence[self.peek()] 
            return True if a  <= b else False
        except KeyError:  
            return False
    def evaluatePostfix(self, exp,value,mode,delay):
        if(mode == 2):
            print("evaluatePostfix by stack")
            print("___________________________________________") 
        for i in exp: 
            if i.isalpha():
                i = value 
                self.push(str(i))
                if(mode == 2):
                    print(str(self.array))
                    input("press enter")
                    sleep(delay)
            elif i.isdigit():
                self.push(str(i))
                if(mode == 2):
                    print(str(self.array))
                    input("press enter")
                    sleep(delay)
            else: 
                val1 = self.pop() 
                if(mode == 2):
                    print(str(self.array))
                    input("press enter")
                    sleep(delay)
                val2 = self.pop() 
                if(mode == 2):
                    print(str(self.array))
                    input("press enter")
                    sleep(delay)
                if(i!='^' and i!='!' and i!='~'):
                    self.push(str(eval(val2 + i + val1))) 
                    if(mode == 2):
                        print(str(self.array))
                        input("press enter")
                        sleep(delay)
                elif(i=='^'):
                    self.push(str(str(float(val2)**float(val1))))
                    if(mode == 2):
                        print(str(self.array))
                        input("press enter")
                        sleep(delay)
                elif(i=='!'):
                    self.push(str(str(math.factorial(float(val1)))))
                    if(mode == 2):
                        print(str(self.array))
                        input("press enter")
                        sleep(delay)
                elif(i=='~'):
                    self.push(str(str(-(float(val1)))))
                    if(mode == 2):
                        print(str(self.array))
                        input("press enter")
                        sleep(delay)
        if(mode == 2):
            print("___________________________________________") 
        return float(self.pop()) 
    def infixToPostfix(self, exp,mode,delay): 
        if(mode == 2):
            print("infixToPostfix")
            print("___________________________________________")
        for i in exp: 
            if self.isOperand(i): 
                self.output.append(i) 
                if(mode == 2):
                    print("output: " + str(self.output))
                    input("press enter")
                    sleep(delay)
            elif i  == '(': 
                self.push(i) 
                if(mode == 2):
                    print("stack: " + str(self.array))
                    input("press enter")
                    sleep(delay)
            elif i == ')': 
                while( (not self.isEmpty()) and 
                                self.peek() != '('): 
                    a = self.pop() 
                    if(mode == 2):
                        print("stack: " + str(self.array))
                        input("press enter")
                        sleep(delay)
                    self.output.append(a)
                    if(mode == 2):
                        print("output: " + str(self.output))
                        input("press enter")
                        sleep(delay) 
                if (not self.isEmpty() and self.peek() != '('): 
                    return -1
                else: 
                    self.pop() 
                    if(mode == 2):
                        print("stack: " + str(self.array))
                        input("press enter")
                        sleep(delay)
            else: 
                while(not self.isEmpty() and self.notGreater(i)): 
                    self.output.append(self.pop()) 
                    if(mode == 2):
                        print("output: " + str(self.output))
                        input("press enter")
                        sleep(delay)
                    if(mode == 2):
                        print("output: " + str(self.output))
                        input("press enter")
                        sleep(delay)
                self.push(i) 
                if(mode == 2):
                    print("stack: " + str(self.array))
                    input("press enter")
                    sleep(delay)
        while not self.isEmpty(): 
            self.output.append(self.pop())
            if(mode == 2):
                print("stack: " + str(self.array))
                input("press enter")
                sleep(delay) 
            if(mode == 2):
                print("output: " + str(self.output))
                input("press enter")
                sleep(delay)
        if(mode == 2):
            print("___________________________________________")
        return "".join(self.output)
def darwGraph_mode1(function,Xvar):
    Yvar = []
    func = expression(len(function))
    for value in Xvar:
        Yvar.append(func.evaluatePostfix(function,value,1,0))
    plt.plot(Xvar,Yvar, color='green', linestyle='dashed', linewidth = 3, 
         marker='o', markerfacecolor='blue', markersize=12) 
    plt.xlabel('x - axis') 
    plt.ylabel('y - axis') 
    plt.title('Some cool customizations!') 
    plt.show() 
def darwGraph_mode2(function,Xvar):
    print("enter delay time")#وارد کردن زمان تاخیر
    delay = int(input())
    Yvar=[]
    obj = expression(len(function))
    func = obj.infixToPostfix(function,2,delay)
    Ofunc = expression(len(func))
    counter = 1
    for value in Xvar:
        Yvar.append(Ofunc.evaluatePostfix(func,value,2,delay))
        plt.plot(Xvar[:counter],Yvar, color='green', linestyle='dashed', linewidth = 3, 
         marker='o', markerfacecolor='blue', markersize=12) 
        plt.xlabel('x - axis') 
        plt.ylabel('y - axis') 
        plt.title('Some cool customizations!') 
        plt.show(block = False) 
        plt.pause(delay)
        plt.close()      
        counter+=1  
print("enter X-axis inputs")
Xvar = [float(i) for i in input().split()] #فرمت ورودی مقادیر ایکس  : a b c d e f g h i ...   یک رشته از اعداد به ترتیب صعودی که با فاصله از هم جدا شدند
print("enter your function")
function = input() #یک تابع بر حسب ایکس
obj = expression(len(function))
func = obj.infixToPostfix(function,1,0)
darwGraph_mode1(func,Xvar)
#darwGraph_mode2(function,Xvar)