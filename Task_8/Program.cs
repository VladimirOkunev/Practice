﻿// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 0;

while(count < number-1) // цикл вывода четных чисел
{
    count=count + 2;
    Console.Write($"{count}  ");
}