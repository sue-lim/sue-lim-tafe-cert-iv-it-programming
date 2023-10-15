# (x, y) = (14, "fred")
# a = (x, y)
# print(a)
# d = dict()
# d["csev"] = 2
# d["cwen"] = 4
# # print(d)
# for k, v in d.items():
#     print(k, v)

# days = ("Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun")

# print(days[2])
# x = "hello"
# x = x + "world"
# print(x)
# start A:
# a = 30
# b = "12"
# print(int(a) > b)


def fizzBuzz(n):
    for i in range(1, n + 1):
        if i % 3 == 0 and i % 5 == 0:
            print("FizzBuzz")
        elif i % 3 == 0:
            print("Fizz")
        elif i % 5 == 0:
            print("Buzz")
        else:
            print(i)


if __name__ == "__main__":
    n = int(input(""))
    fizzBuzz(n)
