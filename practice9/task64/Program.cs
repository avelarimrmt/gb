int n = InputNumber("значение N");
int m = 1;
AllNaturalNumbers(n, m);

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

int AllNaturalNumbers(int a, int b)
{
    if (a == b)
    {
        PrintNumber(b);
        return b;
    }
    else 
        AllNaturalNumbers(a, b+1);

    PrintNumber(b);
    return b;
}

void PrintNumber(int num)
{
    Console.Write(num);

    if (num != m) 
        Console.Write(", ");
}