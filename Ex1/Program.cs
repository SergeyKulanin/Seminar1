﻿Console.Clear();
Console.Write("Введите A: ");
int number1=int.Parse(Console.ReadLine());
Console.Write("Введите B: ");
int number2=int.Parse(Console.ReadLine());

if(Math.Pow(number2,2)==number1)
{
    Console.WriteLine("A является квадратом B");
}
else
{
    Console.WriteLine("A не является квадратом B");   
}
