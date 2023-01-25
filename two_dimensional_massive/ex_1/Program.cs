string[,] table = new string[2,5];//строки, столбцы
//[0,0] [0,1] [0,2] [0,3] [0,4]
//[1,0] [1,1] [1,2] [1,3] [1,4]


table [1,2] = "word";//назвали переменную 1й строки 2 столба

for (int rows = 0; rows < 2; rows++)//строки
{
    for (int columns = 0; columns < 5; columns++)//столбцы
    {
        Console.Write($"-{table[rows, columns]}-");
    } 
    Console.WriteLine();
}



void PrintArray(int[,] matr){//метод печатающий двойной массив
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
        Console.Write($"{matr[rows, columns]} ");
        }
    Console.WriteLine();
    }
}
int[,] matrix = new int[5,8];
PrintArray(matrix);

void FillArray(int[,] matr)
{// заполнение двойноо массива рандомными числами
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(1,10);//[1;10)
    }
}
}
FillArray(matrix);
PrintArray(matrix);