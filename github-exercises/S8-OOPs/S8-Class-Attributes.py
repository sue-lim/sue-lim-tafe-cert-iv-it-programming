# Class Attributes


class Person:
    number_of_people = 0

    def __init__(self, name):
        self.name = name
        Person.number_of_people += 1


p1 = Person("Tim")
# print(p1.name)
print(Person.number_of_people)
p2 = Person("Jill")
print(Person.number_of_people)
