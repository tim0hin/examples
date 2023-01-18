// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,100);
    }
    return array;
}

int FindSummOfElementsOddIndex(int[] array)
{
    int summ = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) summ += array[i];
    }
    return summ;
}

int[] array = new int[4];
FillArray(array);
System.Console.WriteLine("Массив:");
System.Console.WriteLine(String.Join(", ", array));
System.Console.WriteLine($"Сумма элементов с нечетным индексом = {FindSummOfElementsOddIndex(array)}");