// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("введи число - ");
int number = Convert.ToInt32(Console.ReadLine());
int d = number / 100;//трехзначное число?
if (d<1){
    Console.WriteLine("третьей цифры нет"); 
}

if (d<10 && d>=1 ){
Console.WriteLine("трехзначное число");
int hundred = number/100;
int c = (number - hundred*100);
int result = c%10;
Console.WriteLine("третья цифра - " + result);
}

if (d<100 && d>=10 ){
    Console.WriteLine("четырехзначное число");
   
}

if (d<1000 && d>=100 ){
    Console.WriteLine("пятизначное число");
    int c1 = number/10000;
    int c2 = number - c1*10000;//стало четырехзначное
    int b1 = c2/1000;
    int b2 = c2 - b1*1000;//сталотрёхзначное
    Console.WriteLine("третья цифра - " + b2/100);
}
