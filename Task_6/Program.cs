// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.Clear();

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number%2 == 0)// определение остатка от деления на ноль
{
    Console.Write("The number is even");
}
else
{
    Console.Write("The number is odd");
}