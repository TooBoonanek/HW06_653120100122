#include <iostream>
#include "clothes/shirt.cpp"
#include "geometry/earth.cpp"
#include "geometry/circle.cpp"
#include "geometry/cylinder.cpp"
#include "geometry/rectangle.cpp"

using namespace std;

int main() {
    Shirt s1, s2(Color::White, Size::M, 199.00);
    s1.setColor(Color::Green);
    s1.info();
    s2.info();

    Earth e1;
    e1.EarthInfo();

    Circle cir1;
    cir1.cirInfo();
    cir1.setRadius(5.0);
    cir1.cirInfo();

    Cylinder cy1;
    cy1.cyInfo();
    cy1.setRadius(3.0);
    cy1.setHeight(5.0);
    cy1.cyInfo();

    Rectangle r1;
    r1.recInfo();
    r1.setWidth(2.0);
    r1.setHeight(5.0);
    r1.recInfo();
    return 0;
}