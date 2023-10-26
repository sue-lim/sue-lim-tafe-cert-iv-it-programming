"""Create a new repository in GitHub

Check out a local copy of that remote
Use GitHub Desktop, or use the Laragon Cmdr for CLI git

Create a simple Python password generator
Generates and prints a string of 10 random characters
Use the random module
Keep it simple at this stage

Commit to your repository and push to GitHub"""

# Import the random module, which allows us to generate random values.
import random
import string

# Import constants from the string module for letters, digits, and special characters.
letters = string.ascii_letters  # Uppercase and lowercase letters
digits = string.digits  # Numeric digits (0-9)
special_char = string.punctuation  # Special characters like !@#$%^&*()

# Concatenate the above string constants to create a character set.
alphabet = letters + digits + special_char

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
