#Code by John Allison, 13-10-2014
import random

coinlist = ["heads", "tails"]
previous_movelist = []
player1_name = ""
player2_name = ""

#Move Coordinates
a1 = "*"
a2 = "*"
a3 = "*"
b1 = "*"
b2 = "*"
b3 = "*"
c1 = "*"
c2 = "*"
c3 = "*"

restart = True
gamestart = True
move = ""
xmove = False
omove = False

while restart == True:
    while gamestart == True:
        print("Welcome to tic tac toe!")
        print(player1_name + "You are x's")
        print(player2_name + "You are o's")
        print(player1_name + "You are going first")
        print("    A   B   C")
        print("1 |_"+a1 +"_|_" +b1 +"_|_" +c1 +"_|")#Prints board
        print("2 |_"+a2 +"_|_" +b2 +"_|_" +c2 +"_|")
        print("3 |_"+a3 +"_|_" +b3 +"_|_" +c3 +"_|")
        print()
        xmove = True
        while xmove == True:
            move = input("Where do you want to move? : ")
            if move == "a1":
                a1 = "x"
            elif move == "a2":
                a2 = "x"
            elif move == "a3":
                a3 = "x"
            elif move == "b1":
                b1 = "x"
            elif move == "b2":
                b2 = "x"
            elif move == "b3":
                b3 = "x"
            elif move == "c1":
                c1 = "x"
            elif move == "c2":
                c2 = "x"
            elif move == "c3":
                c3 = "x"
            print("    A   B   C")
            print("1 |_"+a1 +"_|_" +b1 +"_|_" +c1 +"_|")#Prints board
            print("2 |_"+a2 +"_|_" +b2 +"_|_" +c2 +"_|")
            print("3 |_"+a3 +"_|_" +b3 +"_|_" +c3 +"_|")
            print()
            gamestart = False
            xmove = False
            omove = True
        while omove == True:
            move = input("Where do you want to move? : ")
            if move == "a1":
                a1 = "o"
            elif move == "a2":
                a2 = "o"
            elif move == "a3":
                a3 = "o"
            elif move == "b1":
                b1 = "o"
            elif move == "b2":
                b2 = "o"
            elif move == "b3":
                b3 = "o"
            elif move == "c1":
                c1 = "o"
            elif move == "c2":
                c2 = "o"
            elif move == "c3":
                c3 = "o"
            print("    A   B   C")
            print("1 |_"+a1 +"_|_" +b1 +"_|_" +c1 +"_|")#Prints board
            print("2 |_"+a2 +"_|_" +b2 +"_|_" +c2 +"_|")
            print("3 |_"+a3 +"_|_" +b3 +"_|_" +c3 +"_|")
            print()
            xmove = True
            omove = False
        if a1 == a2 and a2 == a3 and a1 == "x" or a1 == "o": #Winning conditions
            if a1 == "x":
                print("Congrats" + player1_name)
            elif a1 == "o":
                print("Congrats" + player2_name)
        elif b1 == b2 and b2 == b3 and a1 == "x" or a1 == "o":
            if b1 == "x":
                print("Congrats" + player1_name)
            elif b1 == "o":
                print("Congrats" + player2_name)
        elif c1 == c2 and c2 == c3 and a1 == "x" or a1 == "o":
            if c1 == "x":
                print("Congrats" + player1_name)
            elif c1 == "o":
                print("Congrats" + player2_name)
        elif a1 == b1 and b1 == c1 and a1 == "x" or a1 == "o":
            if b1 == "x":
                print("Congrats" + player1_name)
            elif b1 == "o":
                print("Congrats" + player2_name)
        elif a2 == b2 and b2 == c2 and a1 == "x" or a1 == "o":
            if a2 == "x":
                print("Congrats" + player1_name)
            elif a2 == "o":
                print("Congrats" + player2_name)
        elif a3 == b3 and b3 == c3 and a1 == "x" or a1 == "o":
            if a3 == "x":
                print("Congrats" + player1_name)
            elif a3 == "o":
                print("Congrats" + player2_name)
        elif a1 == b2 and b2 == c3 and a1 == "x" or a1 == "o":
            if a2 == "x":
                print("Congrats" + player1_name)
            elif a2 == "o":
                print("Congrats" + player2_name)
        elif a3 == b2 and b2 == c1 and a1 == "x" or a1 == "o":
            if a3 == "x":
                print("Congrats" + player1_name)
            elif a3 == "o":
                print("Congrats" + player2_name)
