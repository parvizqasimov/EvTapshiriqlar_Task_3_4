namespace EvTapshiriqi_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rect = new Rectangular(10, 20);
            Console.WriteLine(rect);
            var romb = new Rhomb(4, 30);
            Console.WriteLine(romb);
            var sqr = new Square(4);
            Console.WriteLine(sqr);
            var trap = new Trapeze(4, 10, 5, 4);
            Console.WriteLine(trap);

        }
    }
}