using Tyuiu.MoskalevSO.Sprint4.Task2.V15.Lib;

DataService ds = new DataService();

Random rnd = new Random();
int[] array = new int[11];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(2, 8);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Массив: " + string.Join(", ", array));
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Сумма чётных элементов: " + ds.Calculate(array));
Console.WriteLine("***************************************************************************");
Console.ReadKey();