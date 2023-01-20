// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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


//метод создающий массив из рандомных чисел
void CreatingArray(int[]array)
{
Random rand = new Random();
for(int i = 0; i < arr.Length; i++)
   arr[i] = rand.Next(99,1000);
}
CreatingArray(arr);
PrintArray(arr);

void Availability(int[] array)
{
    int a = 0;
    int b = 0;
    for (int i = 0; i < array.Length; i++)
    {
        b = array[i] % 2;
        if(b == 0) a++;
    }
    Console.WriteLine(" -> " + a);
    
}



Availability(arr);
