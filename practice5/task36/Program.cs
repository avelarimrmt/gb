int[] arr = randArray();
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine(SumOnOdd(arr));

int[] randArray()
{   
    int[] array = new int[4];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-10, 10);
    }

    return array;
}

int SumOnOdd(int[] arr)
{
    int result = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) 
            result = result + arr[i];
    }

    return result;
}