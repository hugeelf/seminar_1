//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int [] ReverseArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length-1-i];
        Console.Write($"{result[i]} ");
    }
    return result;
}

int [] array = GetArray(8,1,9);
Console.WriteLine();
Console.WriteLine(String.Join("", array));
ReverseArray(array);