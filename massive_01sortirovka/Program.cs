// сортировка массива от наименьшего к наибольшему

int[] arr = {1, 5, 4, 3, 2, 6, 7};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}



void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
       int minPosition = i; 

       for (int j = i + 1; j < array.Length; j++)
       {
        //ищем макс элт
        //если поставить другой знак на > то упорядочивание будет от наибольшего числа
          if(array[j] < array[minPosition]) minPosition = j;
       }

       int temporary = array[i];
       array[i] = array[minPosition];
       array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);