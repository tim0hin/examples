// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int InputNumber(string message)
{
    System.Console.Write(message);
    
    int Number = Convert.ToInt32(Console.ReadLine());

    return Number;
}

int CountOfNumbers(int number)
{
    int count = 0;

    while (number > 0)
    {
        count++;
        number /= 10;
    }

    return count;
}

int SumOfDigits(int number)
{
    int sum = 0;

    int count = CountOfNumbers(number);

    for (int i = 0; i < count; i++)
    {
        int digit = number % 10;

        sum += digit;

        number /= 10;
    }

    return sum;
}

int number = InputNumber("Введите число: ");

System.Console.WriteLine($"Сумма цифр в числе = {SumOfDigits(number)}");