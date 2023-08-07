a = 4
b = 1.25
c = "hello"
print(a)
print(b)
print(a/b)
'''
print("a =", a)
print("b =", b)
print("a * b =", a*b)
'''
print("a / b =", a/b)
# print("a + b =", a+b)
# print("a - b =", a-b)
print("ndvlfn\" df \"")
print(type(a))
print(type(b))
print(type(c))
print(a, b, c)
print(f"{a} - a, {b} - b, {c} - c")
print("a: {}, b: {}, c: {}".format(a, b, c))

print("Input first number")
d = float(input())
e = float(input("Input second number: "))
print("Your numbers are:", d, e)
print(f"d * e = {d * e}")
print(f"d * e = {round(d * e, 3)}")
print(f"d -", type(d), "e -", type(e))
print(d/e)
print(d//e)
print(d % e)
print(d**e)

a = 1 > 6
print(a)
a = 1 < 4 and 4 > 2
print(a)
print(1 == 2)
a = 'sfsg'
b = 'sfs4g'
print(a == b)
print(3 < 4 < 4 < 6)

a = int(input())
b = int(input())
if a > b:
    print(f"{a}")
elif a < b:
    print(f"{b}")
else:
    print("{}, {}".format(a, b))

n = 432983749762905
sum = 0
while n > 0:
    x = n % 10
    sum += x
    n = n//10
print(sum)

m = int(input())
flag = True
while flag:
    if m % 2 == 0:
        flag = False
        print(m)
    else:
        m //= 2
        print("hmmm")

a = "qwerty"
for i in range(len(a)-1, -1, -1):
    print(a[i])

for i in range(5):
    line = ""
    for j in range(5):
        line += "*"
    print(line)

text = "Hello, world, my name is Yaroslav!"
print(len(text))
print("hello" in text)
print(text.lower())
print(text.upper())
print(text.replace("Hello", "good day"))
print(text[1:-29])
