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
        static void PrintAtoZ3()
        {

        }

    }
}
