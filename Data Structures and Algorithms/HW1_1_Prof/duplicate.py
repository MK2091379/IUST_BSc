def DupStr(Str):
    if len(Str)%2 != 0:
        return False
    if len(Str) == 0:
        return True
    if Str[:len(Str)//2] != Str[len(Str)//2:]:
        return False
    return DupStr(Str[1:len(Str)//2])
print(DupStr(input()))
################## time complexity = log(n)