using System;

namespace New_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int x = 0;

            while (true)
            {
                Console.WriteLine("__________________________________________________");
                Console.WriteLine("\nSELECT THE OPERATION \n\n1: ADDITION");
                Console.WriteLine("2: SUBTRACTION \n3: MULTIPLICAITON \n4: DIVISION \n");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("ENTER FIRST NUMBER");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("ENTER SECOND NUMBER");
                        b = int.Parse(Console.ReadLine());
                        c = a + b;
                        Console.WriteLine("\n" + a + "+" + b + "=" + c);
                        break;

                    case 2:
                        Console.WriteLine("ENTER FIRST NUMBER");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("ENTER SECOND NUMBER");
                        b = int.Parse(Console.ReadLine());
                        c = a - b;
                        Console.WriteLine("\n" + a + "-" + b + "=" + c);
                        break;

                    case 3:
                        Console.WriteLine("ENTER FIRST NUMBER");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("ENTER SECOND NUMBER");
                        b = int.Parse(Console.ReadLine());
                        c = a * b;
                        Console.WriteLine("\n" + a + "*" + b + "=" + c);
                        break;

                    case 4:
                        Console.WriteLine("ENTER FIRST NUMBER");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("ENTER SECOND NUMBER");
                        b = int.Parse(Console.ReadLine());
                        if (b == 0)
                        {
                            Console.WriteLine("Divident Should not be Zero");
                            break;
                        }
                        else
                        {
                            c = a / b;
                            Console.WriteLine("\n" + a + "/" + b + "=" + c);
                            break;
                        }

                    default:
                        Console.WriteLine("ENTER FIRST NUMBER");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("ENTER SECOND NUMBER");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("WRONG OPTION TRY AGAIN");
                        break;

                }
            }
        }
    }
}
