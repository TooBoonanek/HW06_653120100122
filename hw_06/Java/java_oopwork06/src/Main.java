import clothes.*;

public class Main {
    public static void main(String[] args) {
        var s1 = new Shirt();
        var s2 = new Shirt(Color.Red, Size.XL, 299.00);
        s1.shirtInfo();
        s2.shirtInfo();

        s1.setColor(Color.White);
        s1.setSize(Size.S);
        s1.setPrice(159.00);
        s1.shirtInfo();

        var e1 = new Earth();
        e1.showEInfo();

        var cir1 = new Circle();
        var cir2 = new Circle(5.0);
        cir1.showCirInfo();
        cir2.showCirInfo();
        cir1.setRadius(7.0);
        cir1.showCirInfo();

        var cy1 = new Cylinder();
        cy1.showCyInfo();
        cy1.setRadius(5.0);
        cy1.setLength(4.0);
        cy1.showCyInfo();
    }
}


