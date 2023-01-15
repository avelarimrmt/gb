int m = InputNumber("значение M");
int n = InputNumber("значение N");
PrintNumber(SumAllNaturalNumbers(m, n));

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

int SumAllNaturalNumbers(int a, int b)
{
    if (a == b)
        return b;
    
    return b + SumAllNaturalNumbers(a, b-1);
}

void PrintNumber(int num)
{   
    Console.Write("Сумма натуральных элементов в промежутке от M до N: ");
    Console.Write(num);
}