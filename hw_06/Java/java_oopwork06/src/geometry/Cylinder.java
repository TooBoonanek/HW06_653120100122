public class Cylinder {

    private double radius;
    private double length;

    public Cylinder(double radius, double length) {
        this.radius = radius;
        this.length = length;
    }

    public Cylinder() {
        this(1.0, 1.0);
    }

    public double getRadius() {
        return radius;
    }

    public void setRadius(double radius) {
        this.radius = radius;
    }

    public double getLength() {
        return length;
    }

    public void setLength(double length) {
        this.length = length;
    }

    public double area() {
        return 2 * Math.PI * radius * (radius + length);
    }

    public double volume() {
        return area() * length;
    }

    public void showCyInfo() {
        System.out.println("\nCylinder:");
        System.out.printf("Radius = %.2f%n", radius);
        System.out.printf("Length = %.2f%n", length);
        System.out.printf("Area = %.2f%n", area());
        System.out.printf("Volume = %.2f%n", volume());
    }
}


