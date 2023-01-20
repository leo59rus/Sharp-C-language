// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//  Найдите количество элементов массива, значения которых лежат
//   в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов.
//  В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
int[] arr = new int[123];
void PrintArray(int[] array)//распечатк массива
{
    Console.Write("[");
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write("]");
    Console.WriteLine();
}
PrintArray(arr);

//метод создающий массив из рандомных чисел
void CreatingArray(int[]array)
{
Random rand = new Random();
for(int i = 0; i < arr.Length; i++)
   arr[i] = rand.Next(0,100);
}
CreatingArray(arr);
PrintArray(arr);

void Availability(int[] array)
{
    int a = 0;
    for (int i = 0; i < array.Length; i++)
    {
        //[10,99]
        if(array[i] >= 10 && array[i] <= 99) a++;
    }
    Console.WriteLine(" -> " + a);
    
}

//PrintArray(arr);

Availability(arr);
