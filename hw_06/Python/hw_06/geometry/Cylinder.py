import math

class Cylinder:
    def __init__(self, radius:float=1.0, length:float=1.0):
        self.__radius = radius
        self.__length = length

    def get_radius(self):
        return self.__radius
    
    def set_radius(self, radius:float): 
        self.__radius = radius

    def get_length(self):
        return self.__length
    
    def set_length(self, length:float):
        self.__length = length

    def area(self):
        return math.pi * pow(self.__radius, 2) * (self.__radius + self.__length)
    
    def volume(self):
        return self.area() * self.__length
    
    def cylinder_info(self):

        return f"Cylinder: Radius = {self.__radius:.2f}, Lenght = {self.__length:.2f}, Area = {self.area():.2f}, Volume = {self.volume():.2f}"
