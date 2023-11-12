# static methods which you can use elsewhere


class Math:
    @staticmethod
    # they do something but they don't change anything
    def add5(x):
        return x + 5

    @staticmethod
    def add10(x):
        return x + 10

    @staticmethod
    def pr():
        print("run")


print(Math.add5(5))
print(Math.add10(10))
Math.pr()
