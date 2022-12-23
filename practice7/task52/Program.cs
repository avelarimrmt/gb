const int M = 3;
const int N = 4;
const int LEFT_RANGE = 1;
const int RIGHT_RANGE = 4;

int[,] arr = randArray(M, N, LEFT_RANGE, RIGHT_RANGE);
PrintTwoDimensionalArray(arr);

double[] average = FindArithmeticMean(arr);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
PrintOneDimensionalArray(average);

double[] FindArithmeticMean(int[,] array)
{
    double[] average = new double[N];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            average[j] += array[i, j];
            if (i == array.GetLength(0) - 1)
                average[j] /= array.GetLength(0);
        }
    }
    return average;
}

int InputNumber(string text)
{
    int number;
    
    while (true)
    {
        Console.WriteLine($"Введите {text}");
        if (int.TryParse(Console.ReadLine(), out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз");
    }

    return number;
}

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

void PrintOneDimensionalArray(double[] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {
            Console.Write(Math.Round(array[i], 2) + " ");
    }
}