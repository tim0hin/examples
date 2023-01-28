// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int GetSize(string message)
{
    System.Console.Write(message);
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

void FillArray(double[ , ] array)
{
    Random rand = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rand.NextDouble() * 20 - 10, 2);
        }
    }
}

void PrintArray(double[ , ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0, 7}", array[i, j]));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int m = GetSize("Введите количество строк: ");
int n = GetSize("Введите количество столбцов: ");

double[,] array2D = new double[m,n];
FillArray(array2D);
PrintArray(array2D);