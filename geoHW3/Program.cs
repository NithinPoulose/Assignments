using System;

namespace geoHW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int credit = 0;
            int debit = 0;
            int bal = 1000;
            int option = 0;
            int condition = 1;
            int id = 0;
            string pass = "x";
            Console.WriteLine("for testing use id: 12345 and password: xxxxx\n\n\n");
            while (true)
            {
                Console.WriteLine("\n\n\t\t-------LOG IN SCREEN-------");
                Console.WriteLine("ENTER YOUR ID");
                id = int.Parse(Console.ReadLine());
                if (id == 12345)
                {
                    Console.WriteLine("HI Mr/Ms.User, ENTER YOUR PASSWORD");
                    pass = Console.ReadLine();
                    if (pass == "xxxxx")
                    {
                        while (condition == 1)
                        {
                            Console.WriteLine("____________________________________________________________________");
                            Console.WriteLine("\nENTER 1 FOR CREDIT\nENTER 2 FOR DEBIT");
                            Console.WriteLine("ENTER 3 FOR CHECK BALANACE\n\nENTER 0 TO LOGOUT AND EXIT");
                            option = int.Parse(Console.ReadLine());
                            Console.WriteLine("____________________________________________________________________\n");
                            switch (option)
                            {
                                case 0:
                                    condition = 0;
                                    break;
                                case 1:
                                    Console.WriteLine("\t\t------CREDIT------");
                                    Console.WriteLine("\nENTER THE AMOUNT TO BE CREDITED");
                                    credit = int.Parse(Console.ReadLine());
                                    bal = bal + credit;
                                    Console.WriteLine("\nSUCESSFUL...\n\nCURRENT BALANCE= " + bal);
                                    Console.WriteLine("____________________________________________________________________");
                                    break;
                                case 2:
                                    Console.WriteLine("\n\t\t------DEBIT------");
                                    Console.WriteLine("\nCURRENT BALANCE= " + bal);
                                    Console.WriteLine("ENTER THE AMOUNT TO BE DEBITED");
                                    debit = int.Parse(Console.ReadLine());
                                    if (debit > bal)
                                    {
                                        Console.WriteLine("\nSORRY! YOU DON'T HAVE ENOUGH BALANCE IN ACCOUNT");
                                        Console.WriteLine("\nFAILED... \n\nYOUR CURRENT BALANCE= " + bal);
                                        break;
                                    }
                                    else
                                    {
                                        bal = bal - debit;
                                        Console.WriteLine("\nSUCESSFUL...\n\nCURRENT BALANCE= " + bal);
                                    }
                                    Console.WriteLine("____________________________________________________________________");
                                    break;
                                case 3:
                                    Console.WriteLine("\n\t\t------BALANCE------");
                                    Console.WriteLine("\nCURRENT BALANCE= " + bal);
                                    Console.WriteLine("____________________________________________________________________");
                                    break;
                                default:
                                    Console.WriteLine("\nWRONG OPTION");
                                    Console.WriteLine("____________________________________________________________________");
                                    break;
                            }
                            if (condition == 1)
                            {
                                Console.WriteLine("\n\t\tDO YOU WANT TO CONTINUE?");
                                Console.WriteLine("\t\t\tTO CONTINUE ENTER: 1\n\t\t\tTO EXIT ENTER ANY OTHER NUMBER");
                                condition = int.Parse(Console.ReadLine());
                            }
                        }

                    }
                    else if(pass=="XXXXX")
                        Console.WriteLine("\t  PASSWORD IS CASE SENSITIVE. TRY AGAIN!");
                    else
                        Console.WriteLine("\t\t  WRONG PASSWORD. TRY AGAIN");
                }
                else
                    Console.WriteLine("\t\t  ID NOT EXIST. TRY AGAIN");

            }

        }
    }
}
