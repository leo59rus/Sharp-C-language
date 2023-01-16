// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
//еще решение преобразовать с строку и выдать число по номеру ячейуи массива
//int a = 123;
//string str = a.ToString();
//Console.WriteLine(str[1]);
Console.Write("введи трёхзначное число - ");
int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(number);
int hundred = number/100;
//Console.WriteLine(hundred);
int d = (number - hundred*100);//убрали сотни
//Console.WriteLine(d);
int result = d/10;//узнали колво десятков

Console.WriteLine("второя цифра твоего числа - " + result);
