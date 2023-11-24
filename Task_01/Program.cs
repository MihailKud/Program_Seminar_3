﻿/*
ЗАДАНИЕ №1
Задайте одномерный массив из 10 целых чисел от 1 до 100.
Найдите количество элементов массива, значения которых лежат в отрезке [20, 90]
*/

// Инициализируем массив
int [] massiv = new int[10];
int i = 0;
int quantity = 0;
Random randoms = new Random();

// Заполняем массив случайными целыми числами в диапазоне от 1 до 100
while (i < 10)
{
    massiv[i] = randoms.Next(1, 100);
    Console.WriteLine(massiv[i]);
    i = i + 1;
}

// Подсчитываем количество элементов массива, значения которых лежат в диапазоне [20, 90]
for (int ii = 0; ii < 10; ii = ii + 1)
{
    if ((massiv[ii] >= 20) & (massiv[ii] <= 90)) quantity = quantity + 1; 
}
Console.WriteLine($"Количество элементов массива = {quantity}");
