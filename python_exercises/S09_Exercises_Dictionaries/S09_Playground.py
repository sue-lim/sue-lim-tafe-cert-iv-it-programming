from collections import defaultdict

# purse = dict()
# purse["money"] = 12
# purse["candy"] = 3
# purse["tissues"] = 75
# print(purse)

# print(purse["candy"])
# purse["candy"] = purse["candy"] + 2
# print(purse)

# counts = dict()
# names = ["csev", "cwen", "csev", "zquian", "cwen"]
# for name in names:
#     if name not in counts:
#         counts[name] = 1
#     else:
#         counts[name] = counts[name] + 1
# print(counts)

# counts = dict()
# names = ["csev", "cwen", "csev", "zqian", "cwen"]
# for name in names:
#     counts[name] = counts.get(name, 0) + 1
# print(counts)

# counts = defaultdict(int)
# names = ["csev", "cwen", "csev", "zqian", "cwen"]
# for name in names:
#     counts[name] += 1

# print(counts)

# counts = defaultdict(int)
# counts = dict()
# print("Enter a line of text: ")
# line = input("")
# words = line.split()
# print("Words: ", words)
# print("Counting...")
# for word in words:
#     # counts[word] += 1
#     counts[word] = counts.get(word, 0) + 1
# print("Counts", counts)

# jjj = {"chuck": 1, "fred": 42, "jan": 100}
# print(jjj)
# print(list(jjj))
# print(list(jjj.keys()))
# print(list(jjj.values()))
# print(list(jjj.items()))

# jjj = {"chuck": 1, "fred": 42, "jan": 100}
# for aaa, bbb in jjj.items():
#     print(aaa, bbb)

# name = input("Enter file:")
# handle = open(name)

# counts = dict()
# for line in handle:
#     words = line.split()
#     for word in words:
#         counts[word] = counts.get(word, 0) + 1

# bigcount = None
# bigword = None
# for word, count in counts.items():
#     if bigcount is None or count > bigcount:
#         bigword = word
#         bigcount = count

# print(bigword, bigcount)
# stuff = dict()
# print(stuff["candy"])

stuff = dict()
print(stuff.get("candy", -1))
