def quick_sort(arr):
    if len(arr) <= 1:
        return arr
    else:
        pivot = arr[0]

        left = [x for x in arr[1:] if x < pivot]
        right = [x for x in arr[1:] if x >= pivot]

        return quick_sort(left) + [pivot] + quick_sort(right)


arr = [6, 5, 3, 8, 5, 7, 9, 5, 4, 6, 3]

print(arr)
print()
print(quick_sort(arr))
