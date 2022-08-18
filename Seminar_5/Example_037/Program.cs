// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int GetNewArraySize(int[] array)
{
    int result = 0;
    if (array.Length % 2 == 0)
    {
        result = array.Length / 2;
    }
    else
    {
        result = array.Length / 2 + 1;
    }
    return result;
}

int[] GetNewArrayFromArray(int[] array, int newArraySize)
{
    int[] newArray = new int[newArraySize];
    Console.Write($"Элементы нового массива [");
    for (int i = 0; i < newArraySize - 1; i++)
    {
        newArray[i] = array[i] * array[array.Length - i - 1];
        Console.Write($" {newArray[i]}");
    }
    if (newArraySize % 2 != 0)
    {
        newArray[newArraySize - 1] = array[newArraySize - 1];
        Console.Write($" {newArray[newArraySize - 1]}");
    }
    Console.Write($" ]");
    return newArray;
}

int[] array = GetArray(9, 0, 9);
Console.WriteLine();

int newArraySize = GetNewArraySize(array);
Console.WriteLine($"количество элементов в новом массиве = {newArraySize}");
Console.WriteLine();
GetNewArrayFromArray(array, newArraySize);


