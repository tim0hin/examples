int N = 10;
int sum = 1;
int per = 1;

for (int i=1; i<=N; i++ )
{
    sum = sum*2;
    per = per+sum;
}
System.Console.WriteLine(per);