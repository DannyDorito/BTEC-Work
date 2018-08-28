#Code by John Allison, 22-09-2014
restart = True

while restart == True:
    Fizz = 0 #Defaults to this
    Buzz = 0 

    Fizz = int(input("What number do you want to use for Fizz? : ")) #Pick Fizz value
    print()
    Buzz = int(input("What number do you want to use for Buzz? : ")) #Pick Buzz value
    print()
    for num in range(1, 101):
        if num %Fizz == 0 and num %Buzz == 0: #Percent gives a remainder value
            print("Fizz Buzz", num) #If remainder is equal to 0
        elif num %Buzz == 0:
            print("Buzz", num)
        elif num %Fizz == 0:
            print("Fizz", num)
        else:
            print(num)

        restart = False

    #Restart input
    again = input("Would You Like To Restart? (Y/N):  ")
    if again == ("Y") or again == ("y"):
        restart = True
    else:
        restart = False
