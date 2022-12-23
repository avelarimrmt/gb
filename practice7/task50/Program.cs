const int M = 3;
const int N = 4;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;

int[,] arr = randArray(M, N, LEFT_RANGE, RIGHT_RANGE);
PrintArray(arr);

int num1 = InputNumber("позицию 1");
int num2 = InputNumber("позицию 2");

ExistElements(num1, num2, arr);


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

void PrintArray(int[,] array)
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

void ExistElements(int num1, int num2, int[,] arr)
{
    if (num1 > M-1 && num2 > N-1)
        Console.WriteLine("такого числа в массиве нет");
    else 
        Console.WriteLine(arr[num1, num2]);
}