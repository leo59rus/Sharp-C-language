// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.7; 7.2; 2.1; 7.8] -> 5.7

double[] arr = {3.7, 7.2, 2.1, 7.8};
void PrintArray(double[] array)//распечатк массива
{
    Console.Write("[");
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    
}
PrintArray(arr);
double diff = 0;

void Difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        //[3.7; 7.2; 2.1; 7.8] -> 5.7
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];

    }
diff = max - min;
Console.WriteLine("->" + max + " - " +  min + " = " + diff);
//получается 5.69999 не понимаю почему ;(
}
    




Difference(arr);


