// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillArray(int[,,] array)
{
    int[] ArrayForFillArray3D = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    ArrayOfRandomNumbers(ArrayForFillArray3D);

    int count = 0;
    int number = ArrayForFillArray3D[0];
    
    for(int k = 0; k < array.GetLength(2); k++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j, k] = number;
                count++;
                if(count == ArrayForFillArray3D.Length)
                    return;

                number = ArrayForFillArray3D[count];
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write(string.Format("{0, 3}", array[i, j, k]) + $"({j},{k},{i})");
            }
            System.Console.WriteLine();
        }
    }
    Console.WriteLine();
}

void ArrayOfRandomNumbers(int[] array)
{
    Random rnd = new Random();
    array[0] = rnd.Next(10, 100);

    for(int i = 1; i < array.Length; i++)
    {
        array[i] = rnd.Next(10, 100);
        for(int j = 0; j < i; j++)
        {
            while(array[i] == array[j])
            {
                array[i] = rnd.Next(10, 100);
                j = 0;
            }
        }
    }
}

int x = 2;
int y = 2;
int z = 2;
int[,,] array3D = new int[x, y, z];
FillArray(array3D);
PrintArray(array3D);