// задайте двумерный массив размером м*н заполненный введеными целыми числами
// м=kakoe xo4u н=kakoe xo4u
// 1 4 8 9
// 5 -2 3 3
// 4 5 4 4
void FillArrayWithRandom(int[,] matrix, int strk, int stlb)//zapolnenie massiva randomno
{
    for(int i = 0; i < strk; i++)//otve4aet za stroku
    {
        for(int k = 0; k < stlb; k++)//za stolby
        {
            // matrix[i,k] = new Random().Next(-10,10);
            // Console.Write(matrix[i,k] +  " ");
            
            //ruchnoy vvod elemntov
            Console.Write($"vveite element pod indexom {i} {k}  ");
            matrix[i,k] = Convert.ToInt32(Console.ReadLine());
        }
        
    }

}
//закомментироватьесли будет рандом
void PrintArrayWithRandom(int[,] matrix, int strk, int stlb)//pechat massiva zapolnennogo vruchnuyu
{
    for(int i = 0; i < strk; i++)//otve4aet za stroku
    {
        for(int k = 0; k < stlb; k++)//za stolby
        {
            Console.Write(matrix[i,k]  + " ");
        }
        Console.WriteLine();
    }

}
Console.WriteLine("введите колво строк массива strk: ");//
int strk = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбов массива stlb: ");
int stlb = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[strk,stlb];

FillArrayWithRandom(matrix, strk, stlb);
PrintArrayWithRandom(matrix, strk, stlb);


