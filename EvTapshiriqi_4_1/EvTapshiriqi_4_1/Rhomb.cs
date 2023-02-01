namespace EvTapshiriqi_4_1
{
    public class Rhomb : Quadrangular
    {
        protected double angle;

        public Rhomb ( double side , double angle)
            :base (side,side,side,side)
        {
            this.angle = angle;
        }
        public override double Area()
        {
            double pi= Math.PI;
            double roundpi=Math.Round(pi,2);

            double rad = roundpi/180 * angle;
            double sin = Math.Round(Math.Sin(rad),2);

            return sin * a * a;
        }
    }
}
