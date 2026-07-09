from turtle import *

speed(0)

bgcolor("black")

# Create the orange planet
color("orange")
begin_fill()
circle(60)
end_fill()

# Move forward
penup()
forward(100)
pendown()

# Create the gray planet
color("gray")
begin_fill()
circle(20)
end_fill()

penup()
forward(80)
pendown()

# Create the red planet
color("red")
begin_fill()
circle(40)
end_fill()

penup()
forward(90)
pendown()

# Create the green planet
color("green")
begin_fill()
circle(30)
end_fill()

done()