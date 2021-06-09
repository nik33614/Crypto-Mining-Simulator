print("hello")
string = input()
course = int(input())
string = string.split(",")
for i in range(len(string)):
    string[i] = string[i].strip()
result = [float(i) for i in string]
b = sum(result)
c = 86400*b*course
print(c)
