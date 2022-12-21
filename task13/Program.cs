// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int a = Convert.ToInt32(Console.ReadLine());

string number = Convert.ToString(a);
if (number.Length < 3)
    System.Console.WriteLine("Нет третьей цифры!");
else
    System.Console.WriteLine(number[2]);