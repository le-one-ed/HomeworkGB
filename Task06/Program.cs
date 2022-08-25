/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

int userNumberOne = new int();
Console.WriteLine("Введите первое число: ");
userNumberOne = Convert.ToInt32(Console.ReadLine());

string result = userNumberOne % 2 == 0 ? "Да" : "Нет";
Console.WriteLine(result);