# STUDENT ID 20111218 | NAME: PUI LIM | DATE: 10th AUG 2023


# def name "computepay" & parameters "hours" & "rate"
def computepay(hours, rate):
    if hours > 40:
        pay = (40 * rate) + (hours - 40) * (rate * 1.5)
    else:
        pay = hours * rate
    return pay


hrs = float(input("Enter Hours: "))
rate = float(input("Enter Rate: "))
# h = float(hrs)
# r = float(rate)

# arguments
p = computepay(hrs, rate)

print("Pay", p)
