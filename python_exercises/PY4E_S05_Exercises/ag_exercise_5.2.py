# STUDENT ID 20111218 | NAME: PUI LIM | DATE: 17th Sep 2023

""" 5.2 Write a program that repeatedly prompts a user for integer numbers until the user enters 'done'. Once 'done' is entered, print out the largest and smallest of the numbers. If the user enters anything other than a valid number catch it with a try/except and put out an appropriate message and ignore the number. 
Enter 7, 2, bob, 10, and 4 and match the output below. """

smallest = None
largest = None

while True:
    value = input("Enter a number: ")
    if value == "done":
        break
    try:
        int_value = int(value)
    except:
        print("Invalid input")
        continue

    if smallest is None or int_value < smallest:
        smallest = int_value

    if largest is None or int_value > largest:
        largest = int_value

print("Maximum is", largest)
print("Minimum is", smallest)
