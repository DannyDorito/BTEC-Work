#Code by John Allison, 19-09-2014
import random

file = open("classlist.txt", "r") #Opens file
classlist = file.readline() #Converts to a variable
file.close() #Closes file

print(classlist)

random.shuffle(classlist) #Shuffles

number = int(input("How many names do you need: "))

for num in range(number):
    print(classlist[num]) #Prints given number
