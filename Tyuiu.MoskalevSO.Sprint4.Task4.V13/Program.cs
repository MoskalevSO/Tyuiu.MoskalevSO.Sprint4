using Tyuiu.MoskalevSO.Sprint4.Task4.V13.Lib;

DataService ds = new DataService();

int[,] matrix = new int[5, 5];

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write("Элемент [" + i + "," + j + "] (от 3 до 7): ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("Массив:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Сумма чётных элементов: " + ds.Calculate(matrix));
Console.WriteLine("***************************************************************************");
Console.ReadKey();