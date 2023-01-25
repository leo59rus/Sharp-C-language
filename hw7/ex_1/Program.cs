// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
Random rand = new Random();
void FillArrayWithRandom(double[,] matrix, int strk, int stlb)//zapolnenie massiva randomno
{
    for(int i = 0; i < strk; i++)//otve4aet za stroku
    {
        for(int k = 0; k < stlb; k++)//za stolby
        {
            matrix[i,k] = (21) * rand.NextDouble() - 10;//подскажите пжлста





            //как вывести число с ОДНОЙ ЦИФРОЙ ПОСЛЕ ЗПТ
            //заранее благодарю





            
 Console.Write(matrix[i,k] + " ");
        }
        Console.WriteLine();
    }

}

Console.WriteLine("введите колво строк массива strk: ");//
int strk = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов массива stlb: ");
int stlb = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double[strk,stlb];

FillArrayWithRandom(matrix, strk, stlb);
