// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double InputValue(string message)
{
    System.Console.Write(message);
    double value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double FindDistance(double Xa, double Ya, double Za, double Xb, double Yb, double Zb)
{
    return Math.Sqrt(Math.Pow(Xb-Xa,2)+Math.Pow(Yb-Ya,2)+Math.Pow(Zb-Za,2));
}

System.Console.WriteLine("Введите координаты точки A: ");
double Xa = InputValue("Xa = ");
double Ya = InputValue("Ya = ");
double Za = InputValue("Za = ");

System.Console.WriteLine("Введите координаты точки B: ");
double Xb = InputValue("Xb = ");
double Yb = InputValue("Yb = ");
double Zb = InputValue("Zb = ");

System.Console.WriteLine($"Дистанция между точками = {Math.Round(FindDistance(Xa,Ya,Za,Xb,Yb,Zb),2)}");