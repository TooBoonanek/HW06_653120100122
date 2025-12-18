from clothes.Color import Color
from clothes.Size import Size

class Shirt:
    def __init__(self, color:Color=Color.Black, size:Size=Size.L, price:float=199.00):
        self.__color = color
        self.__size = size
        self.__price = price

    def get_color(self):
        return self.__color
    
    def set_color(self, color:Color):
        self.__color = color

    def get_size(self):
        return self.__size
    
    def set_size(self, size:Size):
        self.__size = size

    def get_price(self):
        return self.__price
    
    def set_price(self, price:float):
        self.__price = price

    def info(self):
        return f"Shirt: Color {self.__color.name}, Size {self.__size.name}, Price {self.__price}" 