
string text = "-Я думаю, - сказал князь,улыбаясь, - что, "
+ "ежели бы вас послали вместо нашего милого Винценгероде,";
string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string NewText = Replace(text, ' ', '|');
System.Console.WriteLine(NewText);