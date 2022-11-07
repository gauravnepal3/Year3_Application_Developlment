using System;
namespace Year3ConsoleApp.Week3
{
    public class Week3Task
    {
        public static void Prime(int a)
        {
            int counter = 0;
            for(int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    counter++;
                }
            }
            if (counter == 2)
            {
                Console.WriteLine(a + " is a prime number");
            }
            else
            {
                Console.WriteLine(a + " is not a prime number");
            }
            Console.ReadLine();
        }

        public static void OddEven(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " is a even number");
            }
            else
            {
                Console.WriteLine(a + " is a even number");
            }
            Console.ReadLine();
        }
        public static void Swap(int a, int b)
        {
            Console.WriteLine("Before swap");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("After Swap");
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.ReadLine();
        }
        public static void Search(string[] a,string value)
        {
            bool found = false;
            int index=0;
            for (int i=0;i<a.Length;i++)
            {
                if (a[i] == value)
                {
                    found = true;
                    index = i;
                        break;
                }
            }
            if (found == true)
            {
                Console.WriteLine("Value Found on "+index+" index");
            }
            else
            {
                Console.WriteLine("Value Not Found");

            }
            Console.ReadLine();
        }

    }
}

