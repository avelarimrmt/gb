int number = InputNumber();
Console.WriteLine(Sum(number));

int InputNumber()
{
    int number;
    
    while (true)
    {
        Console.WriteLine("Введите число");
       
        if (int.TryParse(Console.ReadLine(), out number))
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