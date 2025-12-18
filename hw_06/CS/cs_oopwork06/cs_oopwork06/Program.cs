using cs_oopwork06.clothes;

namespace cs_oopwork06;

class Program
{
    static void Main(string[] args)
    {
        var s1 = new Shirt();
        s1.ShirtInfo();
        s1.SetColor(Color.Blue);
        s1.SetSize(Size.XL);
        s1.ShirtInfo();

        var e1 = new Earth();
        e1.EarthInfo();

        var r1 = new Rectangle();
        r1.RecInfo();
        r1.SetWidth(3.0);
        r1.SetHeight(5.0);
        r1.RecInfo();

        var cir1 = new Circle();
        cir1.cirInfo();
        cir1.SetRadius(5.0);
        cir1.cirInfo();

        var cy1 = new Cylinder();
        cy1.CyInfo();
        cy1.SetRadius(2.0);
        cy1.SetHeight(6.0);
        cy1.CyInfo();
    }
}