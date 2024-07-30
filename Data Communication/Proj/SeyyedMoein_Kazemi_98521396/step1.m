%STEP1_____________________________________________________
my_image=imread('Pic.jpg');
imshow(my_image);
size_of_image = size(my_image);
##imtool(my_image);
grayImage=rgb2gray(my_image);
imwrite(grayImage,'gray_Pic.jpg');
