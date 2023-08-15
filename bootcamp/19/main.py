from turtle import *
from random import randint
from time import *


def bounding():
    t = Turtle()
    t.speed(0)
    for i in range(1,21):
        t.penup()
        t.goto(-200+i*20, 50)
        t.pendown()
        t.goto(-200+i*20, -100)
    t.hideturtle()

x_finish = 200

t1 = Turtle()
t1.shape('turtle')
t1.color('red')
t1.penup()
t1.goto(-200, 20)
t1.pendown()
t1.speed(2)

t2 = Turtle()
t2.shape('turtle')
t2.color('blue')
t2.penup()
t2.goto(-200, -20)
t2.pendown()
t2.speed(2)

bounding()

while t1.xcor() < x_finish and t2.xcor() < x_finish:
    t1.fd(randint(3,6))
    t2.fd(randint(3,6))
    exitonclick()
