// С клавиатуры вводятся два числа. Найти и вывести на экран их сумму

int a,b,sum;
Console.WriteLine("Введите a: ");
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
b=Convert.ToInt32(Console.ReadLine());
sum=a+b;
//1. Конкатенация (скливание) строк
System.Console.WriteLine(a+"+"+b.ToString()+"="+Convert.ToString(sum));
//2. Форматированный вывод
System.Console.WriteLine("{0:F2}+{1:E5}={2:G4}",a,b,sum);
//3. Интерполяция строк
System.Console.WriteLine($"{a}+{b}={sum}");

