Console.Clear();

 Console.Write("ВВедите первое число : ");
int numberA = int.Parse(Console.ReadLine()!);
 Console.Write("ВВедите второе число : ");
int numberB = int.Parse(Console.ReadLine()!);
if (numberB*numberB == numberA)
{
    Console.WriteLine($"Второе число {numberB} является квадратом первого числа {numberA}");
}
else{
     Console.WriteLine($"Второе число {numberB} не является квадратом первого числа {numberA}");
}