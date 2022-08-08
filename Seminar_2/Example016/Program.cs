/*
16. Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

string IsASquare(int numberOne, int numberTwo)
{
    if (numberOne / numberTwo == numberTwo | numberTwo / numberOne == numberOne)
    {
        return "Да";
    }
    else
    {
        return "Нет";
    }
}
Console.WriteLine("Введите первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberTwo = Convert.ToInt32(Console.ReadLine());
string isItASquare=IsASquare(numberOne, numberTwo);
Console.WriteLine($"{isItASquare}, большее число - это квадрат меньшего числа");