import sys

e = "abc123456"

d = 6.6

saved = sys.getsizeof(e)
saved1 = sys.getsizeof(d)

print(saved, "Bytes")
print(saved1, "Bytes")

on = sys.float_info

print(on)
