// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(0, n);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
}
int [,] EvenElementToSquare(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i=i+2)
    {
        for (int j = 0; j < array.GetLength(1); j=j+2)
        {
            array[i,j] = array[i,j]*array[i,j];
        }
        Console.WriteLine();
    }
    return array;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[,] array = GetArray(m,n);
EvenElementToSquare(array);
PrintArray(array);