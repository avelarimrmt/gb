Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i<=N; i++)
{
    if (i%2 == 0)
    {
        Console.Write(i);
        if (i != N && i != N-1) 
            Console.Write(",");
    }
}