using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MoskalevSO.Sprint4.Task2.V15.Lib
{
    public class DataService : ISprint4Task2V15
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            return sum;
        }
    }
}