int M = InputNumber("M");

int[] arr = FillArray(M);

Console.WriteLine("Количество чисел больше 0: " + CountPositiveNumbers(arr));

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

int[] FillArray(int M)
{
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        array[i] = InputNumber($"{i+1} число");
    }

    return array;
}

int CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
         if (arr[i] > 0)
         count++;
    }
    return count;
}