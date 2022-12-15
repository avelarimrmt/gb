int[] arr = randArray(4, 100 , 1000);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine(CountEvenNumbers(arr));

int[] randArray(int size, int leftRange, int rightRange)
{   
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange,rightRange);
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