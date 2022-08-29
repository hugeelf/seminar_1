/*Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, 
если это невозможно, программа должна вывести сообщение для пользователя.
*/


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
void IsItPossible(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine($"Смена невозможна");
    }
    else 
    {
         Console.WriteLine($"Смена возможна");
    }

}

int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i <array.GetLength(0) ; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}




int rowNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int columnNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[,] array = FillArray(rowNumber, columnNumber);
IsItPossible(array);
ChangeArray(array);
PrintArray(array);


