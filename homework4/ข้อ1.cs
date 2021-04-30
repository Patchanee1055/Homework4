using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int val = 1, i, j;
            if (rows < 0) { Console.WriteLine("Invalid Pascal’s triangle row number."); }
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        val = 1;
                    else
                        val = val * (i - j + 1) / j;
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
