// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].

int[] arr = new int[123]; // создали массив 

void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        //Создание объекта для генерации чисел
        Random rnd = new Random();
        //Получить случайное число 
        int value = rnd.Next(1000);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}

void IsNumInArray(int[] array)
{
    int numExist = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 10 && arr[i] < 99)
        {
            numExist++;
        }
    }
    if (numExist > 0)
    {
        Console.WriteLine($"Количество чисел - {numExist}");
    }
    else
    {
        Console.WriteLine($"Чисел нет - {numExist}");
    }
}

RandomArray(arr);
IsNumInArray(arr);
