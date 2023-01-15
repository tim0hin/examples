// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray()
{
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
    {  
        array[i] = new Random().Next(1,100);
    }

    return array;
}

System.Console.WriteLine(string.Join(", ", CreateArray()));