clc
clear all
close all
function [ao,an,bn] = fs1(f,T,N)
t2 = -2*T:Ts:2*T; % t synthesis
fs = (a(1)/2)*ones(size(t2));
for n = 1:N
fs = fs +(a(n+1)*cos(2*pi*n*t2/T)+b(n+1)*sin(2*pi*n*t2/T));
end;
endfunction
fs = 1000;
t = 0:1/fs:1.5;
f = sawtooth(2*pi*50*t);
subplot(211);
plot(t,f);
axis([0 0.2 -1.2 1.2]);
title('Sawtooth Periodic Wave');
grid on 