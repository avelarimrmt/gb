Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if  (num >= 100)
    {
        char thirdNumber = num.ToString()[2];
        Console.WriteLine(thirdNumber);
    }
else 
    Console.WriteLine("третьей цифры нет");
