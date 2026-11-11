using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MoskalevSO.Sprint4.Task6.V28.Lib
{
    public class DataService : ISprint4Task6V28
    {
        public string[] Calculate(string[] array)
        {
            string[] result = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                string[] parts = array[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < parts.Length; j++)
                {
                    int value = int.Parse(parts[j]);
                    parts[j] = value < 0 ? "0" : value.ToString();
                }
                result[i] = string.Join(" ", parts);
            }
            return result;
        }
    }
}