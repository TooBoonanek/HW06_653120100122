import math

class Circle:
    def __init__(self, radius:float=1.0):
        self.__radius = radius

    def get_radius(self):
        return self.__radius
    
    def set_radius(self, radius:float):
        self.__radius = radius

    def area(self):
        return math.pi * pow(self.__radius, 2)
    
    def diameter(self):
        return 2 * self.__radius
    
    def circumference(self):
        return 2 * math.pi * self.__radius
    
    def circle_info(self):
        return f"Circle: Radius = {self.__radius}, Area = {self.area():.2f}, Diameter = {self.diameter():.2f}, Circumference = {self.circumference():.2f}"