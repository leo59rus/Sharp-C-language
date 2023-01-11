
//метод принимает 
void Method1(string msg, int count)
{
  int i = 0;
  while(i < count){
    Console.WriteLine(msg);
    i++;
  }  
}
Method1("kow4lle", 3);

//метод возвращает
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//метод принимает и возвращает
string Method4(int count, string text){
    string result = string.Empty;

    for(int i = 0; i < count; i++)
    {
    result = result + text;
    }
    
    return result;
}
string res = Method4(5, "gila");
Console.WriteLine(res);

//цикл в цикле
for(int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
     Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
