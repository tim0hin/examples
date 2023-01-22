// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

string Fibonacci(int N)
{
    int one = 0;
    int two = 1;
    string answer = one + ", " + two;

    for(int i = 0; i < N; i++)
    {
        int temp = one;
        one = two;
        two += temp;
        answer += ", " + two;
    }
    return answer;
}

int N = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Fibonacci(N));