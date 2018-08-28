#Code by John Allison, 03-11-2014
def binary(denary): #Turns binary to denary
    binary = ""
    power = 128
    while power >= 1:
        if power < denary:
            denary -= power
            binary += "1"
        else:
            binary += "0"
        power /= 2

    return binary

def denary(binary): #Turns denary to binary
    denary = 0
    power = 128
    for digit in binary:
        if digit == "1":
            denary += power

            power /= 2
    return int(denary)

print(binary(43))
print(denary("11111111"))
