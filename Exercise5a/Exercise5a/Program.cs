using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5a
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAtoZ();
            PrintAtoZ2();

            while (true)
            {
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine("  " + Char2Code(c));
            }

            IsUpper('a');

        }

        static void PrintAtoZ()
        {
            for (int i = 65;i < 91; i++)
            {
                Console.Write((char)i + "  ");
            }
            Console.WriteLine(" ");
        }
        static void PrintAtoZ2()
        {
            for (int i = 90; i > 64; i--)
            {
                Console.Write((char)i + "  ");
            }
            Console.WriteLine(" ");
        }
        
        public static int Char2Code(char c)
        {
            return (int)c;
        }

        public static bool IsUpper(char c)
        {
            
            if ((int)c > (int)64 && (int)c < (int)91)
            {
                return true;
            }
            return false;

        }
       
        public static bool IsLower(char c)
        {
            return false;
        }
        public static char ToUpper(char c)
        {
            return c;  
        }
    }
}
