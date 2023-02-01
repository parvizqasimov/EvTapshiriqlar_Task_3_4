namespace EvTapshiriqi_4_1
{
    public class Rectangular : Quadrangular
    {
        public Rectangular(double a, double b)
            : base(a, b, a, b)
        {

        }
        public override double Area()
        {
            double area = a * b;
            return area;
        }
    }
}
