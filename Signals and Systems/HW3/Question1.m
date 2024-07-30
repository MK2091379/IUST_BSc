clear all
close all
clc
syms t;
x = (2/pi) * sin(t);
y = (2/(pi*3)) * sin(3*t);
z = x*y;
syms T;
k = (1/T) * int(z,t,-T/2,T/2);
result = limit(k,T,inf);
disp(result)
if !result
disp('orthogonal')
else
disp('not orthogonal')
end
for j = 1:100
v = x(:,j)*y(:,j)
value = limit(v,T,inf);
if value~=0
orth=0;
break;
end
end
if orth
disp('orthogonal')
else
disp('not orthogonal')
end
