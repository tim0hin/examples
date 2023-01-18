// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetSizeOfArray(string message)
{
    System.Console.Write(message);
    int size = Convert.ToInt32(System.Console.ReadLine());
    return size;
}

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {  
        array[i] = new Random().Next(100,1000);
    }

    return array;
}

int CountOfEven(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    return count;
}

int size = GetSizeOfArray("Введите размер массива: ");
int[] array = new int[size];
FillArray(array);
System.Console.WriteLine(String.Join(", ", array));
System.Console.WriteLine($"Количество четных чисел в массиве = {CountOfEven(array)}");