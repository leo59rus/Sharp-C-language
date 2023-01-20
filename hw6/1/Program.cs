// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Введите элементы(через пробел, по окончанию ввода нажмите ентер): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.Write("[");
int counts = arr.Length;
for (int i = 0; i < counts; i++)
    {
        Console.Write(arr[i] + " ");
    }
Console.Write("]");

Console.WriteLine(" --> " + count);
