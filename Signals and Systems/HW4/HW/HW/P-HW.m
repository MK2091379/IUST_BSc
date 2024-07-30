clc
clear
close all

%% 1
f_saw = 10e4;
t_saw = 0: 1/f_saw : 1;
x_saw = sawtooth(2*pi*100*t_saw);
figure(1);
subplot(2,1,1)
plot(t_saw,x_saw);

grid on

subplot(2,1,2)
Y=fft(x_saw);
plot(t_saw,abs(fftshift(Y)))

grid on


t = linspace(-pi,2*pi,121);
x = 1.25*square(2*t);
figure(2);
subplot(2,1,1)
plot(t/pi,x,'.-',t/pi,1.15*sin(2*t))
y2 = fft(x)
subplot(2,1,2)
plot(t,abs(fftshift(y2)))
grid on
%% pulse train
fs = 100E9;
D = [2.5 10 17.5]' * 1e-9; % pulse delay times
t2 = 0 : 1/fs : 2500/fs; % signal evaluation time
w = 1e-9; % width of each pulse
x3 = pulstran(t2,D,@rectpuls,w);
figure(3)
subplot(2,1,1)
plot(t2,x3)
Y3=fft(x3);
subplot(2,1,2)
plot(fftshift(Y3))



%% 2
t = linspace(-pi,2*pi,121);
x = 1.25*square(2*t);
figure(1);
subplot(2,1,1)
plot(t/pi,x,'.-',t/pi,1.15*sin(2*t))
y2 = fft(x)
subplot(2,1,2)
plot(t,abs(fftshift(y2)))
grid on


f_saw = 10e4;
t_saw = 0: 1/f_saw : 1;
x_saw = sawtooth(2*pi*10*t_saw);
figure(2);
subplot(2,1,1)
plot(t_saw,x_saw);

grid on

subplot(2,1,2)
Y=fft(x_saw);
plot(t_saw,abs(fftshift(Y)))

grid on

output = conv(x, x_saw);
figure(3)
plot(output);
grid on;

Y3 = fft(conv(x, x_saw))
figure(4)
plot(Y3)