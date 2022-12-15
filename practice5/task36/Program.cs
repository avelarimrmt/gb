const int SIZE = 4;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;

int[] arr = randArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine(SumOnOdd(arr));

int[] randArray(int size, int leftRange, int rightRange)
{   
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange);
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