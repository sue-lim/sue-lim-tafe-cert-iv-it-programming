"""7.2 Write a program that prompts for a file name, then opens that file and reads through the file, looking for lines of the form:

X-DSPAM-Confidence:    0.8475

Count these lines and extract the floating point values from each of the lines and compute the average of those values and produce an output as shown below. Do not use the sum() function or a variable named sum in your solution.
You can download the sample data at http://www.py4e.com/code3/mbox-short.txt when you are testing below enter mbox-short.txt as the file name.
"""

file_name = input("Enter the file name: ")
file_handle = open(file_name)

total = 0
count = 0

for line in file_handle:
    updated_line = line.rstrip()
    if updated_line.startswith("X-DSPAM-Confidence:"):
        count += 1
        post_confidence_number = float(updated_line[19:])
        total += post_confidence_number

if count > 0:
    mean = total / count
    print("Average spam confidence:", mean)
else:
    print("No 'X-DSPAM-Confidence:' lines found in the file.")

file_handle.close()

# no use of if statement
# count > 0
# mean = total / count
# print(mean)
