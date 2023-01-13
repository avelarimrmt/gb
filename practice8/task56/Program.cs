const int M = 4;
const int N = 4;
const int LEFT_RANGE = 1;
const int RIGHT_RANGE = 10;

int[,] arr = randArray(M, N, LEFT_RANGE, RIGHT_RANGE);
PrintTwoDimensionalArray(arr);

int[] arrSumLines = SumElementsLinesArray(arr);
FindMinSumLine(arrSumLines);


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

int[] SumElementsLinesArray(int[,] array)
{
    int[] sumLine = new int[M];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            sumLine[i] += array[i,j];
        }
    }
    return sumLine;
}

void FindMinSumLine(int[] array)
{   
    int minNumber = array[0];
    int minLineNumber = 1;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minNumber)
        {
            minNumber = array[i]; 
            minLineNumber = i + 1;
        }
    }

    Console.WriteLine("Номер строки с наименьшей суммой элементов: " + minLineNumber + " строка");
}