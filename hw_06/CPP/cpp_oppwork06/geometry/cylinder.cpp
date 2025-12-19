#include <cmath>
#include <iostream>

using namespace std;

class Cylinder {
    private:
        double radius;
        double length;

    public:
        double getRadius(){
            return radius;
        }

        void setRadius(double radius){
            this->radius = radius;
        }

        double getLngth(){
            return length;
        }

        void setLength(double length){
            this->length = length;
        }

        Cylinder(double radius, double length): radius(radius), length(length) {}
    
        Cylinder(): Cylinder(1.0, 1.0){}

        double area(){
            return 2 * M_PI * radius * (radius + length);
        }

        double volume(){
            return area() * length;
        }

        void cyInfo(){
            cout << "Cylinder: Radius = " << radius << ", Length = " << length << ", Area = " << area() << ", Volume = " << volume() << endl;
        }

};

