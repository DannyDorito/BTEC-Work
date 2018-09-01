#Code by John Allison, 25-09-2014
import random

restart = True

dice1 = 0
dice2 = 0
dice3 = 0
while restart == True:
    
    pick = input(" What dice do you want to roll? (4,6,12) :  ")
    
    if pick == "4":
        dice1 = random.randrange(1,5) #Rolls the 4 sided
        print("The 4 Sided dice is: ", dice1)
    elif pick == "6":
        dice2 = random.randrange(1,7) #Rolls the 6 sided
        print("The 6 Sided dice is: ", dice2)
    elif pick == "12":
        dice3 = random.randrange(1,13) #Rolls the 12 sided
        print("The 12 Sided dice is: ", dice3)
    else:
        restart = False

	#Restart input
    again = input("Would You Like To Restart? (Y/N):  ")
    if again == ("Y") or again == ("y"):
        restart = True
    else:
        restart = False

