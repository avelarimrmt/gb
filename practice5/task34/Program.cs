int[] arr = randArray();
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine(CountEvenNumbers(arr));

int[] randArray()
{   
    int[] array = new int[4];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0,300);
    }

    return array;
}

int CountEvenNumbers(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) 
            count++;
    }

    return count;
}