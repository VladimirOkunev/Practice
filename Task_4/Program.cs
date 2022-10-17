// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

Console.Write("Enter the first number: ");
int NumA = int.Parse(Console.ReadLine( ));

Console.Write("Enter the second number: ");
int NumB = int.Parse(Console.ReadLine( ));

Console.Write("Enter the third number: ");
int NumC = int.Parse(Console.ReadLine( ));

int max = NumA; //присвоение максимального числа по умолчанию

if(NumA==NumB && NumA==NumC)
{
Console.Write("All numbers are equal");
}
else
{
if (NumB > max)// определение максимального числа
{
    max = NumB;
}

if (NumC > max)
{
    max = NumC;
}
Console.Write($"Maximum number: {max}"); // вывод максимального числа на экран
}