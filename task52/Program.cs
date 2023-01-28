// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            System.Console.Write(string.Format("{0, 3}", array[i, j]));
        }
        System.Console.WriteLine();
    }
    Console.WriteLine();
}

void Avg(int[,] array)
{
    double sum = 0;
    double avg = 0;
    string result = "Среднее арифметическое каждого столбца:";

    for(int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        avg = sum / array.GetLength(0);
        
        if(j != array.GetLength(1)-1)
            result += " " + Math.Round(avg, 1) + ";";
        else
            result += " " + Math.Round(avg, 1) + ".";
    }
    System.Console.WriteLine(result);
}

int m = 3;
int n = 4;
int[,] array2D = new int[m,n];
FillArray(array2D);
PrintArray(array2D);
Avg(array2D);