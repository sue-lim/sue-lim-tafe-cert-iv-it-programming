# multiple classes


class Student:
    def __init__(self, name, age, grade):
        self.name = name
        self.age = age
        self.grade = grade

    def get_grade(self):
        return self.grade

    def get_student(self):
        return self.name


class Course:
    def __init__(self, name, max_students):
        self.name = name
        self.max_students = max_students
        self.students = []

    def add_student(self, student):
        if len(self.students) < self.max_students:
            self.students.append(student)
            return True
        return False

    def get_average_grade(self):
        value = 0
        for student in self.students:
            value += student.get_grade()
        return value / len(self.students)


student1 = Student("Tim", 19, 75)
print(student1.get_student())
student2 = Student("Bill", 19, 75)
student3 = Student("Jill", 19, 65)

course1 = Course("Science", 2)
course1.add_student(student1)
course1.add_student(student2)
print(course1.add_student(student3))
print(course1.get_average_grade())
