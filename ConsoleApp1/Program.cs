using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rozpoczynam sprawdzian)");
            Zadanie_5_6();
            Console.WriteLine("Kończę sprawdzian.");
        }

        static void Zadanie_1()
        {
            Console.WriteLine("Rozpoczynam zadanie 1");
            int a = 11;
            int b = 123;
            for (int i = b; i >= a; i--)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Kończę zadanie 1");
        }
        static void PrintTriangle(int x)
        {
            Console.WriteLine("Rozpoczynam zadanie 2");
            int x2 = x - 1;
            int symbolNumber = 1;
            for(int i = 0; i<x; i++)
            {
                for (int j = 0; j < x2; j++)
                    Console.WriteLine(" ");
                x2--;
                for (int k = 0; k< symbolNumber; k++)
                {
                    Console.WriteLine("$");
                }
                symbolNumber = symbolNumber + 2;
                Console.WriteLine();
            }
            PrintTriangle(10);
            Console.WriteLine("Kończę zadanie 2");
        }

        static void Zadanie_3()
        {
            Console.WriteLine("Rozpoczynam zadanie 3");
            DateTime today = DateTime.Now;

            // tutaj rozwiązanie zadania 3
            string finalText = "";
            if (DateTime.Now.Hour <= 12)
            {
                finalText = $"Dzień dobry, dzisiaj {DateTime.Now.DayOfWeek}, czyli {(int)DateTime.Now.DayOfWeek} dzień tygodnia";
            }
            else
            {
                finalText = $"Dobry wieczór, dzisiaj {DateTime.Now.DayOfWeek}, czyli {(int)DateTime.Now.DayOfWeek} dzień tygodnia";
            }

            Console.WriteLine(finalText);
            Console.WriteLine("Kończę zadanie 3");
        }

        static void Zadanie_4()
        {
            Console.WriteLine("Rozpoczynam zadanie 4");
            double[] numbers = { 1.5, -2.22, 4.56, -7, 8.01, 0.0 };
            double maxAbsValue = FindMaxAbsoluteValue(numbers);
            Console.WriteLine("The MIN value = " + FindMaxAbsoluteValue(numbers));
            Console.WriteLine("Kończę zadanie 4");
        }
        private static double FindMaxAbsoluteValue(double[] args)
        {
            if(args == null || args.Length == 0)
            {
                Console.WriteLine("Fault");
            }
            double maxAbsValue = args[0];
            foreach (double value in args)
            {
                if(Math.Abs(value) > Math.Abs(maxAbsValue))
                {
                    maxAbsValue = value;
                }
            }
            return maxAbsValue;
        }


        static void Zadanie_5_6()
        {
            Console.WriteLine("Rozpoczynam pętlę.");
            Console.WriteLine("Podaj numer zadania od 1 do 4, które mam wyświetlić.");
            int n;
            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n == 0)
                        break;
                    if (n == 1)
                        Zadanie_1();
                    if (n == 3)
                        Zadanie_3();
                    if (n == 4)
                        Zadanie_4();
                    if(n>4 || n < 0)
                    {
                        Console.WriteLine("Fault! Try Again");
                    }
                }
                catch (Exception e) {
                    Console.WriteLine("No numbers. Try Again");
                    Console.WriteLine(e.ToString());
                }
            }
            //Zadanie_1();
            ////PrintTriangle();
            //Zadanie_3();
            //Zadanie_4();

            Console.WriteLine("Kończę pętlę.");
        }

    }
}