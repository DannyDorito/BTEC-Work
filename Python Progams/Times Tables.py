#Code by John Allison, 06-10-2014
restart = True

while restart == True:
    menu = True

    num = 0
    t_1 = 0
    t_2 = 0
    t_3 = 0
    t_4 = 0
    t_5 = 0
    t_6 = 0
    t_7 = 0
    t_8 = 0
    t_9 = 0
    t_10 = 0
    t_11 = 0
    t_12 = 0

    while menu == True: #Menu
        print("1. Choose a Times Table")
        print("2. Print All")
        print("3. Quit")
        choice = input("What do you want to do? : ")

        if choice == "1":
            num = int(input("Which times table? : "))
            t_1 = num * 1
            print("1 x",num,"=",t_1)
            t_2 = num * 2
            print("2 x",num,"=",t_2)
            t_3 = num * 3
            print("3 x",num,"=",t_3)
            t_4 = num * 4
            print("4 x",num,"=",t_4)
            t_5 = num * 5
            print("5 x",num,"=",t_5)
            t_6 = num * 6
            print("6 x",num,"=",t_6)
            t_7 = num * 7
            print("7 x",num,"=",t_7)
            t_8 = num * 8
            print("8 x",num,"=",t_8)
            t_9 = num * 9
            print("9 x",num,"=",t_9)
            t_10 = num * 10
            print("10 x",num,"=",t_10)
            t_11 = num * 11
            print("11 x",num,"=",t_11)
            t_12 = num * 12
            print("12 x",num,"=",t_12)
            menu = False
        elif choice == "2":
            while num != 12:
                num = num + 1
                t_1 = num * 1
                print("1 x",num,"=",t_1)
                t_2 = num * 2
                print("2 x",num,"=",t_2)
                t_3 = num * 3
                print("3 x",num,"=",t_3)
                t_4 = num * 4
                print("4 x",num,"=",t_4)
                t_5 = num * 5
                print("5 x",num,"=",t_5)
                t_6 = num * 6
                print("6 x",num,"=",t_6)
                t_7 = num * 7
                print("7 x",num,"=",t_7)
                t_8 = num * 8
                print("8 x",num,"=",t_8)
                t_9 = num * 9
                print("9 x",num,"=",t_9)
                t_10 = num * 10
                print("10 x",num,"=",t_10)
                t_11 = num * 11
                print("11 x",num,"=",t_11)
                t_12 = num * 12
                print("12 x",num,"=",t_12)
            else:
                menu = False

    #Restart input
    again = input("Would You Like To Restart? (Y/N):  ")
    if again == ("Y") or again == ("y"):
        restart = True
    else:
        restart = False