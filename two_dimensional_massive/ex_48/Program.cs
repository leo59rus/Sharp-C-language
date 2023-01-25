// Задайте двумерный массив размера m на n, каждый элемент 
//в массиве находится по формуле: Aₘₙ = i+j. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
void FillArrayWithRandom(int[,] matrix, int strk, int stlb)//zapolnenie massiva randomno
{
    for(int i = 0; i < strk; i++)//otve4aet za stroku
    {
        for(int k = 0; k < stlb; k++)//za stolby
        {
            matrix[i,k] = i + k;
            Console.Write(matrix[i,k] +  " ");
            
        }
        Console.WriteLine();
    }

}

Console.WriteLine("введите колво строк массива strk: ");//
int strk = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов массива stlb: ");
int stlb = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[strk,stlb];

FillArrayWithRandom(matrix, strk, stlb);
