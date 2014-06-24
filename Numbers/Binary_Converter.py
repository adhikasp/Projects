def binToDec(number):
    number = str(number)
    result = 0
    for n in range(1, len(number)+1):
        if number[-n] == "1":
            result += 2**(n-1)
    return result

def decToBin(number):
    result = ""
    while number > 1:
        if (number % 2 == 0):
            temp = "0"
        else:
            temp = "1"
        result = temp + result
        number = int(number/2)
    result = str(number) + result
    return result

print(decToBin(100))
print(binToDec(1100100))

assert decToBin(100) == binToDec(1100100), "Kerusakan decToBin() & binToDec()"
