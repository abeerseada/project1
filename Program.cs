using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, w, n1, n2;


            Console.Write("please enter the starting number of range: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter theending number of range : ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", n1, n2);

            for (x = n1; x <= n2; x++)
            {
                w = 0;

                for (y = 2; y < x; y++)
                {
                    if (x % y == 0)
                    {
                        w++;
                        break;
                    }
                }

                if (w == 0 && x != 1)
                    Console.Write("{0} ", x);
            }
            Console.Write("\n");
        }
    }
}

