using Tyuiu.MoskalevSO.Sprint4.Task6.V28.Lib;

namespace Tyuiu.MoskalevSO.Sprint4.Task6.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            string[] array = new string[5];
            for (int i = 0; i < 5; i++)
            {
                int[] row = new int[5];
                for (int j = 0; j < 5; j++)
                {
                    row[j] = rnd.Next(-6, 4);
                }
                array[i] = string.Join(" ", row);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            foreach (string line in array)
            {
                Console.WriteLine(line);
            }

            string[] result = ds.Calculate(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");
            foreach (string line in result)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();
        }
    }
}