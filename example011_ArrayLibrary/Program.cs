void FillArray(int[] collection)//заполнение массива рандомно
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)//печать массива
{
    int count = col.Length;
    int position = 0;
    while(position<count){
        Console.Write(col[position] + " ");
        position++;
    }
    Console.WriteLine(".");
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;//-1 означает такой элемент не найден

    while(index < count)
    {
       if(collection[index]==find)
        {
           position = index;
           break;//после нахождения первого сходства следующие искать не будет
        }
    index++;
    }
    return position;
}

int[] arrayMy = new int[10];//создали пустой массив с 10ю элми по умолчанию заполнен нулями

//вызов методов
FillArray(arrayMy);
PrintArray(arrayMy);

Console.WriteLine();

int pos = IndexOf(arrayMy, 4);
Console.WriteLine(pos);