#Code by John Allison, 08-10-2014
import random

word_list = ["jazz", "car", "potato", "george", "python", "jason", "raspberry", "cat", "wrong"]

restart = True

while restart == True:
    
    lives = 5
    
    random.shuffle(word_list) #Shuffles list
    word = (word_list[0])

    guessing = True

    while guessing == True:
        print("You have",lives)
        guess = input("Guess a letter: ")
        if guess == word:
            print("You have guessed right! The word was", word,"!")
            guessing = False
        elif guess in word:
            print("You have guessed a letter!")
        else:
            lives = lives -1
            if lives <= 0:
                guessing = False
            elif lives == 0: #ASCII art
                print("You have",lives, "lives left")
                print("      _______")
                print("     |/      |")
                print("     |      (_)")
                print("     |      \|/")
                print("     |       |")
                print("     |      / \ ")
                print("     |")
                print("    _|___")
                print("GAME OVER")
            elif lives == 1: #ASCII art
                print("You have",lives, "lives left")
                print("      _______")
                print("     |/      |")
                print("     |      (_)")
                print("     |      \|/")
                print("     |       |")
                print("     |")
                print("     |")
                print("    _|___")
            elif lives == 2: #ASCII art
                print("You have",lives,"lives left")
                print("      _______")
                print("     |/      |")
                print("     |      (_)")
                print("     |       |")
                print("     |       |")
                print("     |")
                print("     |")
                print("    _|___")
            elif lives == 3: #ASCII art
                print("You have",lives,"lives left")
                print("      _______")
                print("     |/      |")
                print("     |       |")
                print("     |       |")
                print("     |       |")
                print("     |")
                print("     |")
                print("    _|___")
            elif lives == 4: #ASCII art
                print("You have",lives,"lives left")
                print("      _______")
                print("     |/")
                print("     |")
                print("     |")
                print("     |")
                print("     |")
                print("     |")
                print("    _|___")
            else: #ASCII art
                print("You have",lives,"lives left")
                print("")
                print("")
                print("")
                print("")
                print("")
                print("")
                print("")
                print("    _|___")

    #Restart input
    again = input("Would You Like To Restart? (Y/N):  ")
    if again == ("Y") or again == ("y"):
        restart = True
    else:
        restart = False
