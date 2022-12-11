int number = InputNumber("число");
int degree = InputNumber("степень");
Console.WriteLine(Pow(number, degree));

int InputNumber(string text)
{
    string str;
    int number;
    
    while (true)
    {
        Console.WriteLine($"Введите {text}");
        str = Console.ReadLine();
        if (int.TryParse(str, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз");
    }

    return number;
}

int Pow(int A, int B)
{
    int result = A;
    for (int i = 1; i < B; i++)
    {
        result *= A;
    }

    return result;
}