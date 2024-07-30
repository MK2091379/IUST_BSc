
from AES import AES

if __name__ == '__main__':
    plaintext = 0x3243f6a8885a308d313198a2e0370734
    print(f"plaintext:{hex(plaintext)}")
    master_key = 0x2b7e151628aed2a6abf7158809cf4f3c
    aes = AES(master_key)
    encrypted = aes.encrypt(plaintext)
    print(f"encrypted:{hex(encrypted)}")
    decrypted = aes.decrypt(encrypted)
    print(f"decrypted:{hex(decrypted)}")
