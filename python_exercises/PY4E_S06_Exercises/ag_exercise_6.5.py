"""
6.5 Write code using find() and string slicing (see section 6.10) to extract the number at the end of the line below. Convert the extracted value to a floating point number and print it out.
"""

# STUDENT ID 20111218 | NAME: PUI LIM | DATE: 21st Sep 23

""" OPTION ONE - NO NUMBER USED """
text = "X-DSPAM-Confidence:    0.8475"

# FIND SPACE POSITION, WHICH IS
space_pos = text.find(str(" "))
print(space_pos)
print(space_pos + 4)
print(text[23])

# FIND LENGTH OF TEXT WHICH IS 29 = 29 POSITIONS
text_len = len(text)
# print(text_len)

# PRINT FROM POSITION 23 - 29, CONVERTED TO FLOAT
print(float(text[23:29]))

""" OPTION TWO - USING POSITION OF SPACE AND THE LAST STR WHICH IS '5"  """
# text = "X-DSPAM-Confidence:    0.8475"

# # FIND THE FIRST SPACE WHICH IS LOCATED AT POSITION 19
# space_pos = text.find(str(" "))
# # print(space_pos)

# # FIND THE POSITON NUMBER OF "5" AT THE END, WHICH IS AT 28
# end_pos = text.find("5")
# # print(end_pos)

# num_extract = text[space_pos : end_pos + 1]
# print(float(num_extract))
