//Напишите программу, которая по заданному номеру четверти,
//показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Write("введите четверть (обозначение по часовой стрелке) для вывода диапозона возможных координат точек ");
int x = Convert.ToInt32(Console.ReadLine());
if (x<1 || x>4) Console.WriteLine("дипозон четверти задан не верный, напишите цифру от 1 до 4х");
if (x == 1) Console.WriteLine("x>0 && y>0");
if (x == 2) Console.WriteLine("x>0 && y<0");
if (x == 3) Console.WriteLine("x<0 && y<0");
if (x == 4) Console.WriteLine("x<0 && y>0");


