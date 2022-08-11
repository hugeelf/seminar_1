/*
Задача 22: Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

int squaresOneToN(int n, int index, int answer)
{
    while (index<=n)
    {
     answer = index*index;
     Console.WriteLine(answer);
     index++;
    }
    return index;
}
int index=1;
int answer=0;
int squares = 0;
Console.WriteLine("Введите число, для которого необходимо построить таблицу квадратов:");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
squares = squaresOneToN(n, index, answer);
