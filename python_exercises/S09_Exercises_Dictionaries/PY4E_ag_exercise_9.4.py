"""
9.4 Write a program to read through the mbox-short.txt and figure out who has sent the greatest number of mail messages. 
The program looks for 'From ' lines and takes the second word of those lines as the person who sent the mail. 
The program creates a Python dictionary that maps the sender's mail address to a count of the number of times they appear in the file. 
After the dictionary is produced, the program reads through the dictionary using a maximum loop to find the most prolific committer.
DESIRED OUTPUT: 
cwen@iupui.edu 5
"""
# STUDENT ID 20111218 | NAME: PUI LIM | DATE: 30/9/2023
file_name = input("Enter File: ")
file_handle = open(file_name)

dictionary = {}
email_count = None
most_common_email = None

for line in file_handle:
    line = line.rstrip()
    if line.startswith("From "):
        words = line.split()  # splits into seperate words
        email = words[1]  # creating a variable to store index value at position 1

        email_list = [email]  # creating a list
        for item in email_list:
            dictionary[item] = dictionary.get(item, 0) + 1
            # adding the values in the list to dictionary

            # Loop through the dictionary of word counts
            # for email, count in dictionary.items():
            # Check if this word has a higher count than the current highest count
            if email_count is None or dictionary[item] > email_count:
                # If yes, update the most frequent word and its count
                most_common_email = email
                email_count = dictionary[item]

# Print the most frequent word and its count
print(most_common_email, email_count)
file_handle.close()

"""ref: https://stackoverflow.com/questions/30208044/how-to-add-list-elements-into-dictionary"""


# most_common_count = None
# most_common_email = None

# # Loop through the dictionary of word counts
# for email, count in dictionary.items():
#     # Check if this word has a higher count than the current highest count
#     if most_common_count is None or count > most_common_count:
#         # If yes, update the most frequent word and its count
#         most_common_email = email
#         most_common_count = count

# # Print the most frequent word and its count
# print(most_common_email, most_common_count)

# ref: https://stackoverflow.com/questions/30208044/how-to-add-list-elements-into-dictionary
