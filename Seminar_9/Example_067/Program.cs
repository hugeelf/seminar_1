// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9




int SumOfDigits(int b)
{
    if (b == 0) return 0;
    else return b % 10 + SumOfDigits(b / 10);
}



int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(SumOfDigits(b));