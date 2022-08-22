// Задача 42: Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10




void DecimalToBinary(int decimalDigit)
{   int result = 0;
    while(decimalDigit%10!=0)
    {
        result = decimalDigit%2;
        decimalDigit = decimalDigit/2;
        Console.Write($"{result} ");
    }
}


Console.WriteLine("Введите длину 1 стороны");
int decimalDigit = Math.Abs(Convert.ToInt32(Console.ReadLine()));
DecimalToBinary(decimalDigit);