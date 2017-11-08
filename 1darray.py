# DECLARE ages : ARRAY[0...9] OF INTEGER
# ages = [12,21,35,65,42,1,5,24,14,12]

def output_array():
    for index in range(0,10):
        print (ages [index])

def bubble_sort():
    for passes in range(0, 9):
        for i in range(0, 9):
            if ages[i] > ages[i + 1]:
                temp = ages[i]
                ages[i] = ages[i + 1]
                ages[i + 1] = temp

def get_input():
    temp = int(input("enter age between 0-99"))
    while temp < 0 or temp > 99:
        print("idiot!, you didnt enter the number correctly.")
        temp = int(input("enter age correctly between 0-99"))
    return temp

#MAIN PROGRAM
ages = []
for index in range(0,10):
    ages.append(get_input)
output_array()
print()
bubble_sort()
output_array()