// Напишите программу, которая принимает число и выдаёт его квадрат

Console.Clear();

Console.Write("ВВедите число: ");
int number = int.Parse(Console.ReadLine()!);

int sqr = number * number;

int sqr1 = Convert.ToInt32(Math.Pow(number, 2));

Console.WriteLine($"Квадрат числа {number} равен {sqr}");
Console.WriteLine($"Квадрат числа {number} равен {sqr1}");