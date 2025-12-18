#include <cmath>
#include <iostream>

using namespace std;

class Cylinder {
    private:
        double radius;
        double height;

    public:
        double getRadius(){
            return radius;
        }

        void setRadius(double radius){
            this->radius = radius;
        }

        double getHeight(){
            return height;
        }

        void setHeight(double height){
            this->height = height;
        }

        Cylinder(double radius, double height): radius(radius), height(height) {}
    
        Cylinder(): Cylinder(1.0, 1.0){}

        double area(){
            return M_PI * pow(radius, 2);
        }

        double volume(){
            return area() * height;
        }

        void cyInfo(){
            cout << "Cylinder: Radius = " << radius << ", Height = " << height << ", Area = " << area() << ", Volume = " << volume() << endl;
        }
};