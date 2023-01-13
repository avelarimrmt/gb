const int ROWS = 2;
const int COLS = 2;
const int LEFT_RANGE = 1;
const int RIGHT_RANGE = 10;

int[,] firstMatrix = randArray(ROWS, COLS, LEFT_RANGE, RIGHT_RANGE);
PrintTwoDimensionalArray(firstMatrix);

Console.WriteLine("-----");

int[,] secondMatrix = randArray(ROWS, COLS, LEFT_RANGE, RIGHT_RANGE);
PrintTwoDimensionalArray(secondMatrix);

int[,] result = MultiplyMatrix(firstMatrix, secondMatrix);
Console.WriteLine("Результирующая матрица:");
PrintTwoDimensionalArray(result);

int[,] randArray(int M, int N, int leftRange, int rightRange)
{   
    int[,] array = new int[ROWS, COLS];
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
            Console.Write(array[i,j] + "   ");
        }

        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[ROWS, COLS];

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++ )
        {
            int temp = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++ )
            {
                temp += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = temp;
        }
    }

    return resultMatrix;
}