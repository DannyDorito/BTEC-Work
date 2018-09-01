#Code by John Allison, 19-09-2014
import random

restart = True

while restart == True:
    classlist = ["Lee", "John", "Nathan", "Charlie", "James", "Matty", "Joe", "Jack", 
	"Nuno", "Andy", "George", "Nick", "Bill", "Ben", "Jon", "Jim", "Gabe", "Rick", 
	"Dick", "Connor", "Glen", "Mario", "Luigi", "Kenny", "Hodor"]

    classlist1 = []
    print("Person One:", (f.readline(1)) #Prints the list
    print()
    print("Person Two:", (f.readline(2)) #Prints the list
    print()
    print("Person Three", (f.readline(3)) #Prints the list
    print()

    restart = False

    #Restart input
    again = input("Would You Like To Restart? (Y/N):  ")
    if again == ("Y") or again == ("y"):
        restart = True
    else:
        restart = False
