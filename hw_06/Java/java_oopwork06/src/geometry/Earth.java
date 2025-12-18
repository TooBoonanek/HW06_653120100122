public class Earth {

    double G = 6.673e-11;
    double radius = 6.3781e6;
    double mass = 5.97e24;

    public Earth(double G, double radius, double mass) {
        this.G = G;
        this.radius = radius;
        this.mass = mass;
    }

    public Earth() {
        this(6.673e-11, 6.371e6, 5.972e24);
    }

    public double getG() {
        return G;
    }

    public void setG(double G) {
        this.G = G;
    }

    public double getRadius() {
        return radius;
    }

    public void setRadius(double radius) {
        this.radius = radius;
    }

    public double getMass() {
        return mass;
    }

    public void setMass(double mass) {
        this.mass = mass;
    }

    public void showEInfo() {
        System.out.println("\nEarth:");
        System.out.printf("G = %.3e%n", G);
        System.out.printf("Radius = %.2f m%n", radius);
        System.out.printf("Mass = %.3e kg%n", mass);
    }
}
