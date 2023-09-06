list_1 = []
list_2 = list()
list_3 = [1, 5]
list_4 = [1, 2, 3, 4, 5, 6, 7]

print(list_1)
print(list_2)
print(list_3)
print(*list_3)
print(list_4[3])
print(list_4[-2])
print(*list_4)
list_4.append(8)
print(*list_4)
list_4.append(8)

for i in list_4:
    print(i)

for i in range(14):
    list_1.append(i)

print(list_1)

list_1.insert(2, 13)
print(list_1)
list_1.pop(2)
print(list_1)
print(len(list_1)-2)
print(list_1[len(list_1)-2])
print(list_1[1:len(list_1)-2:3])


t = ()
print(type(t))

t = (1)
print(type(t))

t = (1,)
print(type(t))

v = [1, 2, 3, 4, 5, 6, 7, 8, 9]
print(v)
print(type(v))

v = tuple(v)
print(v)
print(type(v))

a, b, c, d, e, f, g, h, i = v
print(a, b, c, d, e, f, g, h, i)

for i in v:
    print(i)

d = {}
d_1 = dict()

d['q'] = 'qwerty'
print(d)
d['w'] = 'werty'
print(d)

print(d['w'])

d['e'] = 'erty'
print(d)

del d['q']
print(d)

for i in d:
    print(i)

for i, j in d.items():
    print(i, j)

for i in d:
    print('{}: {}'.format(i, d[i]))

print(d.items())

colors = {'red', 'green', 'blue'}
print(colors)

colors.add('red')
print(colors)

colors.add('grey')
print(colors)

colors.remove('blue')
print(colors)
# colors.remove('blue')
colors.discard('blue')

colors.clear()
print(colors)

a = {1, 2, 3, 4, 5, 6, 7}
b = {5, 6, 7, 8, 9, 10}
c = a.copy()
print(a,b,c)

u = a.union(b)
print(u)

i = a.intersection(b)
print(i)

df_1 = a.difference(b)
print(df_1)

df_2 = b.difference(a)
print(df_2)

v = frozenset(a)
print(v)

new_list = []
for i in range(2,100,2):
    new_list.append(i)
print(new_list)

new_list_1= [i for i in range(1,100) if i%2==0]
print(new_list_1)

new_list_2= [(i, i) for i in range(1,100) if i%2==0]
print(new_list_2)

new_list_3= [(i, i**2) for i in range(1,100) if i%2==0]
print(new_list_3)
