// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillArray(int[,] array)
{
    Random rand = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 6);
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

int[,] ProductMatrix(int[,] matr1, int[,] matr2)
{
    int[,] productMatrix = new int[matr1.GetLength(0),matr1.GetLength(1)];

    for(int i = 0; i < matr1.GetLength(0); i++)
    {
        for(int j = 0; j < matr1.GetLength(1); j++)
        {
            for(int k = 0; k < matr1.GetLength(0); k++)
            {
                productMatrix[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return productMatrix;
}

int m = 2;
int n = 2;
int[,] matr1 = new int[m, n];
int[,] matr2 = new int[m, n];
FillArray(matr1);
FillArray(matr2);
PrintArray(matr1);
PrintArray(matr2);
System.Console.WriteLine("Результирующая матрица: ");
PrintArray(ProductMatrix(matr1, matr2));