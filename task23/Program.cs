// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int InputValue(string message)
{
    System.Console.Write(message);
    
    int value = Convert.ToInt32(Console.ReadLine());
    
    if (value > 0) return value;
    else return InputValue(message);
}

string TableOfCubes(int N)
{
    string strCubes = string.Empty;
    for (int i = 1; i <= N; i++)
        if (i == N) strCubes+=Math.Pow(i,3);
        else strCubes = strCubes + Math.Pow(i,3) + ", ";
    return strCubes;
}

int N = InputValue("Введите число N: ");

System.Console.WriteLine($"Таблица кубов числа N: \n {TableOfCubes(N)}");