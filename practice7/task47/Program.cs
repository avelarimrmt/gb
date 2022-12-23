const int M = 3;
const int N = 4;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;

double[,] arr = randArray(M, N, LEFT_RANGE, RIGHT_RANGE);
PrintArray(arr);

double[,] randArray(int M, int N, int leftRange, int rightRange)
{   
    double[,] array = new double[M, N];
    Random rand = new Random();

    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++ )
        {
        array[i, j] = Math.Round(rand.Next(leftRange, rightRange) + rand.NextDouble(), 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{   

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            Console.Write(array[i,j] + " ");
        }

        Console.WriteLine();
    }
}
