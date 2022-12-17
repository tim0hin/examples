// Напишите программу, которая на вход принимает число и выдает,
// является ли число четным (делится ли оно на два без остатка).

System.Console.WriteLine("Введите число для проверки четности: ");

int number = Convert.ToInt32(Console.ReadLine());

int result = number % 2;

if (result == 0)
{
    System.Console.WriteLine(number + " - четное число");
}
else
{

    System.Console.WriteLine(number + " - нечетное число");

};