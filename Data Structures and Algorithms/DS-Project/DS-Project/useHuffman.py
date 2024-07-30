from huffman import HuffmanCoding
import sys
while True:
    print('1. code a text')
    print('2. decode a text')
    print('3. exit')
    command = int(input())
    if command == 1:
        path = input('name of your file: ')
        h = HuffmanCoding(path)
        output_path = h.compress()
        print("Compressed file path: " + output_path)
    elif command == 2:
        path = input('name of your file: ')
        h = HuffmanCoding(path)
        decom_path = h.decompress(path)
        print("Decompressed file path: " + decom_path)
    elif command == 3:
        break









#path = "sample.txt"
#h = HuffmanCoding(path)
#output_path = h.compress()
#print("Compressed file path: " + output_path)
#decom_path = h.decompress(output_path)
#print("Decompressed file path: " + decom_path)