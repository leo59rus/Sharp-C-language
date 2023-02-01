// 66. Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов
//   в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.WriteLine("vvedite ot kakogo chisla vyvesti summu chisel: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite do kakogo chisla vyvesti summu chisel: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = SumArray(num2, num1);

int SumArray(int numA, int numB)//6 4
{
    
    if(numA + 1 == numB)
    {
        return 0;
    }
   return numB + SumArray(numA,numB+1);//4+    /6 5
}
Console.WriteLine(sum);