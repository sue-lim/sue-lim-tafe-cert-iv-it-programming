""" Example 1 """


# num = float(input("enter a number:"))
# cube = num**3
# print("The cube of ", num, "is: ", cube)

# num = float(input("enter a number: "))
# power = float(input("what power do you wish to raise your number by? "))
# result = num**power
# print("The result of raising ", num, "to the power of", power, "is: ", result)

# num_1 = float(input("enter a number: "))
# num_2 = float(input("enter another number: "))
# operator_select = input("enter the operator (+ - * / ** %): ")

# if operator_select == "+":
#     result = num_1 + num_2
# elif operator_select == "-":
#     result = num_1 - num_2
# elif operator_select == "*":
#     result = num_1 * num_2
# elif operator_select == "/":
#     result = num_1 / num_2
# elif operator_select == "**":
#     result = num_1**num_2
# elif operator_select == "%":
#     result = num_1 % num_2


# print(num_1, operator_select, num_2, "=", result)
def inputNum():
    while True:
        num = input("enter a number: ")
        try:
            num = float(num)
            break
        except:
            print("please enter a valid number: ")
            continue
    return num


num1 = inputNum()
num2 = inputNum()

operator_select = input("enter the operator (+ - * / ** %): ")
while True:
    if operator_select == "+":
        result = num1 + num2
        break
    elif operator_select == "-":
        result = num1 - num2
        break
    elif operator_select == "*":
        result = num1 * num2
        break
    elif operator_select == "/":
        result = num1 / num2
        break
    elif operator_select == "**":
        result = num1**num2
        break
    elif operator_select == "%":
        result = num1 % num2
        break
    else:
        operator_select = input("enter the operator (+ - * / ** %): ")

print(num1, operator_select, num2, "=", result)
