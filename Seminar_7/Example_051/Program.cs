// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


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

int DiagonalSum (int [,] array)
{   int result = 0;
    for(int i=0; i< array.GetLength(0); i++)
    {
        result = result+array[i,i];
        Console.Write($"{array [i,i]}+ ");
    }
    Console.Write($"= {result}");
    return result;
}

int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[,] array = GetArray(m,n);
DiagonalSum(array);