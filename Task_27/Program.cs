// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int SumDigit(int number)
{
    int digit = 0;
    while(num > 0)
    {
        digit = digit + num % 10;
        num = num / 10;
        Console.Write($"{digit} ");
    }
    Console.WriteLine();
    return digit;
}
Console.WriteLine($"Сумма цифр в числе {num} равна {SumDigit(num)}");

