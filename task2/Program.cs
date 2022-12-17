// Напишите программу, которая на входе принимает два числа и выдает, какое число большее, а какое меньшее.

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max,min;

if (a<b)
{

    max = b;
    min = a;

}
else
{

    max = a;
    min = b;

}

System.Console.WriteLine(max + " - это число большее");
System.Console.WriteLine(min + " - это число меньшее");
