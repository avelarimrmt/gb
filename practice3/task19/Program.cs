Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();
int size = str.Length;
bool isPalindrom = true;

if (size == 5)
{
    for (int i = 0; i < size/2; i++)
    {
        if (str[i] != str[size - i - 1]) 
            isPalindrom = false;
    }

    if (isPalindrom) 
        Console.WriteLine("да");
    else 
        Console.WriteLine("нет");
}
else 
    Console.WriteLine("Введено не пятизначное число");