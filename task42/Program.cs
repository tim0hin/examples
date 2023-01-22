// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string NewNumber(int num)
{
    string binary = string.Empty;
    for(; num > 0; num/=2)
    {
        binary += num % 2;
    }
    return FlipOver(binary);
}

string FlipOver(string binary)
{
    string result = string.Empty;
    for(int i = binary.Length-1; i >= 0; i--)
    {
        result += binary[i];
    }
    return result;
}

System.Console.Write("Введите десятичное число: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(NewNumber(num));