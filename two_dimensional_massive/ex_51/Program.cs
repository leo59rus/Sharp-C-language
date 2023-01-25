// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int [,] matrix = {{1, 4, 7, 2},
                  {5, 9, 2 ,3},
                  {8, 4, 2, 4}
};

void SquaringEvenElements(int[,] matrix)//vozvedenie v kvadrat chenn
{
    int summ = 0;
    for(int i = 0; i < 3; i++)//otve4aet za stroku
    {
        for(int k = 0; k < 4; k++)//za stolby
        {

            if (i==k){
                summ += matrix[i,k]; 
               
                
            }
            
        }
        
    }
    Console.WriteLine(summ);

}
SquaringEvenElements(matrix);
