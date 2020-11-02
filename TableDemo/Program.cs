using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableDemo
{
    class Program
    {
        static void Main(string[] args)

        {
            int number = 30;
            bool found = false;

            int[,] array = new int[10, 10];

            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    array[i, j] = (i + 1) * (j + 1);
                    if (i*j ==number)
                    {
                        found = true;
                        //Console.WriteLine("Gevonden");
                        break;
                    }
                    Console.Write("\t");
                    Console.Write(i*j);
                }
                Console.WriteLine("\t");
                if (found)
                {
                    Console.WriteLine("Found");
                    break;
                }
            }

        }
    }
}
