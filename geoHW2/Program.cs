using System;

namespace geoHW2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lmt = 0;
            int i = 0;
            int opt = 0;
            int srch = 0;
            int j = 0;
            int det = 0;
            int v = 0;
            int flag = 0;
            int check = 0;
            int flag2 = 0;
            int c = 0;

            Console.WriteLine("\nENTER THE NUMBER OF EMPLOYEES");
            lmt = int.Parse(Console.ReadLine());
            Employee[] emp = new Employee[9];

            for (i = 0; i < lmt; i++)
                emp[i] = new Employee();

            while (true)
            {
                Console.WriteLine("____________________________________________________________________________________");
                Console.WriteLine("\nEMPLOYEE PORTAL\n SELECT YOUR OPTION\n");
                Console.WriteLine("1. ADD DETAILS\n2. VIEW DETAILS\n3. EDIT DETAILS");
                opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.WriteLine("____________________________________________________________________________________");
                        Console.WriteLine("\nENTER THE EMPLOYEE DETAILS");
                        for (j = 0; j < lmt; j++)
                        {
                            flag2 = 0;
                            Console.WriteLine("\nENTER THE ID");
                            check = int.Parse(Console.ReadLine());
                            for (c = 0; c < j; c++)
                            {
                                if (check == emp[c].id)
                                    flag2 = 1;
                            }
                            if (flag2 == 0)
                            {
                                emp[j].id = check;
                                Console.WriteLine("\nENTER THE NAME");
                                emp[j].name = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("EMPLYEE ID EXISTS. ID SHOULD NOT BE REPEATED");
                                
                                break;
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("____________________________________________________________________________________");
                        Console.WriteLine("\nENTER 1 FOR ALL DETAILS\nENTER 2 FOR INDIVIDUAL EMPLOYEE DETAILS");
                        det = int.Parse(Console.ReadLine());
                        if (det == 1)
                        {
                            Console.WriteLine("\nEMPLOYEE DETAILS\n");
                            for (j = 0; j < lmt; j++)
                            {
                                Console.WriteLine("ID: " + emp[j].id + "        Name: " + emp[j].name + " ");
                            }
                            break;
                        }
                        else if (det == 2)
                        {
                            Console.WriteLine("\nENTER THE EMPLOYEE ID:");
                            v = int.Parse(Console.ReadLine());
                            for (j = 0; j < lmt; j++)
                            {
                                if (v == emp[j].id)
                                {
                                    Console.WriteLine("ID: " + emp[j].id + "        Name: " + emp[j].name + " ");
                                    break;
                                }
                            }
                            break;
                        }
                        else
                            Console.WriteLine("--WRONG OPTION--");

                        break;

                    case 3:
                        Console.WriteLine("____________________________________________________________________________________");
                        Console.WriteLine("TO EDIT DETAIS, ENTER THE EMPLOYEE ID:");
                        srch = int.Parse(Console.ReadLine());
                        for (j = 0; j < lmt; j++)
                        {
                            if (srch == emp[j].id)
                            {
                                Console.WriteLine("ENTER THE NEW NAME");
                                emp[j].name = Console.ReadLine();
                                flag = 1;
                            }
                        }
                        if (flag == 0)
                            Console.WriteLine("ID NOT FOUND");
                        else
                            break;
                        break;
                    default:
                        Console.WriteLine("____________________________________________________________________________________");
                        Console.WriteLine("WRONG INPUT TRY AGAIN");
                        break;


                }
            }
        }
    }
}

