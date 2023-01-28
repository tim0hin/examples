// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

void FillArray(int[ , ] array)
{
    Random rand = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(-10, 10);
        }
    }
}

void PrintArray(int[ , ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(string.Format("{0, 5}", array[i, j]));
        }
        System.Console.WriteLine();
    }
    Console.WriteLine();
}

void GetPosition(int[,] array)
{
    System.Console.Write("Введите позицию элемента (начинается с 0): ");
    int position = Convert.ToInt32(Console.ReadLine());
    int sizeOfArray = (array.GetLength(0) * array.GetLength(1)) - 1;

    if(position > sizeOfArray)
        System.Console.WriteLine("Такого числа нет в массиве!");

    int index = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(index == position)
                System.Console.WriteLine($"Значение элемента = {array[i,j]}");
                
            index++;
        }
    }
}

int m = 3;
int n = 4;
int[,] array2D = new int[m,n];
FillArray(array2D);
PrintArray(array2D);
GetPosition(array2D);

