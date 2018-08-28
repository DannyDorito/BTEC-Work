#Code by John Allison, 10-09-2014
import random

restart = True

while restart == True:
    
    computer_number = random.randrange(1,11) #Imports random number 1-10

    game = True

    print("Welcome to the Guessing Game")

    while game == True:
        human_number = int(input("Enter Guess: "))
        if human_number == computer_number:
            print("Correct, you are the best guesser!")
            game = False
        elif human_number > computer_number: #Human number > computer number
            print("Too high!")
        else:
            print("Too low!")

    #Restart input
    again = input("Would You Like To Restart? (Y/N):  ")
    if again == ("Y") or again == ("y"):
        restart = True
    else:
        restart = False
