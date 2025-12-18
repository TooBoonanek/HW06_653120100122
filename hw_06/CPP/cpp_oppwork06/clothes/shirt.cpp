#include <iostream>
#include <map>
#include "color.cpp"
#include "size.cpp"

using namespace std;

class Shirt
{
private:
    Color color;
    Size size;
    double price;

public:
    Shirt(Color color, Size size, double price) : color(color), size(size), price(price) {}

    Shirt() : Shirt(Color::Black, Size::L, 199.00) {}

    Color getColor()
    {
        return color;
    }

    void setColor(Color color)
    {
        this->color = color;
    }

    string toString(Color c)
    {
        static map<Color, string> colorMap = {
            {Color::Black, "Black"},
            {Color::White, "White"},
            {Color::Red, "Red"},
            {Color::Green, "Green"},
            {Color::Blue, "Blue"}};

        return colorMap[c];
    }

    string toString(Size s)
    {
        static map<Size, string> sizeMap = {
            {Size::S, "S"},
            {Size::M, "M"},
            {Size::L, "L"},
            {Size::XL, "XL"}};

        return sizeMap[s];
    }

    void info()
    {
        cout << "Shirt: [ Color " <<  toString(color) << ", Size " << toString(size) << ", Price " << price << " ]" << endl;
    }
};