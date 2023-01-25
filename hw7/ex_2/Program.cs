// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание,
//  что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7(ввод индексов) -> такого числа в массиве нет
// 1, 1 -> 9

int [,] matrix = {{1, 4, 7, 2},
                  {5, 9, 2 ,3},
                  {8, 4, 2, 4}
};

void SearchElement(int[,] matrix, int line, int column)
{
    if(line>3 || column >4){
                Console.WriteLine("вы вышли за пределы массива"); 
                           }
    
    for(int i = 0; i < 3; i++)//otve4aet za stroku
    {
        for(int k = 0; k < 4; k++)//za stolby
        {

            if (i == line && k == column){
                
                Console.WriteLine(matrix[i,k]); 
            }           
        }      
        
    }   

}
SearchElement(matrix,1,1);