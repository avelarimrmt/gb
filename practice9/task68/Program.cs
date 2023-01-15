int m = InputNumber("значение M");
int n = InputNumber("значение N");

Console.WriteLine($"A({m},{n}) = {AckermanFunction(m, n)}");

int InputNumber(string text)
{
    int number;
    
    while (true)
    {
        Console.WriteLine($"Введите {text}");
        if (int.TryParse(Console.ReadLine(), out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз");

    }

    return number;
}

int AckermanFunction(int a, int b)
{
    if (a == 0)
        return b + 1;
    if (a > 0 && b == 0)
        return AckermanFunction(a - 1, 1);
    else
        return AckermanFunction(a - 1, AckermanFunction(a, b - 1));
}