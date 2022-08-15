/*
Напишите программу, которая 
принимает на вход число (А) и выдаёт сумму чисел 
от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

int getTheSumm(int numberA)
{ int result = 0;
    for (int i = 1; i<=numberA; i++)
    {
        result=result+i;
    }
    return result;
}



Console.WriteLine("Введите число");
int numberA = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"Сумма чисел от 1 до {numberA} = {getTheSumm(numberA)}");