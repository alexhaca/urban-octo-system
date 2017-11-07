# DECLARE ages : ARRAY[0...9] OF INTEGER
# ages = [12,21,35,65,42,1,5,24,14,12]
ages = []
for index in range(0,10):
temp = int(input("enter age between 0-99"))
while temp < 0 or temp > 99:
    print("idiot!, you didnt enter the number correctly.")
    temp = int(input("enter age corrctly between 0-99"))
    ages.append(temp)
for index in range(0,10):
    print (ages [index])

for passes in range(0,9):
    for i in range(0, 9):
        if ages [i] > ages[i+1]:
            temp = ages[i]
            ages[i] = ages [i+1]
            ages[i+1] = temp

for index in range(0,10):
    print (ages [index])