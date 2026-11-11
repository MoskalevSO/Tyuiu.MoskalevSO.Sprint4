using System;
using Tyuiu.MoskalevSO.Sprint4.Task7.V15.Lib;

namespace Tyuiu.MoskalevSO.Sprint4.Task7.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 2;
            string str = "10293847";

            Console.WriteLine("**");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("**");
            Console.WriteLine($"n = {n}, m = {m}");
            Console.WriteLine($"Строка: {str}");
            Console.WriteLine();

            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[k],4}");
                    k++;
                }
                Console.WriteLine();
            }

            int result = ds.Calculate(n, m, str);

            Console.WriteLine("**");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                              ");
            Console.WriteLine("**");
            Console.WriteLine($"Количество нечётных элементов: {result}");

            Console.ReadKey();
        }
    }
}
