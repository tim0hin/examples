// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

void FillArray(int[ , ] array)
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

void PrintArray(int[ , ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0, 5}", array[i, j]));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumElementsOnMainDiagonal(int[ , ] array)
{    
    int sum = 0;

    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {  
        sum += array[i, i];
    }
    Console.WriteLine("Сумма элементов главной диагонали = " + sum + "\n");
}

void SumElementsOnAditionalDiagonal(int[ , ] array)
{    
    int sum = 0;
    int a = 0;
    int b = array.GetLength(1) - 1;

    for (; a < array.GetLength(0) && b >= 0; a++, b--)
    { 
        sum += array[a, b];
    }
    Console.WriteLine("Сумма элементов побочной диагонали = " + sum + "\n");
}

int[ , ] array = new int[8, 5];

FillArray(array);
PrintArray(array);
SumElementsOnMainDiagonal(array);
SumElementsOnAditionalDiagonal(array);