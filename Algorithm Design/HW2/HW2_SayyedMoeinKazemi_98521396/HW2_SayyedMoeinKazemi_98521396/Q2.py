class Show:
    start = 0
    time = 0
    ticket = 0
    finish = 0
    def __init__(self,start,time,ticket):
        self.start = start
        self.time = time
        self.ticket = ticket
        self.finish = self.start+self.finish
    def func(self):
        return self.start+self.time
shows = [
    Show(1,5,6),Show(1,2,8),Show(6,10,3),Show(5,9,7),Show(8,11,4)
]
shows = sorted(shows,key = lambda x : (x.start))
tmp = shows[0]
del shows[0]
prof = 0
for i in range(len(shows)):
    if tmp.func()>shows[i].start:
        if(shows[i].ticket>tmp.ticket):
            prof+=(shows[i].start-tmp.start)/tmp.time*tmp.ticket
            tmp = shows[i]
    else:
        prof+=tmp.ticket
        tmp= shows[i]
print(prof)

