// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int InputSize(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1,10);
    }
}

int[] CopyArray(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}

int size = InputSize("Введите размер массива: ");
int[] array = new int[size];
FillArray(array);
// int[] array2 = array;    //ссылка array2 на array
System.Console.WriteLine(String.Join(", ", array));
int[] array2 = CopyArray(array);
// array[0] = 43;
System.Console.WriteLine(String.Join(", ", array2));