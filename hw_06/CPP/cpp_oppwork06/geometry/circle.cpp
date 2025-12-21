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

        double area(){
            return M_PI * pow(radius, 2);
        }

        void cirInfo(){
            cout << fixed << setprecision(2) << "Circle: Radius = " << radius << ", Area = " << area() << endl;
        }   

};
