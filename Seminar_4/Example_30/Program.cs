/*

Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]


*/

void RandomArray(int[] array, int arrayLength)
{
    for (int i=0; i < arrayLength; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write($"{array[i]}");
    }
} 

Console.WriteLine("Введите размер массива");
int arrayLength = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] array = new int[arrayLength];
//int[] array =  {};
RandomArray(array, arrayLength);

//У меня не работает микрофон, но добавил возможность указания размера массива.