#Code by John Allison, 01-10-2014
restart = True

while restart == True:
    print("Welcome to the letter cipher")
    
    cipher_input = input("Would you like to encrypt or decrypt a code (E/D): ")

    if cipher_input == "E" or cipher_input == "e":
        plain = input("Input your code: ")
        cipher = "" #Defines an empty value

        for letters in plain:
            cipher = cipher + chr(ord(letters) +5) #Converts to ASCII, adds 5, converts back
        print(cipher)
        
    elif cipher_input == "D" or cipher_input == "d":
        plain = input("Input your code: ")
        decode = "" #Defines and empty value
        
        for letters in plain:
            decode = decode + chr(ord(letters) -5) #Converts to ASCII, takes-away 5, converts back
        print(decode)
        
    else:
        restart = True
        
    #Restart input
    again = input("Would You Like To Restart? (Y/N):  ")
    if again == ("Y") or again == ("y"):
        restart = True
    else:
        restart = False
