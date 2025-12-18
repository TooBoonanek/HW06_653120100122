
namespace cs_oopwork06.clothes
{
    public class Shirt
    {
        private Color color;
        private Size size;
        private double price;

        public Color GetColor()
        {
            return color;
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }

        public Size GetSize()
        {
            return size;
        }

        public void SetSize(Size size)
        {
            this.size = size;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public Shirt(Color color, Size size, double price)
        {
            this.color = color;
            this.size = size;
            this.price = price;
        }

        public Shirt(): this(Color.Black, Size.L, 199.00){}

        public void ShirtInfo()
        {
            System.Console.WriteLine($"Shirt: Color {color}, Size {size}, Price {price:N2}");
        }
    }
}