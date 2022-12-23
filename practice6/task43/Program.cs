double b1 = InputNumber("b1");
double k1 = InputNumber("k1");
double b2 = InputNumber("b2");
double k2 = InputNumber("k2");

IntersectionPoint(b1, k1, b2, k2, out double x, out double y);

Console.WriteLine("Точка пересечения прямых: " + "(" + Math.Round(x, 3) + ";" + Math.Round(y, 3) + ")");

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

void IntersectionPoint(double b1, double k1, double b2, double k2, out double x, out double y)
{
    x = (b2 - b1)/(k1 - k2);
    y = k1 * x + b1;
}