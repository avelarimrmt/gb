const int SIZE = 4;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;

double[] arr = randArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine("[" + string.Join("; ", arr) + "]");

FindMinAndMax(arr, out double max, out double min);
Console.WriteLine(DifferenceBtwMinMax(max, min));

double[] randArray(int size, int leftRange, int rightRange)
{   
    double[] array = new double[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.Next(leftRange, rightRange) + rand.NextDouble(), 3);
    }

    return array;
}

void FindMinAndMax(double[] arr, out double maxNumber, out double minNumber)
{   
    minNumber = arr[0];
    maxNumber = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minNumber)
            minNumber = arr[i];
        else maxNumber = arr[i];   
    }
}

double DifferenceBtwMinMax(double maxNumber, double minNumber)
{
    return Math.Round(maxNumber - minNumber, 3);
}