﻿// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool Kvadrat(int num1, int num2)
{
    if(num1 * num1 == num2 || num2 * num2 == num1)
       return true;
    else
       return false; 
}
bool result = Kvadrat(num1,num2);
Console.WriteLine(($"Результат проверки: {result} "));