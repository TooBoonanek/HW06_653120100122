#include <iostream>
#include <cmath>
#include <iomanip>

using namespace std;

class Circle {
    private: 
        double radius;

    public:
        double getRadius(){
            return radius;
        }

        void setRadius(double radius){
            this->radius = radius;
        }

        Circle(double radius): radius(radius){}

        Circle():Circle(6.0){}

        // in class
        // double area(){
        //     return M_PI * pow(radius, 2);
        // }

        // out class
        double area();

        double diameter() {
            return 2 * radius;
        }

        double circumference() {
            return 2 * M_PI * radius;
        }

        void cirInfo(){
            cout << fixed << setprecision(2) << "Circle: Radius = " << radius << ", Area = " << area() << ", Diameter = " << diameter() << ", Circumference = " << circumference() << endl;
        }        // ทศนิยม #include <iomanip>

};

// area out class
double Circle::area(){
    return M_PI * pow(radius, 2);
}