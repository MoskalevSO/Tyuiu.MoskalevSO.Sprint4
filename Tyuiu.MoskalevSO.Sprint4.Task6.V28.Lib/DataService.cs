using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MoskalevSO.Sprint4.Task6.V3.Lib
{
    public class DataService : ISprint4Task6V3
    {
        public int Calculate(string[] array)
        {
            string[] found = Array.FindAll(array, s => s.Length < 6);
            return found.Length;
        }
    }
}