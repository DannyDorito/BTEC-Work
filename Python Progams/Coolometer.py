#Code by John Allison, 24-09-2014
cool_list = ["George", "John", "Lee", "George"] #Defines cool_list
uncool_list = ["Nick", "Jason", "Trent"] #Defines uncool_list
def coolometer(name):
    if name in cool_list:
        result = "Cool"
    elif name in uncool_list:
        result = "Super uncool m80" #Rekt
    else:
        result = "Uncool"

    return result

print(coolometer("Lee"))
print(coolometer("Ian Iguana"))
print(coolometer("Jason"))

