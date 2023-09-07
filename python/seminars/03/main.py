# # a = [1, 1, 2, 0, -1, 3, 4, 4]
# # print(a)
# # b = set(a)
# # print(b)
# # print(len(b))

# # count = 0
# # for i in range(len(a)):
# #     if a[i] not in a[:i]:
# #         count += 1
# # print(count)

# arr = [1, 2, 3, 4, 5]
# #     [4, 5, 1, 2, 3]

# print(f'arr = {arr}')
# k = 36
# barr = []
# if k > len(arr):
#     k = k % len(arr)

# for i in range(len(arr)):
#     barr.append(arr[i-k])
# print(f'new arr 1 = {barr}')

# for i in range(k):
#     temp = arr.pop(-1)
#     arr.insert(0, temp)

# print(f'new arr 2 = {arr}')

# #  Напишите программу для печати всех уникальных значений в словаре.

# # Input: [{"V": "S001"}, {"V": "S002"}, {"VI": "S001"}, {"VI": "S005"}, {"VII": "S005"}, {"V":"S009"}, {"VIII":"S007"}]

# # Output: {'S005', 'S002', 'S007', 'S001', 'S009'}


# dic = [{"V": "S001"}, {"V": "S002"}, {"VI": "S001"}, {
#     "VI": "S005"}, {"VII": "S005"}, {"V": "S009"}, {"VIII": "S007"}]
# my_list = []
# for i in range(len(dic)):
#     for val in dic[i].values():
#         if val not in my_list:
#             my_list.append(val)
# print(my_list)

# # Дан массив, состоящий из целых чисел. Напишите программу, которая подсчитает количество элементов массива,
# # больших предыдущего (элемента с предыдущим номером)


# # Input: [0, -1, 5, 2, 3]


# # Output: 2

# # Пояснение: (-1 < 5, 2 < 3)

# llist = [0, -1, 5, 2, 3, 6, 4, 2, 5]

# count = 0
# for i in range(1, len(llist)):
#     if llist[i] > llist[i-1]:
#         count += 1
# print(count)
k = 'ноутбук'
dic = {
    'а' : 1,
    'б' : 3,
    'в' : 1,
    'г' : 3,
    'д' : 2,
    'е' : 1,
    'ё' : 3,
    'ж' : 5,
    'з' : 5,
    'и' : 1,
    'й' : 4,
    'к' : 2,
    'л' : 2,
    'м' : 2,
    'н' : 1,
    'о' : 1,
    'п' : 2,
    'р' : 1,
    'с' : 1,
    'т' : 1,
    'у' : 2,
    'ф' : 10,
    'х' : 5,
    'ц' : 5,
    'ч' : 5,
    'ш' : 8,
    'щ' : 10,
    'ъ' : 10,
    'ы' : 4,
    'ь' : 3,
    'э' : 8,
    'ю' : 8,
    'я' : 3,
}

sum = 0
for i in k:
    # let = dic[i]
    # print(let)
    sum += dic[i]
print(sum)
