/*

Напишите программу, которая принимает 
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5


*/

int HowMuchIsTheDigits(int number)
{
    int digitCounter = 0;
    while (number != 0)
    {
        number = number / 10;
        digitCounter++;
        //Console.WriteLine(number);
        //Console.WriteLine(digitCounter);
    }
    return digitCounter;
}


Console.WriteLine("Введите число");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"Количество цифр в числе {number} = {HowMuchIsTheDigits(number)}");
