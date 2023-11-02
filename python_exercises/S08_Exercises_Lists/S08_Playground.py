class Animal:
    def speak(self):
        pass


class Dog(Animal):
    def speak(self):
        return "Woof!"


class Cat(Animal):
    def speak(self):
        return "Meow!"


# Function that demonstrates polymorphism
def make_sound(animal):
    return animal.speak()


# Creating objects
dog = Dog()
cat = Cat()

# Using polymorphism
print(make_sound(dog))  # Output: Woof!
print(make_sound(cat))  # Output: Meow!


# # option one
# for friend in friends:
#     print("Happy New Year:", friend)


# # option two
# for i in range(len(friends)):
#     friend = friends[i]
#     print("Happy New Year:", friend)

# friends.sort()
# print(friends)
# total = 0
# count = 0
# while True:
#     inp = input("Enter a number: ")
#     if inp == "done":
#         break
#     value = float(inp)
#     total = total + value
#     count = count + 1
# average = total / count
# print("average:", average)

# numlist = list() # create an empty list
# while True:
#     inp = input("Enter a number: ")
#     if inp == "done":
#         break
#     value = float(inp)
#     numlist.append(value) # add a value / append to the list until the loop breaks

# average = sum(numlist) / len(numlist)
# print("Average:", average)
# count = 0
# fhand = open("PY4E_S08_Exercises\mbox-short.txt")
# for line in fhand:
#     line = line.rstrip()
#     if not line.startswith("From "):
#         continue
#     words = line.split()
#     count = int(count + 1)
#     print(count, "-", words[1])

# line = "From stephen.marquard@uct.ac.za Sat Jan  5 09:14:16 2008"
# words = line.split()
# print(words)
# email = words[1]
# pieces = email.split("@")
# print(pieces)
# print(pieces[1])
