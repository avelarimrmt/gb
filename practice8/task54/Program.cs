const int M = 3;
const int N = 4;
const int LEFT_RANGE = 1;
const int RIGHT_RANGE = 10;

int[,] arr = randArray(M, N, LEFT_RANGE, RIGHT_RANGE);
PrintTwoDimensionalArray(arr);

SortDescending(arr);

Console.WriteLine();
PrintTwoDimensionalArray(arr);


int[,] randArray(int M, int N, int leftRange, int rightRange)
{   
    int[,] array = new int[M, N];
    Random rand = new Random();

    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++ )
        {
        array[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return array;
}

void PrintTwoDimensionalArray(int[,] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            Console.Write(array[i,j] + "    ");
        }

        Console.WriteLine();
    }
}

void SortDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++ )
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int x = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = x;
                }
            }
        }
    }
}