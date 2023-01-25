int Factorial(int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n - 1);//рекурсия метод вызывающий сам себя
   
}
 Console.WriteLine(Factorial(5));//1*2*3=6 5!=120
