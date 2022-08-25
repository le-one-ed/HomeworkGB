/*Задание
Пример
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

int userNumberOne = new int();
int userNumberTwo = new int();

Console.WriteLine("Введите первое число: ");
userNumberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число число: ");
userNumberTwo = Convert.ToInt32(Console.ReadLine());

if (userNumberOne > userNumberTwo)
{
    Console.WriteLine($"Большее число max = {userNumberOne}. Меньшее число min = {userNumberTwo}");
}
else
{
    Console.WriteLine($"Большее число max = {userNumberTwo}. Меньшее число min = {userNumberOne}");
}