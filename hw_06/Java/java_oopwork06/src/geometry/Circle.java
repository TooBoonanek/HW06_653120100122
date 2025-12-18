public class Circle {

    private double radius;

    public Circle(double radius) {
        this.radius = radius;
    }

    public Circle() {
        this(1.0);
    }

    public double getRadius() {
        return radius;
    }

    public void setRadius(double radius) {
        this.radius = radius;
    }

    public double area() {
        return Math.PI * Math.pow(radius, 2);
    }

    public double diameter() {
        return 2 * radius;
    }

    public double circumference() {
        return 2 * Math.PI * radius;
    }

    public void showCirInfo() {
        System.out.println("\nCircle:");
        System.out.printf("Radius = %.2f%n", radius);
        System.out.printf("Area = %.2f%n", area());
        System.out.printf("Diameter = %.2f%n", diameter());
        System.out.printf("Circumference = %.2f%n", circumference());
    }
}
