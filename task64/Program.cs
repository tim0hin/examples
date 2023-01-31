// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int InputNumber(string message)
{
    System.Console.Write(message);
    
    int n = Convert.ToInt32(Console.ReadLine());
    
    return n;
}

void PrintN(int n)
{
    if(n == 1)
    {
        System.Console.Write($"{n}");
        return;
    }
    else
        System.Console.Write($"{n}, ");

    PrintN(n-1); 
}

int n = InputNumber("Введите число N = ");

PrintN(n);