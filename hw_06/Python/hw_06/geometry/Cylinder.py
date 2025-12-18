import math

class Cylinder:
    def __init__(self, radius:float=1.0, height:float=1.0):
        self.__radius = radius
        self.__height = height

    def get_radius(self):
        return self.__radius
    
    def set_radius(self, radius:float): 
        self.__radius = radius

    def get_height(self):
        return self.__height
    
    def set_height(self, height:float):
        self.__height = height

    def area(self):
        return math.pi * pow(self.__radius, 2)
    
    def volume(self):
        return self.area() * self.__height
    
    def cylinder_info(self):
        return f"Cylinder: Radius = {self.__radius:.2f}, Lenght = {self.__height:.2f}, Area = {self.area():.2f}, Volume = {self.volume():.2f}"