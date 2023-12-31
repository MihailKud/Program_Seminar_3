﻿/*
ЗАДАНИЕ №3
Задайте массив из вещественных целых чисел с ненулевой дробной частью.
Найдите разницу между максимальным и минимальным значениями массива.
*/

// Инициализируем массив длины 10 вещественными числами 
double [] massiv = new double[10];
int i = 0;
Random randoms = new Random();
double support_val;

// Заполняем массив случайными вещественными числами в диапазоне от 0 до 100. 
// При этом исключаем заполнение массива значениями с нулевой дробной частью.
// Идеей является проверка сгенерированного вещественного числа на равенство целому значению,
// получаемому путем его округления до целого. Если дробная часть вещественного числа нулевая,
// то оно будет равно результату преобразования Convert.ToInt32(). 
while (i < 10)
{
    while (true)
    {
        support_val = randoms.NextDouble()*100;
        if (support_val != Convert.ToInt32(support_val)) break;
    }
    massiv[i] = support_val;
    Console.WriteLine(massiv[i]);
    i = i + 1;
}
// осуществляем поиск максимального и минимального значения массива
double max = massiv[0];
double min = massiv[0];
for (int ii = 1; ii < 10; ii = ii + 1)
{
    if (massiv[ii] > max) max = massiv[ii];
    if (massiv[ii] < min) min = massiv[ii];
}
// Выводим получившиеся значения на консоль
Console.WriteLine($"Максимальное значение массива = {max}");
Console.WriteLine($"Минимальное значение массива = {min}");
Console.WriteLine($"Разница между макс. и миним. значениями равна {max-min}");

