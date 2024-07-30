from PIL import Image
import enchant

def modPix(pix, data):
	datalist = []
	for i in data:
		datalist.append(format(ord(i), '08b'))
	imdata = iter(pix)
	for i in range(len(datalist)):
		pix = [value for value in imdata.__next__()[:3] +
								imdata.__next__()[:3] +
								imdata.__next__()[:3]]

		for j in range(0, 8):
			if (datalist[i][j] == '0' and pix[j]% 2 != 0):
				pix[j] -= 1

			elif (datalist[i][j] == '1' and pix[j] % 2 == 0):
				if(pix[j] != 0):
					pix[j] -= 1
				else:
					pix[j] += 1
		if (i == len(datalist) - 1):
			if (pix[-1] % 2 == 0):
				if(pix[-1] != 0):
					pix[-1] -= 1
				else:
					pix[-1] += 1

		else:
			if (pix[-1] % 2 != 0):
				pix[-1] -= 1

		pix = tuple(pix)
		yield pix[0:3]
		yield pix[3:6]
		yield pix[6:9]
	
def encode():
	img = input("image name? ")
	image = Image.open(img, 'r')
	data = input("data to be encoded? ")
	newimg = image.copy()
	(x, y) = (0, 0)
	for pix in modPix(newimg.getdata(), data):
		newimg.putpixel((x, y), pix)
		if (x ==  newimg.size[0] - 1):
			x = 0
			y += 1
		else:
			x += 1
	new_img_name = input("Enter the name of new image(with extension) : ")
	newimg.save(new_img_name, str(new_img_name.split(".")[1].upper()))


def is_meaningful(text:str):
	words_of_text = text.split()
	is_correct = True
	d = enchant.Dict("en_US")
	for w in words_of_text:
		if not d.check(w):
			is_correct = False
	return "It is meaningful" if is_correct else "not meaningful"


def decode():
	img = input("image name? ")
	image = Image.open(img, 'r')

	data = ''
	imgdata = iter(image.getdata())

	while (True):
		pixels = [value for value in imgdata.__next__()[:3] +
								imgdata.__next__()[:3] +
								imgdata.__next__()[:3]]
		binstr = ''
		for i in pixels[:8]:
			if (i % 2 == 0):
				binstr += '0'
			else:
				binstr += '1'
		data += chr(int(binstr, 2))
		if (pixels[-1] % 2 != 0):
			return f"{data} , {is_meaningful(data)}"
			
if __name__ == '__main__' :
	a = int(input("1. Encode\n2. Decode\n"))
	if (a == 1):
		encode()
	elif (a == 2):
		print("Decoded Text : " + decode())

