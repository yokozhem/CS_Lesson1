// 13.Удалить вторую цифру целого числа введенного с клавиатуры.

int a, b,c,d;
System.Console.WriteLine("Введит любое целое число");
a=Convert.ToInt32(Console.ReadLine());
b=a%10;
c=a/10%10;
d=a/100;

System.Console.WriteLine($"{d} {b}");
