using System;
namespace Year3ConsoleApp.Week2
{
    public class ControlStatemnet
    {
        public static void Greater(int a,int b)
        {
            if (a > b)
            {
                Console.WriteLine(a + " is greater than " + b);
            }
            else if (b > a)
            {
                Console.WriteLine(b + " is greater than " + a);
            }
            else
            {
                Console.WriteLine(a + " and " + b + " are equal");

            }
            Console.ReadLine();
        }

        public static void SwitchCase()
        {
            Console.WriteLine("Press 1 for display number");
            Console.WriteLine("Press 2 for display string");
            Console.WriteLine("Enter your option");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("1,2,3,4,5,6");
                    break;
                case "2":
                    Console.WriteLine("a,b,c,d,e,f");
                    break;
                default:
                    Console.WriteLine("No code for this option");
                        break;
            }
            Console.ReadLine();
        }

        public static void WhileStatement()
        {
            int a = 1;
            while (a < 10)
            {
                Console.WriteLine("Value of a is " + a);
            }
         }
        public static void DoWhileStatement()
        {
            int a = 0;
            do
            {
                Console.WriteLine("Enter a number");
                 a = Convert.ToInt32(Console.ReadLine());
            } while (a < 10);
        }
        public static void ForStatement()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void ForEachStatemnet()
        {
            //int[] arr_array = new int[] {0, 1, 2, 3, 4, 5 };
            string[] arr_array = new string[] {"gaurav", "1", "2", "3", "4", "5" };
            foreach (string i in arr_array)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

    }
}

