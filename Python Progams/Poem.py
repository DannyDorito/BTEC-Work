#Code by John Allison, 29-09-2014
poem = [] #Empty string

poem_loop = True
while poem_loop == True:
    poem_line = input("Enter line of poem: ")
    if poem_line == "END": #Ends line
        poem_loop = False
    else:
        poem.append(poem_line) #Adds to list

counter = 0 #Defines counter
for line in poem:
    print(counter, line)
    counter = counter +1 #Adds one to counter

edit = input("Do you want to edit a line? ")
if edit == "Yes" or edit == "yes":
    which = int(input("Which line do you want to edit? : "))
    poem[which] = input("Enter a line: ")

for line in poem:
    file = open("poem.txt", "w") #Opens file
    for line in poem:
        file.write(line+"\n")
    file.close() #Closes file
