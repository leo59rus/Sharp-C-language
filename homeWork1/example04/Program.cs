 Console.Write("введите число, программа выдаст все четные числа от одного до Вашего числа ");
int a = Convert.ToInt32(Console.ReadLine());
int counter = 0;
if (a < 2) {
    Console.WriteLine("нет чётных чисел");
} else 
{
    
    while(counter < (a - 1)){
        counter = counter + 2;
      Console.Write(counter + " ");  
    }
}

//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8