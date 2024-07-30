clc
clear
close all
%% function Definition
f = 10e3
t = 0:  1/f : 1;
x = sawtooth(2*pi*10*t);
plot(t,x)
title('Sawtooth Periodic Wave');
grid on

Ts = 0.01; %seconds/sample
%% an & bn
T=2;
N = 10;
a = zeros(1,N+1);
b = zeros(1,N+1);
for n = 0:N
a(n+1) = (2*Ts/T)*sum(x.*cos(2*pi*n*t/T));
b(n+1) = (2*Ts/T)*sum(x.*sin(2*pi*n*t/T));
end
%% caculate Fourier Series
for n = 1:N
x = x +(a(n+1)*cos(2*pi*n*t/T)+b(n+1)*sin(2*pi*n*t/T));
end
figure(2)
plot(t,x)
title('Sawtooth fourier | N=10');
grid on 

x = sawtooth(2*pi*10*t);
N = 50;
a = zeros(1,N+1);
b = zeros(1,N+1);
for n = 0:N
a(n+1) = (2*Ts/T)*sum(x.*cos(2*pi*n*t/T));
b(n+1) = (2*Ts/T)*sum(x.*sin(2*pi*n*t/T));
end
%% caculate Fourier Series
for n = 1:N
x = x +(a(n+1)*cos(2*pi*n*t/T)+b(n+1)*sin(2*pi*n*t/T));
end
figure(3)
plot(t,x)
title('Sawtooth fourier | N=50');
grid on 

x = sawtooth(2*pi*10*t);
N = 100;
a = zeros(1,N+1);
b = zeros(1,N+1);
for n = 0:N
a(n+1) = (2*Ts/T)*sum(x.*cos(2*pi*n*t/T));
b(n+1) = (2*Ts/T)*sum(x.*sin(2*pi*n*t/T));
end
%% caculate Fourier Series
for n = 1:N
x = x +(a(n+1)*cos(2*pi*n*t/T)+b(n+1)*sin(2*pi*n*t/T));
end
figure(4)
plot(t,x)
title('Sawtooth fourier | N=100');
grid on 

x = sawtooth(2*pi*10*t);
N = 10000;
a = zeros(1,N+1);
b = zeros(1,N+1);
for n = 0:N
a(n+1) = (2*Ts/T)*sum(x.*cos(2*pi*n*t/T));
b(n+1) = (2*Ts/T)*sum(x.*sin(2*pi*n*t/T));
end
%% caculate Fourier Series
for n = 1:N
x = x +(a(n+1)*cos(2*pi*n*t/T)+b(n+1)*sin(2*pi*n*t/T));
end
figure(5)
plot(t,x)
title('Sawtooth fourier | N=10000');
grid on 
