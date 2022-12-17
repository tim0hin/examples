// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("Введите 3 числа: ");

int[] nums = new int[] {Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};

int max = nums[0];

for (int i = 0; i < nums.Length-1; i++)
{

    if (nums[i] > max) max = nums[i];

}

System.Console.Write("Максимальное число: ");
System.Console.WriteLine(max);