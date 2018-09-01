#Code by John Allison, 12-09-2014
restart = True
print("Welcome to the calculator.")

while restart == True:

    calculator = True
    while calculator == True:
        first = int(input("First Number: "))
        second = int(input("Second Number: "))
        op = input("Operator: ")
    
        if op == ("+"): #If the operator is +
            Answer = first + second
        elif op == ("-"): #If the operator is -
            Answer = first - second
        elif op == ("*"): #If the operator is *
            Answer = first * second
        elif op == ("/"): #If the operator is /
            Answer = first / second
        else:
            Answer = 0 #Defaults to 0 if input is != if statements
            restart = True
        print("Answer:", Answer)
        calculator = False

    restart = False

    #Restart input
    again = input("Would You Like To Restart? (Y/N):  ")
    if again == ("Y") or again == ("y"):
        restart = True
    else:
        restart = False
