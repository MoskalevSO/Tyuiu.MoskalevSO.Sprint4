using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MoskalevSO.Sprint4.Task1.V8.Lib
{
    public class DataService : ISprint4Task1V8
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                if (item % 2 != 0)
                {
                    sum += item;
                }
            }
            return sum;
        }
    }
}