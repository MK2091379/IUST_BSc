clear all
close all
clc
T = 12;
f = 1/T;
w=2*pi*f;
t=-T/2:0.001*T:T/2;
s=0;
for n=1:155
a(n) = 2*sin(n*pi/2)/(n*pi);
s=s+a(n)*cos(n*w*t);
end
s = s + 0.5
subplot(2,1,1)
plot(t,s,'r')
grid on
y = conv(s,s,'same')
subplot(2,1,2)
plot(t,y)
