using Tyuiu.MoskalevSO.Sprint4.Task3.V15.Lib;

DataService ds = new DataService();

int[,] matrix = {
    { 7, 4, 2, 5, 3 },
    { 4, 3, 2, 5, 6 },
    { 6, 3, 4, 7, 5 },
    { 5, 7, 4, 3, 8 },
    { 7, 8, 8, 5, 6 }
};

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
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
Console.WriteLine("Количество нечётных элементов: " + ds.Calculate(matrix));
Console.WriteLine("***************************************************************************");
Console.ReadKey();