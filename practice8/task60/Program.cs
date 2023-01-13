const int M = 2;
const int N = 2;
const int B = 2;
const int LEFT_RANGE = 10;
const int RIGHT_RANGE = 100;

int[,,] arr = randArray(M, N, B, LEFT_RANGE, RIGHT_RANGE);
PrintThreeDimensionalArray(arr);

int[,,] randArray(int M, int N, int B, int leftRange, int rightRange)
{   
    int[,,] array = new int[M, N, B];
    Random rand = new Random();

    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++ )
        {
            for (int k = 0; k < B; k++ )
            {
                array[i, j, k] = rand.Next(leftRange, rightRange);
            }
        }
    }
    return array;
}

void PrintThreeDimensionalArray(int[,,] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            for (int k = 0; k < array.GetLength(2); k++ )
            {
                Console.Write(array[i,j,k] + $"({i}, {j}, {k})" + "   ");
            }
        }
        Console.WriteLine();
    }
}