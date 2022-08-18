

/*

Задайте масив из 12 элементов, заполните случайными числами из промежутка, 
Зайдите сумму отрицательных и положительных элементов.

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

int[] array = GetArray(12, -9, 9);
int positiveSum = 0;
int negativeSum = 0;

foreach (int i in array) // Для каждошо элемента (i) в (array)
{
    if (i > 0)
        positiveSum += i;
    else
        negativeSum += i;
}
Console.WriteLine($"Сумма положительных = {positiveSum}, а сумма отрицительных = {negativeSum}" );