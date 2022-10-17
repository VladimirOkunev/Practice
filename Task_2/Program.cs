// Программа, которая на вход принимает два числа
// и выдает, какое число меньше, а какое больше

Console.Clear();

Console.Write("Enter the first number: ");
int NumA = Convert.ToInt32(Console.ReadLine());


Console.Write("Enter the second number: ");
int NumB = Convert.ToInt32(Console.ReadLine());


// Вывод собощения когда числа равны
if (NumA == NumB)
{
    Console.WriteLine("The numbers are equal");
}
else
{
    // Определение наименьшего и наибольшего числа и вывод
// соответствующего сообщения
if (NumA > NumB)
{
    Console.WriteLine($"Maximum number: {NumA}");
    Console.WriteLine($"Minimum number: {NumB}");
}
else
{
    Console.WriteLine($"Maximum number: {NumB}");
    Console.WriteLine($"Minimum number: {NumA}");
}
}

