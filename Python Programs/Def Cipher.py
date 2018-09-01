def cipher(plain):
    cipher = "" #Defines an empty value

    for letters in plain:
        cipher = cipher + chr(ord(letters) +5) #Converts to ASCII, adds 5, converts back

    return cipher

print(cipher("cipher"))

def decipher(decode):
    decode = "" #Defines and empty value
        
    for letters in plain:
        decode = decode + chr(ord(letters) -5) #Converts to ASCII, takes-away 5, converts back

    return decode

print(cipher("cipher"))
