%STEP2____________________________________________________
my_image=imread('Pic.jpg');
##imshow(my_image);
B=im2double(my_image);
bright_add = 0.2;
C=B+bright_add;
imshow(C);
imwrite(grayImage,'high_contrast_Pic.jpg');
