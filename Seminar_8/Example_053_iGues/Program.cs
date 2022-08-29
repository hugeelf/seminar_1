
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.





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

int [,] ChangeArrayRows(int[,] array, int changeableRow, int rowNumber, int columnNumber)
{
    int[] tempArray = new int[columnNumber];
    for (int i = changeableRow-1; i<changeableRow; i++)
        {
            for (int j = 0; j<columnNumber; j++)
            {
                tempArray [j] = array[changeableRow-1, j];
                array[changeableRow-1, j] = array[rowNumber-1, j];
                array[rowNumber-1, j] = tempArray[j];

            }
        }
    
    return array;
}
void PrintArray(int[,] newArray)
{
    for (int i = 0; i <newArray.GetLength(0) ; i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write($"{newArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}


int rowNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int columnNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[,] array = FillArray(rowNumber, columnNumber);
Console.WriteLine();
int changeableRow = 1;
int [,] newArray = ChangeArrayRows(array, changeableRow, rowNumber, columnNumber);
PrintArray(newArray);
