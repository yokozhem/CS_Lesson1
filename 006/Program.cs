//6. Написать программу вычисления значения функции y = sin(a). (Класс Math). 

double a, y;
System.Console.WriteLine("Введите чиислов a: ");
a=Convert.ToDouble(Console.ReadLine());
y=Math.Sin(a);

System.Console.WriteLine($"sin от числа {a} равен {y}");
