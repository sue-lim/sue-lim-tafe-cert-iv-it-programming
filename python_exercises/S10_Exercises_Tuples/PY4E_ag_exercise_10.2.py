""" 10.2 Write a program to read through the mbox-short.txt and figure out the distribution by hour of the day for each of the messages. 
You can pull the hour out from the 'From ' line by finding the time and then splitting the string a second time using a colon.
From stephen.marquard@uct.ac.za Sat Jan  5 09:14:16 2008
Once you have accumulated the counts for each hour, print out the counts, sorted by hour as shown below."""

# STUDENT ID 20111218 | NAME: PUI LIM | DATE: 30/9/2023

# file_name = input("Enter File: ")
# file_handle = open(file_name)

file_handle = open("mbox-short.txt")

hour_counts = {}

for line in file_handle:
    line = line.rstrip()
    if line.startswith("From "):
        split_line = line.split()  # seperate the words on the line
        timestamp = split_line[5]  # retrieve timestamp
        hour_minute_second_split = timestamp.split(":")  # h:m:s split
        hours = hour_minute_second_split[0]
        # print(hours)
        hours = [hours]
        for item in hours:
            hour_counts[item] = hour_counts.get(item, 0) + 1

# Create a list to store tuples of (hour, count) & sort
hour_count_list = list()
for key_hour, value_count in hour_counts.items():
    hour_count_list.append((key_hour, value_count))
    hour_count_list.sort()

for (
    key_hour,
    value_count,
) in hour_count_list:  # Loop through  sorted list of tuples & print the results
    print(key_hour, value_count)

file_handle.close()
