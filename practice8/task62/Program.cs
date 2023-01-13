const int N = 4;

int[,] matrix = fillSpiralArray(N);
PrintTwoDimensionalArray(matrix);

int[,] fillSpiralArray(int N)
{   
    int[,] array = new int[N, N];
    
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++ )
        {
            int directionRing = (j - i + N)/N;
            int temp = i + j + 1;
            array[i, j] = temp * directionRing + Math.Abs(directionRing - 1) * ((4*N - 2 - temp)); //заполнение внешнего кольца
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
            if (array[i,j] / 10 == 0)
            Console.Write(array[i,j] + "   ");
            else
            Console.Write(array[i,j] + "  ");
        }

        Console.WriteLine();
    }
}