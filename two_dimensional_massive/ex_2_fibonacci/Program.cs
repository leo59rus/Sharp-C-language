double Fibonacci(int n)//метод показывающий н-ное число Фибоначчи
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);

}
//Console.WriteLine(Fibonacci(8));  //н-ное число Фибоначчи

//цикл который покажет полсдеовательность Фибоначчи до н-ного числа Ф.
for (int i = 1; i < 40; i++)
{
    Console.WriteLine(i + " " + Fibonacci(i));
}