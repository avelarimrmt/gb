Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number/100 != 0 && number/1000 == 0)
    Console.WriteLine(number%100/10);