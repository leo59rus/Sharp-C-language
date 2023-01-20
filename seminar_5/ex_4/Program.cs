// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний 
//  и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int[] arr = {6, 7, 3, 6};
void PrintArray(int[] array)//распечатк массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        if (array[i] != 0) Console.Write(array[i] + " ");
        
    }
    Console.WriteLine();
}
PrintArray(arr);

int[] arrNew = new int[10];

void MultiplicationOfPairs(int[] array)//умножение пар чисел 
{
    //надо сделать проверку на четность размера массива
    int temp = array.Length / 2;
    for (int i = 0; i < temp; i++)
    {
       int leftPosition = i; 
       int rightPosition = array.Length - i - 1;
       int temporary = array[leftPosition] * array[rightPosition];
       arrNew[i] = temporary;
       
    }
    PrintArray(arrNew);
}


MultiplicationOfPairs(arr);



