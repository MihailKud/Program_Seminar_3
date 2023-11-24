/*
ЗАДАНИЕ №2
Задайте массив на 10 целых чисел. Напишите программу, которая определяет 
количество четных чисел в массиве.
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
// Определяем количество четных чисел в массиве
for (int ii = 0; ii < 10; ii = ii + 1)
{
    if (massiv[ii] % 2 == 0) quantity = quantity + 1; 
}
Console.WriteLine($"Количество четных чисел в массиве = {quantity}");
