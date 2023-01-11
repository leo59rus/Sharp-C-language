//заменить маленькую к большой К
//а большие С маленькими с

string text = " вот текст из букв  мальнкой к и большой буквой С Собака Сок";

// string s = "abcd"
//             0123
//s[3] = d

string Replace(string text, char oldValoue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
       if(text[i] == oldValoue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";

    
    }
  return result;
}
string newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С','с');
Console.WriteLine(newText);