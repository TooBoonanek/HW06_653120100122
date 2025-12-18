#include <iostream>

using namespace std;

class Rectangle {
    private:
        double width;
        double height;

    public:
        double getWidth(){
            return width;
        }

        void setWidth(double width){
            this->width = width;
        }

        double getHeight(){
            return height;
        }

        void setHeight(double height){
            this->height = height;
        }

        Rectangle(double width, double height): width(width), height(height) {}

        Rectangle():Rectangle(1.0, 1.0){}

        double area(){
            return width * height;
        }

        void recInfo(){
            cout << "Rectangle: Width = " << width << ", Height = " << height << ", Area = " << area() << endl;
        }
};