// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Write("Введите колличество элементов массива :");
int count = int.Parse(Console.ReadLine());
int[] arr = new int[count];
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Введите  эелемент массива под индексом {i}:");
    arr[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Вывод массива:  ");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}
int positive = 0;
for (int i = 0; i < arr.Length; i++)
if (arr[i] > 0)
positive++;
Console.WriteLine($"{positive} из них больше ноля");


