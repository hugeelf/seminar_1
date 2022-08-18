/*

Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да


*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{array[i]} ");
    }
    return array;
}

int SearchNumber(int [] array, int searchableNumber)
{   int answer = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i] == searchableNumber)
        {
            answer = 1;
        }
    }
    return answer;
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine();
int answer = SearchNumber(array, 4);
if(answer == 1)
{
    Console.WriteLine("Такое число есть");
}
else
{
    Console.WriteLine("Такого числа нет");
}