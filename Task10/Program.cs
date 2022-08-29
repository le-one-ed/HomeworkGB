/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите число: ");
int threeDigitNum = Convert.ToInt32(Console.ReadLine());

if (threeDigitNum > 99 && threeDigitNum < 1000)
{
    Console.WriteLine((threeDigitNum / 10) % 10);
}
else
{
    Console.WriteLine("Введите другое число!");
}