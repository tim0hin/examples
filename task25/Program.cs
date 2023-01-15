// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double InputNumber(string message)
{
    System.Console.Write(message);
    
    double number = Convert.ToInt32(Console.ReadLine());
    
    return number;
}

double DegreeOfNumber(double A, double B)
{
    double degree = 0;
    
    //double degree = Math.Pow(A, B);   //сначала было так, а потом увидел, что по условию нужен цикл.

    for (int i = 0; i <= B; i++) degree = Math.Pow(A, i);

    return degree;
}

double A = InputNumber($"Введите число А: ");
double B = InputNumber($"Введите число B: ");

System.Console.WriteLine($"Натуральная степень числа {A} = {DegreeOfNumber(A, B)}");