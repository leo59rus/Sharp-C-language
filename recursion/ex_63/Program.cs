﻿// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные
//  числа в промежутке от 1 до N. Выполнить с помощью рекурсии.

// N = 5 -> "1,2,3,4,5"
// N = 6 -> "1,2,3,4,5,6"

void PrintNumbers (int number){
    if(number==0)
    {
    return;
    }
    PrintNumbers(number - 1);
    Console.Write(number + " ");
}
Console.WriteLine("VVedite chislo: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumbers(n);
