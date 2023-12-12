﻿// Знакомство с языками программирования (семинары)
// Урок 3. Массивы

// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

System.Console.WriteLine("Введите количество элементов массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
Random rnd = new Random();
double max = 0, min = 0;
string separator = ", ";
for (int i = 0; i < size; i ++)
{
    array[i] = rnd.NextDouble() * rnd.Next(5,25);
    if (i == 0)
    {
        min = array[i];
        max = array[i];  
    }
    if (i + 1 == size) separator = "";
    System.Console.Write($"{array[i]}{separator}");
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];    
}

System.Console.WriteLine();
System.Console.WriteLine($"min элемент массива равен {min}"); 
System.Console.WriteLine($"max элемент массива равен {max}"); 
System.Console.WriteLine($"Разность между max и min элементами массива равна {max - min}"); 