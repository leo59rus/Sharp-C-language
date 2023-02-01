// Задача 64: Задайте значение N. Напишите программу, которая
//  выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ABArray(int numA, int numB)
{
    if(numA == numB +1)
    {
        return;
    }
    ABArray(numA + 1, numB);
    Console.Write(numA + " ");
}


int num1 = 1;
Console.WriteLine("vvedite ot kakogo chisla vesti vyvesti chisla v porydke ubyvniya: ");
int num2 = Convert.ToInt32(Console.ReadLine());
ABArray(num1, num2);


