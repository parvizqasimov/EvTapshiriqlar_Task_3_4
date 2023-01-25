using System.Dynamic;
using System.Threading.Tasks;

namespace Lab21012023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            Task7();
        }

        static void Task1()
        {
            Console.Write("Sozu daxil edin:");
            string soz;
            soz = Console.ReadLine();

            //char first = soz[0];
            //string other = soz.Substring(1);
            //soz = other + first;

            //Console.Write(soz);

            string ters = "";

            for (int i = soz.Length - 1; i >= 0; i--)
            {
                ters += soz[i];
            }
            Console.WriteLine($"Sozun tersi: {ters}");
        }
        static void Task2()
        {
            Console.Write("Cumleni daxil edin:");
            string cumle;
            cumle = Console.ReadLine();

            int result = CountofSpace(cumle);
            Console.WriteLine(result);
        }
        static int CountofSpace (string cumle) // task2 nin metodudur/
        {
            int count = 0;
            char boshluq = ' ';

            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] == boshluq)
                {
                    count++;
                }
            }
            return count; // return voidda ishlemir

        }
        static void Task3()
        {
            
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Massivin elementlerini daxil et: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int countOFPos = 0, countOfNeg = 0, countofZero = 0;

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > 0)
                {
                    countOFPos++;
                }
                else if (arr[j]<0)
                {
                    countOfNeg++;
                }
                else
                {
                    countofZero++;
                }
            }
            Console.WriteLine($"Pos {countOFPos},Neg {countOfNeg},Zero{countofZero}");
        }
        static void Task4()
        {
            long a = long.Parse(Console.ReadLine());                        
            long result = FactorMtd(a);
            Console.WriteLine(result);
        }
        static long FactorMtd (long eded)
        {           
            long yekun = 1;
            for (long i = 1; i <= eded; i++)
            {
                yekun = i * yekun;             
            }
            return yekun;
        }

        static void Task5()  // massivin icinde massiv
        {
            Console.WriteLine("Setrlerin sayini daxil edin:");
            int setr = int.Parse(Console.ReadLine());
            Console.WriteLine("Sutunlarin sayini daxil edin:");
            int sutun = int.Parse(Console.ReadLine());

            int[,] arr = new int[setr, sutun] ;

            int result = 0;
            for (int i = 0; i < setr; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    arr[i,j] = int.Parse(Console.ReadLine());

                    result = result + arr[i, j];
                }
            }

            //int result = 0;
            //for(int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        result = result + arr[i, j];
            //    }
            //}
            Console.WriteLine(result);
        }
        static void Task6()  // massivin icinde massiv
        {
            //Console.WriteLine()
            //int n, m;
            int[,] arr = new int[3, 2] { { 1, 2 }, { 1, 2 }, { 1, 2 } };



            int result = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    result = result + arr[i, j];
                }
            }
            Console.WriteLine(result);

            
            }

        static void Task7()  // massivin icinde massiv
        {
            //Console.WriteLine()
            //int n, m;
            int[,] arr = new int[3, 2] { { 1, 2 }, { 1, 2 }, { 1, 2 } };

            int result = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        result = result + arr[i, j];
                    }
                    
                }
            }
            Console.WriteLine(result);

        }
        }   
}