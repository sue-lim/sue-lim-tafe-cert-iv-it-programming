""" 8.4 Open the file romeo.txt and read it line by line. 
For each line, split the line into a list of words using the split() method. 
The program should build a list of words. For each word on each line check to see if the word is already in the list and if not append it to the list. 
When the program completes, sort and print the resulting words in python sort() order as shown in the desired output. """


file_name = input("Enter file name: ")
file_handle = open(file_name)

# file_handle = open("romeo.txt")

# reading the file
lines = file_handle.read()

# replacing end of line('/n') with ' ' and
# splitting the text it further when '.' is seen.
updated_lines = lines.replace("\n", " ").split(".")
# print(updated_lines)

# split each word into an item in a list
for words in updated_lines:
    words = words.split()
    formatted_list = []

    for word in words:
        if word not in formatted_list:
            formatted_list.append(word)

    # https://www.w3schools.com/python/python_howto_remove_duplicates.asp
    formatted_list = list(set(formatted_list))

    # https://www.w3schools.com/python/ref_list_sort.asp
    formatted_list.sort()

    print(formatted_list)
