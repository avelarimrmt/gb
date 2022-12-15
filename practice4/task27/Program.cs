int number = InputNumber();
Console.WriteLine(Sum(number));

int InputNumber()
{
    string str;
    int number;
    
    while (true)
    {
        Console.WriteLine("Введите число");
        str = Console.ReadLine();
        if (int.TryParse(str, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз");
    }

    return number;
}

int Sum(int num)
{
    int result = 0;
    string str = num.ToString(); 

    for (int i = 0; i < str.Length; i++)
    {
        result = result + num % 10;
        num = num / 10;
    }

    return result;
}