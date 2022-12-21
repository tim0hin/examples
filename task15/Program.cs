// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

System.Console.Write("Введите день недели (от 1 до 7): ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfWeek < 1 || dayOfWeek > 7) 
    System.Console.WriteLine("Число не обозначает день недели!");
else if (dayOfWeek == 6 || dayOfWeek == 7)
    System.Console.WriteLine("Да");
else
    System.Console.WriteLine("Нет");