// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int FindMinNumber(int[] array)
{
    int min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }
    return min;
}

int FindMaxNumber(int[] array)
{
    int max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }
    return max;
}

int DiffOfMinMax(int min, int max)
{
    int diff = max - min;
    return diff;
}

int[] array = new int[5] {3, 7, 22, 2, 78};
System.Console.WriteLine(String.Join(", ", array));
// System.Console.WriteLine($"Минимальный элемент = {FindMinNumber(array)}");
// System.Console.WriteLine($"Максимальный элемент = {FindMaxNumber(array)}");
System.Console.Write("Разница между максимальным и минимальным элементом массива = ");
System.Console.WriteLine(DiffOfMinMax(FindMinNumber(array),FindMaxNumber(array)));