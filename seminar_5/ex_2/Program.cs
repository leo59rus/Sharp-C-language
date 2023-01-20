//Задача 33: Задайте массив. Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
 
 int[] arr = {6, 7, 19, 345, 3};
void PrintArray(int[] array)//распечатк массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


//Задача 33: Задайте массив. Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
void AvailabilityCheck(int[] array)
{
    int a = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == 345) a++;
    }
    if (a>0) Console.WriteLine("ДА ");
    if (a==0)Console.WriteLine("НЕТ ");
}

PrintArray(arr);
AvailabilityCheck(arr);

//PrintArray(arr);
