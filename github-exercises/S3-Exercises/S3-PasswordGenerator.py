# Import the random module, which allows us to generate random values.
import random
import string

# Import constants from the string module for letters
# alphabet = string.ascii_letters
alphabetLower = string.ascii_lowercase
alphabetUpper = string.ascii_uppercase
digits = string.digits
specialChar = string.punctuation

# While loop to Validate the input: 0 < length < 50

while True:
    print("Enter Password Length:")
    passwordLen = input()
    try:
        passwordLen = int(passwordLen)
        print("Please advise if you want the following in your password: ")
        includeUpperCase = input("a) Upper Case? (y/n): ").lower()
        includeLowerCase = input("b) Lower Case?: (y/n): ").lower()
        includeDigits = input("c) Digits? (y/n):").lower()
        includeSpecialChar = input("d) Special Characters? (y/n):").lower()
    except:
        print("Please use numeric digits.")
        continue
    if passwordLen <= 0:
        print("Invalid")
        continue
    if passwordLen >= 50:
        print("Invalid")
        continue

    # Create an empty string to store the character_set.
    # if yes we add  either Upper / Lower / digits / special characters to the character set
    character_set = ""
    if includeUpperCase == "y":
        character_set += alphabetUpper
    if includeLowerCase == "y":
        character_set += alphabetLower
    if includeDigits == "y":
        character_set += digits
    if includeSpecialChar == "y":
        character_set += specialChar

    # if not loop ends
    if not character_set:
        print(
            "Invalid, please ensure you include a selection with a) Upper Case, b) Lower Case c) Digits d) Special Characters. "
        )

        continue
    # Create an empty string to store the generated password.
    else:
        password = ""

        # Loop through the  password length and append random characters to the password string.
        for i in range(passwordLen):
            password += random.choice(character_set)

        # Print the randomly generated password.
        # Generate and print a string of {length} random characters
        print(f"Your password is {password}.")

    break

# ref: https://geekflare.com/password-generator-python-code/
# try / except / continue - https://automatetheboringstuff.com/2e/chapter8/
# replay enclose in a while loop with continue and break - https://maschituts.com/2-ways-to-loop-back-to-the-beginning-of-a-program-in-python/
