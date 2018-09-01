#Code by John Allison, 10-09-2014
logon = False

while logon == False:

    username = input("Enter Username: ")
    password = input("Enter Password: ")

    if username == "John" and password == "python": #John's login
        logon = True
    elif username == "Lee" and password == "python": #Lee's login
        logon = True
    elif username == "Nathan" and password == "python": #Nathan's login
        logon = True
    else:
        print("Invalid Username or Password.")
        print()

print("Login Successful.")
