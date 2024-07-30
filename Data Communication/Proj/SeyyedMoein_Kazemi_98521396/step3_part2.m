my_image=imread('Pic.jpg');
##imshow(my_image);
A=imresize((imresize(my_image,4)),1/2);
imshow(A);
