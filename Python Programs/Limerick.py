#Code by John Allison, 26-09-2014
print("Create your own limerick")

line_1 = input("Line One: ")
line_2 = input("Line Two: ")
line_3 = input("Line Three: ")
line_4 = input("Line Four: ")
line_5 = input("Line Five: ")

editloop = True

while editloop == True:
    edit = input("Do you want to edit a line? ")
    if edit == "y" or edit == "Y":
        what_line = input("What line do you wish to edit? ")
        print(line_1)
        print(line_2)
        print(line_3)
        print(line_4)
        print(line_5)
        if what_line == "1":
            line_1 = input("Line One: ") #Line input
        elif what_line == "2":
            line_2 = input("Line Two: ") #Line input
        elif what_line == "3":
            line_3 = input("Line Three: ") #Line input
        elif what_line == "4":
            line_4 = input("Line Four: ") #Line input
        elif what_line == "5":
            line_5 = input("Line Five: ") #Line input

    elif edit == "n" or edit == "N":
        editloop = False
        print(line_1)
        print(line_2)
        print(line_3)
        print(line_4)
        print(line_5)
        
        file = open("limerick.txt", "w") #Opens file
        
        file.write(line_1+"\n") #Writes file, breaks line
        file.write(line_2+"\n") #Writes file, breaks line
        file.write(line_3+"\n") #Writes file, breaks line
        file.write(line_4+"\n") #Writes file, breaks line
        file.write(line_5+"\n") #Writes file, breaks line
        file.close() #Closes file
