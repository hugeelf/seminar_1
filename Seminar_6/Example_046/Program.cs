// Задача 45: Напишите программу, которая будет
// создавать копию заданного массива с помощью
// поэлементного копирования.
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
int [] MakeNewArray(int [] array)
{int [] result = new int [array.Length];
    for (int i =0; i<array.Length; i++)
    {
        result[i]=array[i];
        Console.Write($"{result[i]} ");
    }
    return result;
}

int [] array = GetArray(6,1,56);
Console.WriteLine();
int [] newArray = MakeNewArray(array);
Console.WriteLine();
Console.WriteLine(String.Join(" ", newArray));