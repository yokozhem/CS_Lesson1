﻿// 4. По заданному с клавиатуры номеру дня недели вывести его название

int number;
Console.WriteLine("Введите число от 1 до 7");
number=Convert.ToInt32(Console.ReadLine());
switch (number)

{
                case 1: Console.WriteLine("Понедельник"); break;
                case 2: Console.WriteLine("Вторник"); break;
                case 3: Console.WriteLine("Среда"); break;
                case 4: Console.WriteLine("Четверг"); break;
                case 5: Console.WriteLine("Пятница"); break;
                case 6: Console.WriteLine("Суббота"); break;
                case 7: Console.WriteLine("Воскресение"); break;
                default: Console.WriteLine("Такого дня не существует"); break;
            }
