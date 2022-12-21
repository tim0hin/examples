// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

int a = new Random().Next(100,1000);
System.Console.WriteLine(a);

int secondDigit = a / 10 % 10;

System.Console.WriteLine(secondDigit);


