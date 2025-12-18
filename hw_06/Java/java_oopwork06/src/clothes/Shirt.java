public class Shirt {
    private Color color;
    private Size size;
    private double price;

    public Shirt() {
        this(Color.Black, Size.L, 199.00);
    }

    public Shirt(Color color, Size size, double price) {
        this.color = color;
        this.size = size;
        this.price = price;
    }

    public void shirtInfo() {
        System.out.println("Shirt: [ Color: " + color + ", Size: " + size + ", Price: " + price + "]");
    }

    public Color getColor() {
        return color;
    }

    public void setColor(Color color) {
        this.color = color;
    }

    public Size getSize() {
        return size;
    }

    public void setSize(Size size) {
        this.size = size;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }
}
