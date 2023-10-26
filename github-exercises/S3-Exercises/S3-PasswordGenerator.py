# Import the random module, which allows us to generate random values.
import random
import string

# creating alphabet variable utlilist string import
alphabet = string.ascii_letters

# Define the desired password length.
password_length = 10

# Create an empty string to store the generated password.
password = ""

# Loop through the  password length and append random characters to the password string.
for i in range(password_length):
    password += random.choice(alphabet)

# Print the randomly generated password.
print("Here is the randomly generated password:", password)

# ref: https://geekflare.com/password-generator-python-code/
