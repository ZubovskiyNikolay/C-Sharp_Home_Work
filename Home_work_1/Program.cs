// -----------------------------Задача 1(2)----------------------

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое число");
// int num1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2=Convert.ToInt32(Console.ReadLine());

// if (num1==num2)
// {
//   Console.WriteLine("Числа равны");
// }
// else if (num1>num2)
// {
//   Console.WriteLine("Большее число - "+num1);
//   Console.WriteLine("Меньшее число - "+num2);
// }
// else
// {
//   Console.WriteLine("Большее число - "+num2);
//   Console.WriteLine("Меньшее число - "+num1);
// }
// ----------------------------------Задача 2(4)--------------------------

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
int num1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int num3=Convert.ToInt32(Console.ReadLine());

int max=num1;
if (num2>max)
{
  max=num2;
} 
if (num3>max)
{
  max=num3;
}
Console.WriteLine("Максимальное число - "+max);
