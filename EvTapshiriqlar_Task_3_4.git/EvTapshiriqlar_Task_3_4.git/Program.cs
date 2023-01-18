namespace EvTapshiriqlar_Task_3_4.git

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1_1();
            //Task1_2();
            //Task1_3();
            //Task1_4();
            //Task1_5();

            //Task1_7();
            //Task1_8();
            Task1_9();

        }
        static void Task1_1()
        {
        /* 1.a massivinin(a[0], a[1]....a[n]) | a[i] | < c sertini odeyen 
       elementlerini cap etmek(c deyisheninin 
       qiymeti istifadeciden sorushulur, hemcinin a massivinin elementleri de)*/

        Label1:
            Console.Write("massivin olcusunu daxil edin : ");
            string inputValue = Console.ReadLine();
            int n;
            if (int.TryParse(inputValue, out n) != true)
            {
                Console.WriteLine("eded dogru deyil");
                goto Label1;
            }
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"massivin {i + 1} elementini daxil edin : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("C deyisheni daxil edin : ");
            int c = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]! < c)
                {
                    Console.WriteLine($"Sherti odeyen element : {arr[i]}");
                }

            }


        }
        static void Task1_2()
        {
        /* a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen elementlerinin ededi ortasini tapmaq)*/

        Label1:
            Console.Write("massivin olcusunu daxil edin : ");
            string inputValue = Console.ReadLine();
            int n;
            if (int.TryParse(inputValue, out n) != true)
            {
                Console.WriteLine("eded dogru deyil");
                goto Label1;
            }
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"massivin {i + 1} elementini daxil edin : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("C deyisheni daxil edin : ");
            int c = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;
            double netice;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]! < c)
                {
                    Console.WriteLine($"Sherti odeyen element : {arr[i]}");
                    count++;
                    sum = sum + arr[i];
                }
            }
            netice = (double)sum / count;
            Console.WriteLine($"Ededi ortasi :{netice}");

        }
        static void Task1_3()
        {
        /* a massivinin (a[0],a[1] .... a[n])  |a[i]| > c sertini odeyen elementlerinin hendesi ortasini tapmaq*/

        Label1:
            Console.Write("massivin olcusunu daxil edin : ");
            string inputValue = Console.ReadLine();
            int n;
            if (int.TryParse(inputValue, out n) != true)
            {
                Console.WriteLine("eded dogru deyil");
                goto Label1;
            }
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"massivin {i + 1} elementini daxil edin : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("C deyisheni daxil edin : ");
            int c = int.Parse(Console.ReadLine());

            int sum = 1;
            double count = 0;
            double netice;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]! > c)
                {
                    Console.WriteLine($"Sherti odeyen element : {arr[i]}");
                    count++;
                    sum = sum * arr[i];
                }
            }
            count = 1 / count;
            netice = Math.Pow(sum, count);
            Console.WriteLine($"Ededi ortasi :{netice}");

        }
        static void Task1_4()
        {
        /*  a massivinin (a[0],a[1] .... a[n])  |a[i]| > c sertini odeyen elementlerini coxdan aza dogru siralamaq*/

        Label1:
            Console.Write("massivin olcusunu daxil edin : ");
            string inputValue = Console.ReadLine();
            int n;
            if (int.TryParse(inputValue, out n) != true)
            {
                Console.WriteLine("eded dogru deyil");
                goto Label1;
            }
            int[] arr = new int[n];
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write($"massivin {i + 1} elementini daxil edin : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            //Console.Write("C deyisheni daxil edin : ");
            //int c = int.Parse(Console.ReadLine());


            int temp;
            for (i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > c)
            //    {
            //        Console.Write("Array:");
            //        foreach (int i in arr)
            //        {
            //        Console.Write($"{i}  ");
            //        }
            //    }
            //}

            // Console.WriteLine($"Sherti odeyen element : {arr}");
        }// c ni muqayise ede bilmedim
        static void Task1_5()// c ni muqayise ede bilmedim
        {
        /*  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen elementler icinden maximum elementi tapmaq*/

        Label1:
            Console.Write("massivin olcusunu daxil edin : ");
            string inputValue = Console.ReadLine();
            int n;
            if (int.TryParse(inputValue, out n) != true)
            {
                Console.WriteLine("eded dogru deyil");
                goto Label1;
            }
            int[] arr = new int[n];
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write($"massivin {i + 1} elementini daxil edin : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("C deyisheni daxil edin : ");
            int c = int.Parse(Console.ReadLine());


            int max = 0;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($" Maximum eded : {max}");


        }
        static void Task1_7()
        {
        /*  a massivinin (a[0],a[1] .... a[n]) en kicik ve en boyuk elementlerinin hendesi ve ededi ortasini tapmali*/

        Label1:
            Console.Write("massivin olcusunu daxil edin : ");
            string inputValue = Console.ReadLine();
            int n;
            if (int.TryParse(inputValue, out n) != true)
            {
                Console.WriteLine("eded dogru deyil");
                goto Label1;
            }
            int[] arr = new int[n];
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write($"massivin {i + 1} elementini daxil edin : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = 0;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($" Maximum eded : {max}");

            int min = max;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($" Minimum eded : {min}");


        }
        static void Task1_8()
        {
            /*   Heriri 14 elementli 2 massivin uygun elementlerini 
             bir birine vurub?alinan musbet hasillerden  yeni massiv duzeltmeli*/


            int[] arr = new int[14];


            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" 1-ci massivin {i + 1} elementini daxil edin : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] arr2 = new int[14];
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($" 2-ci massivin {i + 1} elementini daxil edin : ");
                arr2[i] = int.Parse(Console.ReadLine());
            }
            int[] arr3 = new int[14];

            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = arr[i] * arr2[i];

            }


            foreach (int i in arr3)
            {
                Console.WriteLine($" 3-ci massivin  elementi: {i} ");

            }


            //Console.WriteLine($" Minimum eded : {min}");


        }
        static void Task1_9()
        {
            /*   25 elementli massivin ilk 8 elementini kvadrata yukseltmeli,
             qalanini ise 4-e bolub,yeni iki massiv duzeltmeli*/


            int[] arr = new int[4];


            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" 1-ci massivin {i + 1} elementini daxil edin : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] arr2 = new int[2];
            int[] arr3 = new int[2];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < 2)
                {
                    arr2[i] = arr[i] * arr[i];
                }
                arr3[i] = arr[i] / 4;
            }

            foreach (int i in arr2)
            {
                Console.WriteLine($" 2-ci massivin  elementi: {i} ");
            }

            foreach (int i in arr3)
            {
                Console.WriteLine($" 3-ci massivin  elementi: {i} ");
            }


            //Console.WriteLine($" Minimum eded : {min}");


        }
    }
}


