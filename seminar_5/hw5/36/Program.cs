// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] arr = new int[4];
void PrintArray(int[] array)//распечатк массива
{
    Console.Write("[");
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    
}

//PrintArray(arr);
//метод создающий массив из рандомных чисел
void CreatingArray(int[]array)
{
Random rand = new Random();
for(int i = 0; i < arr.Length; i++)
   arr[i] = rand.Next(-99,99);
}

CreatingArray(arr);
PrintArray(arr);

void Availability(int[] array)
{
    int a = 0;
    
    for (int i = 1; i < array.Length; i += 2)
    {
        a += array[i];
       
    }
    Console.WriteLine(" -> " + a);
    
}



Availability(arr);

