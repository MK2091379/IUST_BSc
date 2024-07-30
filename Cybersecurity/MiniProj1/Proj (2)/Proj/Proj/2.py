
from PIL import Image

size = (500, 100)
crop_image = Image.open("Logo.png")
crop_image.thumbnail(size)


copied_image = Image.open("image.jpg")

copied_image.paste(crop_image, (500, 200))


copied_image.save("test1.png","png")
