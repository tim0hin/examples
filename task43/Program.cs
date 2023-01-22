// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double EnteringPoint(string message)
{
    System.Console.Write(message);
    double point = Convert.ToDouble(Console.ReadLine());
    return point;
}

void CrossPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

    if(k1 == k2) System.Console.WriteLine("Прямые параллельны!");
    else System.Console.WriteLine($"Точка пересечения двух прямых ({x}; {y})");
}

double b1 = EnteringPoint("Введите b1 = ");
double k1 = EnteringPoint("Введите k1 = ");
double b2 = EnteringPoint("Введите b2 = ");
double k2 = EnteringPoint("Введите k2 = ");

CrossPoint(b1, k1, b2, k2);