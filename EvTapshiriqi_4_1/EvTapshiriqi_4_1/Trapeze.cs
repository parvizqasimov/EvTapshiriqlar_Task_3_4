namespace EvTapshiriqi_4_1
{
    internal class Trapeze : Quadrangular
    {
        private double h;
        /// <summary>
        /// trapesiya metodu
        /// </summary>
        /// <param name="ust"></ust oturacq>
        /// <param name="alt"></alt oturacaq>
        /// <param name="yan"></yan terefidir>
        /// <param name="h"></hundurlukdur>
        
        public Trapeze(double ust, double alt, double yan, double h)
            : base(ust, yan, alt, yan)
        {
            this.h = h;
        }
        public override double Area()
        {
            return ((a + c) / 2) * h;
        }
    }
}
