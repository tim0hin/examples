// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputNumber(string message)
{
    System.Console.Write(message);
    
    int number = Convert.ToInt32(Console.ReadLine());

    if(number < 0)
    {
        System.Console.WriteLine("Число должно быть неотрицательным!");
        InputNumber(message);
    }
    
    return number;
}

int Akkerman(int m, int n)
{
    if(m == 0)
        return n + 1;
    else if ((m != 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = InputNumber("Введите число m = ");
int n = InputNumber("Введите число n = ");
int a = Akkerman(m, n);

System.Console.WriteLine($"A(m,n) = {a}");

