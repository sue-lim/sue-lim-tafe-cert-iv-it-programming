# Import the random module, which allows us to generate random values.
import random
import string

# Import constants from the string module for letters
alphabet = string.ascii_letters

# While loop to Validate the input: 0 < length < 50

while True:
    print("Enter Password Length:")
    passwordLen = input()
    try:
        passwordLen = int(passwordLen)
    except:
        print("Please use numeric digits.")
        continue
    if passwordLen <= 0:
        print("Invalid")
        continue
    if passwordLen >= 50:
        print("Invalid")
        continue
    break

# Create an empty string to store the generated password.
password = ""

# Loop through the  password length and append random characters to the password string.
for i in range(passwordLen):
    password += random.choice(alphabet)

# Print the randomly generated password.
# Generate and print a string of {length} random characters
print(f"Your password is {password}.")


# ref: https://geekflare.com/password-generator-python-code/
# try / except / continue - https://automatetheboringstuff.com/2e/chapter8/
