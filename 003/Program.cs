// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// С клавиатуры вводятся два числа. Найти и вывести на экран максимальное из них
int a,b,max;
Console.WriteLine("Введите a: ");
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
b=Convert.ToInt32(Console.ReadLine());
if (a>b)
{
  max=a;
}
else
{
  max=b;
}
System.Console.WriteLine($"max={max}");