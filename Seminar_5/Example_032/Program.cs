/*

Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 

*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{result[i]} ");
    }
    return result;
}
int[] ReverseArray(int[] array)
{   int [] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
        Console.Write($"{array[i]} ");
    }
    return newArray;
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine();
ReverseArray(array);
