// 10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

int a,b;

System.Console.WriteLine("Введите любое число ");
a=Convert.ToInt32(Console.ReadLine());
b=a%10;
System.Console.WriteLine($"Последняя цифра числа {a}: {b}");

