using Tyuiu.MoskalevSO.Sprint4.Task0.V22.Lib;

DataService ds = new DataService();

int[] valueArray = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Массив: " + string.Join(", ", valueArray));
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Сумма нечётных элементов: " + ds.GetSumOddArrEl(valueArray));
Console.WriteLine("***************************************************************************");
Console.ReadKey();