public class Cylinder {

    private double radius;
    private double height;

    public Cylinder(double radius, double height) {
        this.radius = radius;
        this.height = height;
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

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        this.height = height;
    }

    public double area() {
        return Math.PI * Math.pow(radius, 2);
    }

    public double volume() {
        return area() * height;
    }

    public void showCyInfo() {
        System.out.println("\nCylinder:");
        System.out.printf("Radius = %.2f%n", radius);
        System.out.printf("Height = %.2f%n", height);
        System.out.printf("Area = %.2f%n", area());
        System.out.printf("Volume = %.2f%n", volume());
    }
}
