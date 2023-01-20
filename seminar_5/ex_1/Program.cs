//Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 



int[] arr = {-4, -8, 8, 2};
void PrintArray(int[] array)//распечатк массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}



void SelectionSort(int[] array)//положительные элементы замените на 
//соответствующие отрицательные, и наоборот.
{
    for (int i = 0; i < array.Length; i++)
    {
       int position = i; 
       int temporary = array[i];
       array[i] = array[position];
       array[position] = temporary * -1;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
