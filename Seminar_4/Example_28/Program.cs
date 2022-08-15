/*

Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N

*/

int getTheMultiply(int numberA)
{ int result = 1;
    for (int i = 1; i<=numberA; i++)
    {
        result=result*i;
    }
    return result;
}



Console.WriteLine("Введите число");
int numberA = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"Произведение чисел от 1 до {numberA} = {getTheMultiply(numberA)}");


// Тут задача из начала семинара, только поменяли знак и начальный result
