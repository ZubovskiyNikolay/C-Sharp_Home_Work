// ------------------------------------Задача 1(25)--------------------
// Напишите цикл, который приимает на вход 
// два числа (А и В) и возводит число А в 
// натуральную степень В
// 3,5 -> 243 (3^5)
// 2,4 -> 16 

// double NumberPower()
// {
//     Console.WriteLine("Введите число");
//     double num = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Введите степень числа");
//     double power = Convert.ToDouble(Console.ReadLine());
//     double numberpower = Math.Pow(num, power);
//     return numberpower;
// }
// Console.WriteLine(NumberPower());

// ----------------------------------Задача 2(27)-------------------------

// Напишите программу, которая на вход приимает число и выдает 
// сумму цифр в этом числе
// 452 -> 11
// 82 ->10
// 9012 ->12

// int SumNumber()
// {
//     Console.WriteLine("Введите число");
//     int num = Convert.ToInt32(Console.ReadLine());
//     int sumnum = 0;
//     while (num>0)
//     {
//      sumnum = sumnum+num%10;
//         num = num/10;
//     }
// return sumnum;
// }
// Console.WriteLine("Сумма цифр числа равна - "+SumNumber());

// ---------------------------------------Задвчв 3(29)---------------------------
//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// void PrintArray()
// {
//     int[] array = new int[8] {1,2,3,4,3,5,6,8};
//     int count = 0;

//     while (count<array.Length)
//     {  
//          Console.Write(array[count]+" ");
//          count++;
//     }   
// }
// PrintArray();


