// с помощью рекурсии перечислите все числа от 2х заданных чисел
// пример число н =3 е =6
// 3 4 5 6

void ABArray(int numA, int numB)
{
    if(numA == numB - 1)
    {
        return;
    }
    ABArray(numA - 1, numB);
    Console.Write(numA + " ");
}

Console.WriteLine("vvedite ot kakogo chisla vesti vyvesti chisla po porydku: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite do kakogo chisla : ");
int num2 = Convert.ToInt32(Console.ReadLine());
ABArray(num2, num1);

