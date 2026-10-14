using Tyuiu.MoskalevSO.Sprint4.Task1.V8.Lib;

DataService ds = new DataService();

int[] array = new int[12];

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Элемент [" + i + "] (от 2 до 9): ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Массив: " + string.Join(", ", array));
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Сумма нечётных элементов: " + ds.Calculate(array));
Console.WriteLine("***************************************************************************");
Console.ReadKey();