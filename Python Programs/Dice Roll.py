#Code by John Allison, 10-09-2014
import random

restart = True

while restart == True:

    dice1 = random.randrange(1,7) #Random 1-6
    print("Dice 1 is: ")
    print(dice1)
    dice2 = random.randrange(1,7) #Random 1-6
    print("Dice 2 is: ")
    print(dice2)
    dice3 = random.randrange(1,7) #Random 1-6
    print("Dice 3 is: ")
    print(dice3)

    game = True

    while game == True:
        
        print("Welcome to the oh baby a triple dice rolling game.")
        if dice1 == dice2 and dice2 == dice3:
            score = dice1 * 3
        elif dice1 == dice2:
            score = (dice1 * 2) - dice3
        elif dice2 == dice3:
            score = (dice2 * 2) - dice1
        elif dice1 == dice3:
            score = (dice1 * 2) - dice2
        else:
            score = 0
        print("Your score is:  ", score)
        game = False

    #Restart input
    again = input("Would You Like To Restart? (Y/N):  ")
    if again == ("Y") or again == ("y"):
        restart = True
    else:
        restart = False
