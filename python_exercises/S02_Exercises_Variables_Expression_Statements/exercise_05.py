# STUDENT ID 20111218 | NAME: PUI LIM | DATE: 6th Aug 2023

"""Write a program which prompts the user for a Celsius temperature, convert the temperature to Fahrenheit, and print out the converted temperature."""

celcius = input("Enter Celcius: ")
celcius_int = int(celcius)
fahrenheit_conversion = celcius_int * 1.8 + 32
print(
    "Converted temperature from Celcius is",
    (fahrenheit_conversion),
    "degrees fahrenheit",
),
