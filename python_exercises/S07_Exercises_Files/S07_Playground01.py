# # reading a file
# fhand = open("PY4E_S07_Exercises\mbox.txt", "r")
# print(fhand)

# # new line
# stuff = "Hello\nWorld!"
# print(stuff)

# mbox_file = open("PY4E_S07_Exercises\mbox.txt")
# count_index = 0
# for line in mbox_file:
#     count_index = count_index + 1
# print("Line count:", count_index)

# mbox_file = open("PY4E_S07_Exercises\mbox.txt")
# inp = mbox_file.read()
# print(len(inp))

# # print first 20 characters
# print(inp[:20])

mbox_file = open("PY4E_S07_Exercises\mbox.txt")
for line in mbox_file:
    line = line.rstrip()
    # if no uct.ca.za in the line then skip it otherwise it will print all lines with uct.ac.za
    if not "uct.ac.za" in line:
        continue
    print(line)

# file_name = input("Enter the file name: ")
# try:
#     file_handle = open(file_name)
# except:
#     print("File cannot be opened: ", file_name)

# count = 0
# for line in file_handle:
#     if line.startswith("Subject:"):
#         count = count + 1
# print("There were", count, "subject line in", file_name)
while True:
    file_name = input("Enter the file name: ")
    try:
        file_handle = open(file_name)
        break  # Exit the loop if the file is successfully opened
    except:
        print("File cannot be opened:", file_name)

count = 0
for line in file_handle:
    if line.startswith("Subject:"):
        count = count + 1
print("There were", count, "subject lines in", file_name)
