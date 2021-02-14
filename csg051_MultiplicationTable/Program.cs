using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace csg051_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   * * * 九九の表 * * *");
            Console.Write("   |");
            for (int i = 1; i <= 9; i++)
            {
                Console.Write("{0,3}", i);
            }
            Console.WriteLine("\n--------------------------------");

            for (int c = 1; c <= 9; c++)
            {
                Console.Write("{0}  |", c);
                for (int r = 1; r <= 9; r++)
                {
                    Console.Write("{0,3}", c * r);
                }
                Console.Write('\n');
            }

            Console.WriteLine("終了するには何かキーを押してください . . .");
            Console.Read();
        }
    }
}
