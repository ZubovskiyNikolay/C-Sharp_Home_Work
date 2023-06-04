// --------------------------------------Задача 1(19)------------------------------

// Напишите программу, которая на вход принимает
// пятизнаное число и проверяет, является ли оно палиндромом

// 14212 - нет
// 12821 - да
// 23432 - да

// Console.WriteLine("Введите пятизначное число");
// int number = Convert.ToInt32(Console.ReadLine());

// int num1 = number/10000;
// int num2 = number/1000%10;
// int num4 = number/10%10;
//  int num5 = number%10;
// 
//  if (num1 == num5)
//   if (num2 == num4)
//         {
//              Console.WriteLine("Число является палиндромом");
//         }
// }
// else
// {
//     Console.WriteLine("Число не является палиндромом");
// }

// Console.WriteLine("Введите число: ");
// string numText = Console.ReadLine();

// int numLength = numText.Length;

// while (numLength == 5)
// {
//     if (numText[0] == numText[4] && numText[1] == numText[3])
//     {
        
//         Console.WriteLine($"{numText} - Палиндром");
//     } else {
//         Console.WriteLine($"{numText} - Не палиндром");
//     }
//     return;
// }
// Console.WriteLine($"{numText} - Введите 5 чисел!");

// --------------------------------Задача2(21)--------------------------------

//Напишите программу, которая принимает на вход координаты и находит расстояние
// между ними в 3D пространстве 
// А(3,6,8) В(2,1,-7) -> 15,84
// A(7,-5,0) B(1,-1,9) -> 11,53

// Console.WriteLine("Введите первую коордиату X1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первую коордиату Y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первую коордиату Z1");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите вторую коордиату X2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите вторую коордиату Y2");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите вторую коордиату Z2");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double a = Math.Pow((x2-x1),2);
// double b = Math.Pow((y2-y1),2);
// double c = Math.Pow((z2-z1),2);

// double d = Math.Sqrt(a+b+c);
// Console.WriteLine("Расстояние между двумя точками = "+d);

// ---------------------------------Задача 3(23)-------------------

// Напишите программу, которая на вход принимает число (N) и 
// выдает таблицу кубов чисел от 1 до N

// 3 -> 1,8,27
// 5 -> 1,8,27,64,125

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;

// while (count<=number)
// {
//     Console.WriteLine($"{count}^3={Math.Pow(count,3)}");
//     count++;
// }

