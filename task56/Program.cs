// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
{
    Random rand = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(string.Format("{0, 3}", array[i, j]));
        }
        System.Console.WriteLine();
    }
    Console.WriteLine();
}

int[] SumOfString(int[,] array)
{
    int[] sumStrings = new int[array.GetLength(0)];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sumStrings[i] += array[i, j];
        }
    }
    System.Console.WriteLine(String.Join(",", sumStrings));
    return sumStrings;
}

void MinStringOfArray(int[] array)
{
    int indexOfMin = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < array[indexOfMin])
        {
            indexOfMin = i;
        }
    }

    System.Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {indexOfMin}");
}

int m = 3;
int n = 4;
int[,] array2D = new int[m,n];
FillArray(array2D);
PrintArray(array2D);
System.Console.WriteLine();
MinStringOfArray(SumOfString(array2D));