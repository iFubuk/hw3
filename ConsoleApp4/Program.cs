using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine()), prS = 0, maxS = 0, f = 0;
            Random rnd = new Random();
            int[,] mas = new int[a,b];

            for (int i  = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    mas[i,j] = rnd.Next(-99, 100);
                    Console.Write($"{mas[i,j]}\t");
                }
                Console.WriteLine();
            }

            for (int i = 0;i < a;i++)
            {
                for(int j = 0;j < b; j++)
                {
                    prS += Math.Abs(mas[i, j]);
                }

                if (maxS < prS) { 
                    f = i; 
                    maxS = prS; 
                     
                }
                prS = 0;
            }

            Console.WriteLine($"Максимальная сумма абсолютных значений элементов по строкам = {f + 1}\nНомер строки с такой суммой = {maxS}");
            maxS = 0; f = 0;

            for (int j = 0; j < b; j++)
            {
                for (int i = 0; i < a; i++)
                {
                    prS += Math.Abs(mas[i, j]);
                }

                if (maxS < prS)
                {
                    f = j;
                    maxS = prS;
                }
                prS = 0;
            }
            Console.WriteLine($"Максимальная сумма абсолютных значений элементов по столбцам = {f + 1}\nНомер столбца с такой суммой = {maxS}");
        }
    }
}
