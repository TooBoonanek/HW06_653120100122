class Rectangle:
    def __init__(self, width:float=1.0, height:float=1.0):
        self.__width = width
        self.__height = height

    def get_width(self):
        return self.__width
    
    def set_width(self, width:float):
        self.__width = width

    def get_heigth(self):
        return self.__height
    
    def set_heigth(self, height:float):
        self.__height = height

    def area(self):
        return self.__width * self.__height
    
    def info(self):
        return f"Rectangle: Width {self.__width:.2f}, Height: {self.__height:.2f}, Area {self.area():.2f}"