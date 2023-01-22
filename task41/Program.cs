// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

string EnteringNumbers(string message)
{
    System.Console.Write(message);
    string numbers = Console.ReadLine();
    return numbers; 
}

int[] StringIntoArray(string stringNumbers)
{
    int arrayLength = stringNumbers.Length;
    int[] array = new int[arrayLength];

    array = stringNumbers.Split(' ').Select(int.Parse).ToArray();

    return array;    
}

int NumberOfPositive(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }

    return count;
}

string inputString = EnteringNumbers("Введите числа через пробел: ");
int[] array = StringIntoArray(inputString);

System.Console.WriteLine($"Количество чисел больше 0 = {NumberOfPositive(array)}");