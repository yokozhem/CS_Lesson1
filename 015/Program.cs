// 15. С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

System.Console.WriteLine("Введите любое целое число");
int number=Convert.ToInt32(Console.ReadLine());
int digital=(number/100)%10;


if(number<=99)
{
    System.Console.WriteLine("Третья цифра вашего числа NO");
    
}
else
{
    System.Console.WriteLine($"Третья цифра вашего числа {digital}");
}
