A = imread('Pic.jpg');
##imshow(A),title('Original Image');
B=im2double(A);
bright_add = 0.2;
##imhist(A), title('Original Histogram');
C=B+bright_add;
##imshow(C),title('New Bright Image');
imhist(C), title('New Histogram');
