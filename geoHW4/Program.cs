using System;

namespace geoHW4
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int len;
            int i;
            int word = 1;
            int vowels = 0;
            int car = 0;
            int spc = 0;
            int space = 0;
            int digit = 0;
            int white = 0;
            Console.WriteLine("\nENTER THE STRING");
            line = Console.ReadLine();
            len = line.Length;
            Console.WriteLine("LENGTH OF STRING = " + len);

            for (i = 0; i < len - 1; i++)
            {
                if ((line[i] == ' ' && line[i + 1] != '\0') || (line[i] == ' ' && line[i + 1] != ' '))
                {
                    word = word + 1;
                }
            }
            for (i = 0; i < len; i++)
            {
                if (line[i] == 'a' || line[i] == 'e' || line[i] == 'i' || line[i] == 'o' || line[i] == 'u' || line[i] == 'A' || line[i] == 'E' || line[i] == 'I' || line[i] == 'O' || line[i] == 'U')
                {
                    vowels = vowels + 1;
                }
            }
            for (i = 0; i < len; i++)
            {
                if (line[i] >= 'a' && line[i] <= 'z' || line[i] >= 'A' && line[i] <= 'Z')
                {
                    car = car + 1;
                }
                else if (line[i] >= '0' && line[i] <= '9')
                {
                    digit = digit + 1;
                }
                else if (line[i]==' ')
                {
                    white = white + 1;
                }
                else
                    spc = spc + 1;
            }
            
            Console.WriteLine("NUMBER OF WORDS: " + word);
            Console.WriteLine("NUMBER OF ALPHABETS: " + car);
            Console.WriteLine("NUMBER OF WHITE SPACES: " + white);
            Console.WriteLine("NUMBER OF SPECIAL CHAACTERS: " + spc);
            Console.WriteLine("NUMBER OF VOWELS: " + vowels);
        }
    }
}
