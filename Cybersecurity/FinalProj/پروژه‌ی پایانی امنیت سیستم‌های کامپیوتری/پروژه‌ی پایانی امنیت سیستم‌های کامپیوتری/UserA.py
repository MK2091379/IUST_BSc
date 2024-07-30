import random  
from math import pow,gcd

def gen_key(q): 
  
    key = random.randint(pow(10, 20), q) 
    while gcd(q, key) != 1: 
        key = random.randint(pow(10, 20), q) 
  
    return key 
  

def mod_exp(b,e,mod):
    r = 1
    while e > 0:
        if (e&1) == 1:
            r = (r*b)%mod
        b = (b*b)%mod
        e >>= 1
    return r
  
 
def encrypt(msg, q, h, g): 
  
    en_msg = [] 
  
    k = gen_key(q)
    s = mod_exp(h, k, q) 
    p = mod_exp(g, k, q) 
      
    for i in range(0, len(msg)): 
        en_msg.append(msg[i]) 
  
    for i in range(0, len(en_msg)): 
        en_msg[i] = s * ord(en_msg[i]) 
  
    return en_msg, p 
  
def decrypt(en_msg, p, key, q): 
  
    dr_msg = [] 
    h = mod_exp(p, key, q) 
    for i in range(0, len(en_msg)): 
        dr_msg.append(chr(int(en_msg[i]/h))) 
          
    return dr_msg 
  


def main(): 

  
    q = random.randint(pow(10, 20), pow(10, 50)) 
    g = random.randint(2, q) 
  
    key = gen_key(q) 
    h = mod_exp(g, key, q) 
    print("user g : ", g) 
    print("user h : ", h) 
    print("user q : ", q) 
    print("________________________________________________")
    Og=int(input("enter other side g:"))
    Oh=int(input("enter other side h:"))
    Oq=int(input("enter other side q:"))




    cmd=""
    while(cmd !="exit"):
        cmd = input("**********************************\nThis Is User A \nsend message : 1 \ndecode recived message : 2 \nexit : exit \n")
        if(cmd=='1'):
            msg=input("enter message:")
            en_msg, p = encrypt(msg, Oq, Oh, Og)
            print("encrypted message :"+str(en_msg)+"\n"+"p:"+str(p)+"\n")
        elif(cmd=='2'):
            msg=input("enter encrypted message:")
            msg = msg.strip('][').split(',')
            for i in range(len(msg)):
                msg[i]=int(msg[i])
            p=int(input("enter p :"))
            dr_msg = decrypt(msg, p, key, q) 
            dmsg = ''.join(dr_msg) 
            print("decrypted message :", dmsg); 
        elif(cmd!="exit"):
            print("wrong input!")


if __name__ == '__main__': 
    main() 