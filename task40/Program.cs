// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// ❗ Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int InputNumber(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool Triangle(int a, int b, int c)
{
    if(a < b + c) return true;
    else return false;
}

int a = InputNumber("Введите число A: ");
int b = InputNumber("Введите число B: ");
int c = InputNumber("Введите число C: ");

System.Console.WriteLine($"Is it a triangle? {Triangle(a,b,c)}.");
