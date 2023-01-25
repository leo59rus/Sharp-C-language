// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double [,] matrix = {
                     {1, 4, 7, 2},
                     {5, 9, 2 ,3},
                     {8, 4, 2, 4}
                    };

int line;
int column;

void Average(double[,] matrix, int line, int column)//srednee arifm v column
{
    double summ0 = 0;
    double summ1 = 0;
    double summ2 = 0;
    double summ3 = 0;
    for(int i = 0; i < line; i++)//otve4aet za stroku
    {
        for(int k = 0; k < column; k++)//za stolby
        {

            if (k==0) summ0 += matrix[i,k]; 
            if (k==1) summ1 += matrix[i,k]; 
            if (k==2) summ2 += matrix[i,k]; 
            if (k==3) summ3 += matrix[i,k];    
            
        }
        
    }
    Console.WriteLine("Среднее арифметическое каждого столбца: " + summ0/line + "; "
    +  summ1/line +"; "+ summ2/line +"; "+ summ3/line);

}

Average(matrix, 3, 4);