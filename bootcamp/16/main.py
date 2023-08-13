import cv2

img = cv2.imread('test.jpeg')
print(img.shape)
img2 = cv2.resize(img, (500,500))
print(img2.shape)

cv2.imshow('Result', img2)
cv2.waitKey(0)