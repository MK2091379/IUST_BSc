from hashlib import new
import statistics
import matplotlib.pyplot as plt
import numpy as np


ssid=list()
values=list()




f = open("packets.txt", "r")
for line in f:
    spilited=line.split()
    if(len(spilited)==3):
        if(spilited[1] not in ssid):
            ssid.append(spilited[1])
            values.append([])
        index=ssid.index(spilited[1])
        values[index].append(int(spilited[2]))

newssid=list()
for i in range(1,3): 
    newssid.append(bytes.fromhex(ssid[i]).decode())
    print(newssid[i-1])
Average=list()
deviation=list()

for i in range(len(newssid)):
    deviation.append(statistics.stdev(values[i]))
    Average.append(statistics.mean(values[i]))

print(Average)
print(deviation)

plt.bar(newssid, Average,color='red')
plt.title('APs and RSSI')
plt.xlabel('SSID')
plt.ylabel('RSSI')



def get_d (RSSI,A,n):
    k=A-RSSI
    k=k/(10*n)
    return 10**k    


distance=[]
for item in Average:
    distance.append(get_d(item,-55,3))
    
label_loc = np.linspace(start=0, stop=2 * np.pi-(2*np.pi/len(newssid)), num=len(newssid))
plt.figure(figsize=(20, 20))
plt.subplot(polar=True)
plt.polar(label_loc, distance, 'ro')
plt.title('Distance Diagram (m)', size=30)
lines, labels = plt.thetagrids(np.degrees(label_loc), labels=newssid)
plt.show()
