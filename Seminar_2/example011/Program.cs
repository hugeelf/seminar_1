/*
11. Напишите программу, которая выводит случайное трехзначное число 
и удалет вторую цифру этого числа
456 -> 46
782-> 72 
918 -> 98
*/

int GetRandomNumberInRange(int minNumber, int maxNumber) // определили функцию
{
    int result = new Random().Next(minNumber, maxNumber + 1);
    return result;
}


int GetDigitsWithoutSecond (int number)
{

    int firstDigit = number/100; //Получаем первую цифру
    int secondDigit = number%10; //получаем последнюю цифру
    int finalNumber = firstDigit*10+secondDigit;
    return finalNumber;
}

int randomNumber =  GetRandomNumberInRange(100,999);// трехзначное число, случайное, вызвали функцию
Console.WriteLine(randomNumber);
int newNumber = GetDigitsWithoutSecond(randomNumber);
Console.WriteLine($"новое число {newNumber}");
 