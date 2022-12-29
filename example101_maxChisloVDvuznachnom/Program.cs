//вывод случайного числа от 10 до 99 и вывести наибольшую цифру двузначного числа
int number = new Random().Next(10,100);//от 10 до 100 не включая их
Console.WriteLine("Ваше случайное число: " + number);
int first = number/10;//первое число
int second = number%10;//второе число
if(first > second){
    Console.WriteLine("наибольшая цифра твоего числа " + first);
} else {
Console.WriteLine("наибольшая цифра твоего числа " + second);
}