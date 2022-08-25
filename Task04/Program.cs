/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

int userNumOne = new int();
int userNumTwo = new int();
int userNumThree = new int();

Console.WriteLine("Введите первое число: ");
userNumOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
userNumTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
userNumThree = Convert.ToInt32(Console.ReadLine());

int result = userNumOne > userNumTwo && userNumOne > userNumThree
? userNumOne : userNumTwo > userNumOne && userNumTwo > userNumThree
? userNumTwo : userNumThree;
Console.Write(result);