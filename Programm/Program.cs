Console.Clear();

string[] LessThanFour(string[] StringArray)
{
    string[] NewStringArray = new string[StringArray.Length];
    int j = 0;
    for (int i = 0; i < StringArray.Length; i++)
    {
        if (StringArray[i].Length <= 3)
        {
            NewStringArray[j] = StringArray[i];
            j++;
        }
    }
    string[] ReturnStringArray = new string[j];
    for (int i = 0; i < ReturnStringArray.Length; i++)
    {
        ReturnStringArray[i] = NewStringArray[i];
    }
    return ReturnStringArray;
}

void WriteArrayString(string[] StringArray)
{
    for (int i = 0; i < StringArray.Length; i++)
    {
        Console.WriteLine(StringArray[i]);
    }
}

string[] StringArray = {"Is", "this", "gonna", "be", "enough", "for", "you?", "<3"};
StringArray = LessThanFour(StringArray);
WriteArrayString(StringArray);
Console.WriteLine($"The length of the array is {StringArray.Length} element's");