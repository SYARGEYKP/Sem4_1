﻿// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputInt(string massage)
{
    System.Console.WriteLine($"{massage} > ");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
int NumberA = InputInt("Введите число А");
int NumberB = InputInt("Введите число B");

int Stepen(int NumberA, int NumberB)

{
    int result = 1;
    for (int i = 1; i <= NumberB; i++)
    {
        result = result * NumberA;
    }
    return result;
}
System.Console.WriteLine($"Степень равна {Stepen(NumberA,NumberB)}");
