// тип переменной <пробел> имя переменной = конвертирование в тип данных переменной + считывание с консоли

int number = Convert.ToInt32(Console.ReadLine());

// возвести число в квадрат
int sqr = number * number;

// возвести в квадрат с помощью класса Math
int sqrMath = Convert.ToInt32(Math.Pow(number, 2));

System.Console.WriteLine(sqrMath);