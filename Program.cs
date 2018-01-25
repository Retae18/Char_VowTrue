using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_VowTrue
{
    class Program
    {
        static void Main(string[] args)

        {

            char[] vow = { 'A', 'E', 'I', 'O', 'U' }; //set an array, remember flower brackets
            vow[0] = 'A';
            vow[1] = 'E';
            vow[2] = 'I';
            vow[3] = 'O';
            vow[4] = 'U';

            Console.WriteLine("Enter Character");
            char x = Console.ReadKey().KeyChar;
            // char x = Convert.ToChar(Console.ReadLine());
        }

        static bool checkVowel(char x)
        {
            if (x == 'A' || x == 'E' || x == 'I' || x == 'O' || x == 'U')
            {
                return true;
            }

            else
                return false;
        }
    }
}

