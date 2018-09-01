#Code by John Allison, resources by Lee Johnson, 25-09-2014
restart = True
print ("Think Of A Number Between 0-100")

low = 0 #Defines the two values
high = 101

while restart == True:
    loop = True

    while loop == True:
        guess = (int((low+high)/2)) #LOW + HIGH / 2, then converts to an int value
        print ("Is Your Number", guess)
        human = input("High, Lower or Correct:  ")
        if human == "l" or "L":
            high = guess #Changes the higher value to the guess
        elif human == "h" or "H":
            low = guess #Changes the lower value to the guess
        elif human == "c" "C":
            print ("I Got It!")
            loop = False
            low = 0
            high = 101

    #Restart input
    again = input("Would You Like To Restart? (Y/N):  ")
    if again == ("Y") or again == ("y"):
        restart = True
    else:
        restart = False
