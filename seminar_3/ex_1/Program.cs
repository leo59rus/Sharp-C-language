// Напишите программу, которая по заданным координатам (x и y). 
// показывает  четверть (по часовой стрелке),

Console.Write("введите координату х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());
if(x>0 && y>0) Console.WriteLine("точка находится в 1й четверти");
if(x>0 && y<0) Console.WriteLine("точка находится в 2й четверти");
if(x<0 && y<0) Console.WriteLine("точка находится в 3й четверти");
if(x<0 && y>0) Console.WriteLine("точка находится в 4й четверти");
