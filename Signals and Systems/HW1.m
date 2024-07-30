t= 0:0.01:3;
f= 1;
x= 4*sin(2*pi*f*t);
figure(1)
subplot(2,1,1)
plot (t,x)
title('Sine Wave')
xlabel('Time')
ylabel('Amplitude')
subplot(2,1,2)
stem(x)
xlabel('Time')
ylabel('Amplitude')
h = cos(10*pi*f*t);
y = conv(h , x,'same')*1;
figure(2)
subplot(3,1,1)
plot (t,x)
title('Sine Wave')
xlabel('Time')
subplot(3,1,2)
plot (t,h)
title('Cosine Wave (message wave)')
xlabel('Time')
subplot(3,1,3)
plot (t,y)
title('Conv Wave')
xlabel('Time')
ylabel('Amplitude')
figure(3)
subplot(2,1,1)
plot (t,x)
title('Sine Wave')
subplot(2,1,2)
plot(xcorr(x,x))
title('corr(x,x)')
figure(4)
sys = tf([1 2], [5 0.5 2]) ;
#x = sign(x)
z = lsim(sys , x , t) ;
plot(t , x , 'r' , t , z , 'b' , 'LineWidth' , 2);
grid on
xlabel('Time (Second)') ; ylabel('Amp') ; title('Messgae Signal') ;
legend('x' ,'z' ) ;
ylim([-1.5 1.5])
