﻿int[] arr = randArray();
Console.WriteLine(string.Join(", ", arr));

int[] randArray()
{   
    int[] array = new int[8];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0,99);
    }

    return array;
}