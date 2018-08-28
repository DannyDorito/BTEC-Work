#Code by John Allison, 25-09-2014
import random
restart = True

while restart == True:
    strength1 = 0 #Set these due to restart
    skill1 = 0
    strength2 = 0
    skill2 = 0

    #Character 1
    dice12_1 = random.randrange(1,13)
    dice4_1 = random.randrange(1,5)

    strength1 = int((dice12_1 / dice4_1) + 10) #Calculates strength for charater 1, rounds

    dice12_2 = random.randrange(1,13)
    dice4_2 = random.randrange(1,5)

    skill1 = int((dice12_2 / dice4_2) + 10) #Calculates skill for charater 1, rounds
    
    print("Character One")
    print()
    print("Your Strength is: ", strength1) #Displays the strength
    print("Your Skill is:", skill1) #Displays the skill
    print()

    #Character 2
    dice12_3 = random.randrange(1,13)
    dice4_3 = random.randrange(1,5)

    strength2 = (int(dice12_3 / dice4_3) + 10) #Calculates strength for charater 2, rounds

    dice12_4 = random.randrange(1,13)
    dice4_4 = random.randrange(1,5)

    skill2 = (int(dice12_4 / dice4_4) + 10) #Calculates skill for charater 2, rounds

    print("Character Two")
    print()
    print("Your Strength is: ", strength2) #Displays the strength
    print("Your Skill is:", skill2) #Displays the skill
    print()

    #Restart input
    again = input("Would You Like To Restart? (Y/N):  ")
    if again == ("Y") or again == ("y"):
        restart = True
    else:
        restart = False

