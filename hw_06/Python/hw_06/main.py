from clothes.Shirt import Shirt
from clothes.Color import Color
from clothes.Size import Size
from geometry.Earth import Earth
from geometry.Rectangle import Rectangle
from geometry.Cylinder import Cylinder
from geometry.Circle import Circle

s1 = Shirt()
s1.set_color(Color.Red)
s2 = Shirt(Color.White, Size.M, 159.00)
print(s1.info())
print(s2.info())
print("=======================================================")

e1 = Earth()
print(e1.earth_info())
print("========================================================")

r1 = Rectangle()
r1.set_width(6.0)
r1.set_heigth(5.0)
print(r1.info())
print("========================================================")

cy1 = Cylinder()
cy1.set_radius(5.0)
cy1.set_length(4.0)
print(cy1.cylinder_info())
print("========================================================")

cir1 = Circle()
cir1.set_radius(5.0)
print(cir1.circle_info())

print("========================================================")
