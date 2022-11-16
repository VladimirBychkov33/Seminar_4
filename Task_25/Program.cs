// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

int NumDegree(int number)
{
    
    int count = 0;
    int result = 1;
    while(count < num2)
    {
        result = result * num1;   // после каждого счетчика result перезаписывается
        count++;
        Console.Write($"{result} ");
    }
    Console.WriteLine();
    return result;
}

Console.WriteLine($"Число {num1} в степени {num2} будет равно {NumDegree(num1)}");

