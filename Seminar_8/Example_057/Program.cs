// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] FillArray(int rowNumber, int columnNumber)
{
    int[,] result = new int[rowNumber, columnNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < columnNumber; j++)
        {
            result[i, j] = new Random().Next(1, 20);
            Console.Write($"{result[i, j]} \t");
        }
        Console.WriteLine();
    }
    return result;
}
int[] TempArray(int[,] array)
{
    int [] result = new int[array.GetLength(0) * array.GetLength(1)];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[count] = array[i, j];
            count++;
        }
    }
    return result;
}

int[] ArraySort(int[] result)
{
    for (int i = 0; i < result.Length; i++)
    {
        for (int j = 0; j < result.Length; j++)
            if (result[i] > result[j])
            {
                int temp = result[i];
                result[i] = result[j];
                result[j] = temp;
            }
    }
    return result;
}

void PrintData(int[] result)
{
    int count = 1;
    int firstNumber = result[0];
    for (int i = 1; i < result.Length; i++)
    {
        if (result[i] != firstNumber)
        {
            Console.WriteLine($"{firstNumber} встречается {count} раз.");
            firstNumber = result[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{firstNumber} встречается {count} раз.");
}

int rowNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int columnNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int [,] array = FillArray(rowNumber, columnNumber);
int [] oneDimensionArray =  TempArray(array);
oneDimensionArray = ArraySort(oneDimensionArray);
PrintData (oneDimensionArray);

