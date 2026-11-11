using Tyuiu.MoskalevSO.Sprint4.Task5.Lib;

DataService ds = new DataService();

int rows = 5;
int columns = 5;
int[,] matrix = new int[rows, columns];
Random rnd = new Random();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = rnd.Next(-6, 4);
    }
}

Console.WriteLine("***** ИСХОДНЫЕ ДАННЫЕ *****");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(matrix[i, j].ToString().PadLeft(4));
    }
    Console.WriteLine();
}

int[,] result = ds.GetMatrix(matrix);

Console.WriteLine("***** РЕЗУЛЬТАТ *****");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(result[i, j].ToString().PadLeft(4));
    }
    Console.WriteLine();
}

Console.ReadKey();