def welcome():
    print("Welcome to Caesar cipher program")
    name = input("What is your name? ")
    print(name, "hope your enjoy encrypting and decrypting words. ")
    return name


def encrypt(letter, shift):
    if letter.isalpha():
        answer = chr(ord(letter) + shift)
    else:
        answer = letter
    return answer


answer = ""
