#Code by John Allison, 15-09-2014
restart = True

while restart == True:
    print("Welcome to a conversion tool")
    print("1. Convert Fahrenheit to Celsius")
    print()
    print("2. Convert Celsius to Fahrenheit")
    print()
    print("3. Exit")
    Conversion = input("Enter Choice: ")
    
    if Conversion == ("1"):
        Fahrenheit = int(input("Enter Fahrenheit: "))
        Answer = (Fahrenheit - 32) * 5 / 9 #Conversion sum
        print("The answer is", Answer, "°C")
    elif Conversion == ("2"):
        Celsius = int(input("Enter Celsius: "))
        Answer = (Celsius * 1.8) + 32 #Conversion sum
        print("The answer is", Answer, "°F")
    elif Conversion == ("3"): #Exits the program
        restart = False 
    else:
        Answer = 0 #Defaults to 0
        restart = True

    restart = False

    #Restart input
    again = input("Would You Like To Restart? (Y/N):  ")
    if again == ("Y") or again == ("y"):
        restart = True
    else:
        restart = False
