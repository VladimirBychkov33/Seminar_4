// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
Console.Clear();
int[]massiv = new int[8]; 
int[]Array(int[]Mas) 
{
    for (int i = 0; i < Mas.Length; i++)
    {
        Mas[i]= new Random().Next(0,101); 
        Console.Write($"{Mas[i]} ");
    }
    return Mas;
}
Array(massiv);



