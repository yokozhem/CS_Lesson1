//12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
int a,b,c,max;

System.Console.WriteLine("Введите число от 10 до 99");
a=Convert.ToInt32(Console.ReadLine());
b=a%10;
c=a/10%10;
max=b;
if(c>b)
{
    max=c;
}
System.Console.WriteLine($"Наибольшая цифра вашего числа {max}");