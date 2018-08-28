#Code by John Allison, 17-09-2014
import random

restart = True

while restart == True:
    heads = 0 #Have to define a value
    tails = 0
    
    for loop in range(1, 101): #Every time this counts up
        coin = random.randrange(0,2)

        if coin == 0:
            heads = heads + 1 #Adds a value to heads if 0

        else:
            tails = tails + 1 #Adds a value to tails if 1

    #Then Prints a value after 100
    print("The value of heads:", heads)
    print()
    print("The valus of tails:", tails)

    restart = False

    #Restart input
    again = input("Would You Like To Restart? (Y/N):  ")
    if again == ("Y") or again == ("y"):
        restart = True
    else:
        restart = False
