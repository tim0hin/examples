// Напишите программу, которая на вход принимает число (N), а на выходе
// показывает все четные числа от 1 до N.

System.Console.Write("Введите число N: ");

int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < N; i++)
{

    int parity = i % 2;

    if (parity == 0) System.Console.Write(i + " ");

};