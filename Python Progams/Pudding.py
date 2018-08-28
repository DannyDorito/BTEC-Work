#Code by John Allison, 25-09-2014
import random

restart = True

while restart == True:
    flavours = ["Chocolate", "Banana", "Mint", "Vanilla", "Strawberry", "Raspberry", "Beef", "Chicken"]
    desserts = ["Pie", "Ice Cream", "Pudding", "Cake", "Biscuit", "Wafer"]

    for loop in range(1, 101): #Every time this counts up
        random.shuffle(flavours) #Shuffles list
        random.shuffle(desserts) #Shuffles list
        print(flavours[0], flavours[1], desserts[0])

    restart = False

    #Restart input
    again = input("Would You Like To Restart? (Y/N):  ")
    if again == ("Y") or again == ("y"):
        restart = True
    else:
        restart = False
