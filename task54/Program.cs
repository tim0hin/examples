// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortArray(int[,] array)
{
    int temp = 0;

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] >= array[i, k - 1])
                {
                    temp = array[i, k - 1];
                    array[i, k - 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int m = 3;
int n = 4;
int[,] array2D = new int[m,n];
FillArray(array2D);
PrintArray(array2D);
System.Console.WriteLine();
SortArray(array2D);
PrintArray(array2D);
