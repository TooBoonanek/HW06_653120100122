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

    public void showCirInfo() {
        System.out.println("\nCircle:");
        System.out.printf("Radius = %.2f%n", radius);
        System.out.printf("Area = %.2f%n", area());
    }
}

