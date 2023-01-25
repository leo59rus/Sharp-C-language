// Задайте двумерный массив. Найдите элементы, у которых odin iz  индекса 
// чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 49 2
// 5 9 2 3
// 64 4 4 4

int [,] matrix = {{1, 4, 7, 2},
                  {5, 9, 2 ,3},
                  {8, 4, 2, 4}
};

void SquaringEvenElements(int[,] matrix)//vozvedenie v kvadrat chenn
{
    for(int i = 0; i < 3; i++)//otve4aet za stroku
    {
        for(int k = 0; k < 4; k++)//za stolby
        {
            if (i%2 == 0 && k%2 == 0){
                matrix[i,k] = matrix[i,k] * matrix[i,k];
                
            }
            Console.Write(matrix[i,k] +  " ");
        }
        Console.WriteLine();
    }

}



SquaringEvenElements(matrix);