# Code by John Allison, 10-09-2014
name = input("Please enter your name : ")
age = input("Please enter your age : ")
print("Welcome", name, "to this program.")
print("You just told me that you are", age, "years old.")
actual_age = int(age)

if actual_age < 0: #Input is < 0
    print("You are unborn.")
if actual_age >= 0 and actual_age <= 19: #Input is >= 0 and <= 19
    print("You are young.")
if actual_age >= 20 and actual_age <= 59: #Input is >= 20 and <= 59
    print("You are middle aged.")
if actual_age >= 60 and actual_age <= 120: #Input is >= 60 and <= 120
    print("You are old.")
if actual_age >= 121: #Input is >= 121
    print("You should be dead.")
