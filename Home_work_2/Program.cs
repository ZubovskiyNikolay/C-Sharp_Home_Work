﻿// -----------------------------------------Задача 1(10)-----------------------------------

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число");
// int num=Convert.ToInt32(Console.ReadLine());

// int second_num=(num/10)%10;
// Console.WriteLine("Вторая цифра числа - "+second_num);

// -------------------------------------------Задача 2(13)-------------------------------------

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите трехзначное число");
// int num=Convert.ToInt32(Console.ReadLine());
// if (num>=100)
// {
//   while (num>=1000)
//   {
//     num=num/10;
//   }
//   int third_num=num%10;
//   Console.WriteLine("Третья цифра числа - "+third_num);
// }
// else
// {
//   Console.WriteLine("Третьей цифры нет");
// }

// ------------------------------------------Задача 3--------------------------

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет