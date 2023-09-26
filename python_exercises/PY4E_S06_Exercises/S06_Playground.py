# str1 = "Hello"
# str2 = " there"
# print(str1 + str2)

# str3 = "123"
# x = int(str3) + 1
# print(x)

# fruit = "banana"
# letter = fruit[1]
# print(letter)

# x = 3
# w = fruit[x - 1]
# print(fruit[3])
# print(w)

# fruit = "banana"
# index = 0
# while index < len(fruit):
#     letter = fruit[index]
#     print(index, letter)
#     index = index + 1


# fruit = "banana"
# for letter in fruit:
#     print(letter)

# word = "banana"
# count = 0
# for letter in word:
#     if letter == "a":
#         count = count + 1
# print(count)

# for letter in "banana":
#     print(letter)

# s = "Monty Python"
# print(s)
# print(s[0:4])
# print(s[6])
# print(s[6:20])

# word = "banana"
# if word == "banana":
#     print("All right, bananas.")

# if word < "banana":
#     print("Your word," + word + ", comes before banana.")
# elif word > "banana":
#     print("Your word," + word + ", comes after banana.")
# else:
#     print("All right, bananas.")

# print("Geek" == "Geek")
# print("Geek" < "geek")
# print("Geek" > "geek")
# print("Geek" != "Geek")

# greet = "Hello Bob"
# zap = greet.upper()
# print(zap)

# # data variable
# data = "From stephen.marquard@uct.ac.za Sat Jan  5 09:14:16 2008"
# # atpos - variable name to find "@"
# atpos = data.find("@")
# # print the position number
# print(atpos)

# # sppos - variable name for space position
# sppos = data.find(" ", atpos)
# print(sppos)

# # since we are looking for the email host
# # variable name is "host"
# # print from atposition + 1 till space position
# host = data[atpos + 1 : sppos]
# print(host)


# str1 = "Hello"
# str2 = "there"
# bob = str1 + str2
# print(bob)

# x = "40"
# y = int(x) + 2
# print(y)
# x = "From marquard@uct.ac.za"
# print(x[14:17])
data = "From stephen.marquard@uct.ac.za Sat Jan  5 09:14:16 2008"
pos = data.find(".")
print(data[pos : pos + 3])
