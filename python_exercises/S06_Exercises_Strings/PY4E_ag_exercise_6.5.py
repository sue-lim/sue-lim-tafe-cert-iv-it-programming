"""
6.5 Write code using find() and string slicing (see section 6.10) to extract the number at the end of the line below. Convert the extracted value to a floating point number and print it out.
"""

# STUDENT ID 20111218 | NAME: PUI LIM | DATE: 21st Sep 23

text = "X-DSPAM-Confidence:    0.8475"

# FIND THE POSITION OF THE FIRST SPACE CHARACTER
space_position = text.find(str(" "))
# print(space_position)

# CALCULATES THE END POSITION BASED ON THE LENGHT OF THE TEXT
end_position = len(text)

confidence = text[space_position + 1 :]
# space_pos + 1: is the position of the space character, adding 1 to it moves the starting point one character to the right, effectively skipping the space character.

print(float(confidence))
