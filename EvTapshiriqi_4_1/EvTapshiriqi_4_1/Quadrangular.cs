namespace EvTapshiriqi_4_1
{
    public abstract class Quadrangular
    {
        protected double a;
        protected double b;
        protected double c;
        protected double d;

        public Quadrangular (double aSide, double bSide, double cSide, double dSide)
        {
            this.a = aSide;
            this.b = bSide;
            this.c = cSide;
            this.d = dSide;
        }

        public double Perimetr()
        {
            return a + b + c + d;
        }
        public abstract double Area();

        public override string ToString()
        {
            return $@"## {this.GetType().Name}##
            Perimetr: {this.Perimetr()}
            Area : {this.Area()}";
        }
    }
}
