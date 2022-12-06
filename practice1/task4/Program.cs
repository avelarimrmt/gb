Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());

int max;

if (number1 > number2)
    if (number1 > number3)
    max = number1;
    else max = number3;
else if (number2 > number3)
    max = number2;
    else max = number3;
    
Console.WriteLine(max);