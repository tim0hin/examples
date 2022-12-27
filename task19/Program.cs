// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool Polindrom(int num)
{
    string numStr = Convert.ToString(num);
    bool polindrom = false;

    for (int i = 0; i < numStr.Length/2; i++)
    {
            if (numStr[i] == numStr[numStr.Length-1-i]) polindrom = true;
            else polindrom = false;
    }
    return polindrom;
}

int number = 0;

do
{  
    System.Console.Write("Введите пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}while (Convert.ToString(number).Length != 5);

System.Console.WriteLine($"This is polindrom - {Polindrom(number)}");