// Знакомство с языками программирования (семинары)
// Урок 3. Массивы

// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = new int[10];
Random rnd = new Random();
int count = 0;
string separator = ", ";
for (int i = 0; i <= 9; i ++)
{
    array[i] = rnd.Next(1, 10000);
    if (i == 9) separator = "";
    System.Console.Write($"{array[i]}{separator}");
    if (array[i] % 2 == 0) count ++;
}

System.Console.WriteLine();
System.Console.WriteLine($"Количество чётных элементов массива равно {count}"); 
