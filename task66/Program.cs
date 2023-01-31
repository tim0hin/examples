// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int InputNumber(string message)
{
    System.Console.Write(message);
    
    int number = Convert.ToInt32(Console.ReadLine());
    
    return number;
}

int SumOfNaturalsElements(int sum, int m, int n)
{
    if(m == n)
        return sum += m;
    else if(m > n)
    {
        System.Console.WriteLine("Неверный интервал! M не должно быть больше, чем N!");
        return -1;
    }
    else
    {
        sum += m;
        m++;
        return SumOfNaturalsElements(sum, m, n);
    }
}

int m = InputNumber("Введите число M = ");
int n = InputNumber("Введите число N = ");
int sum = 0;

sum = SumOfNaturalsElements(sum, m, n);

if(sum != -1)
    System.Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sum}");

