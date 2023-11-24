/*
ЗАДАНИЕ №4
Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий 
из цифр этого числа. Старший разряд числа должен располагаться на 0-ом индексе
массива, младший на последнем. Размер массива должен быть равен количеству цифр.
*/

// Задаем натуральное число
Random randoms = new Random();
int numberN = randoms.Next(1, 100000);
Console.WriteLine($"Заданное натуральное число = {numberN}");

// формируем массив длины, равной разрядности числа
int razr = Convert.ToInt32(Math.Truncate(Math.Log10(numberN))) + 1;
int [] massiv = new int[razr];

// Заполняем массив отдельными цифрами из числа
int i = 0;
int val=numberN; 
while (i < razr)
{
    massiv[i] = Convert.ToInt32(val % 10);
    val = val / 10;
    i = i + 1;
}
// Теперь необходимо развернуть массив
int temp; 
for (int ii = 0; ii < (razr / 2); ii = ii + 1)
{
    temp = massiv[ii];
    massiv[ii] = massiv[razr-ii-1];
    massiv[razr-ii-1] = temp;
}
// выводим массив на консоль
for (int ii = 0; ii < razr; ii = ii + 1)
{
    Console.WriteLine($"Элемент массива massiv[{ii}] равен {massiv[ii]}");
}

