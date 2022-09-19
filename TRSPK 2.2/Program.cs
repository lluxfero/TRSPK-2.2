Console.WriteLine("======StringList======");
var FirstStringList = new StringList();
FirstStringList.Insert("1");
FirstStringList.Insert("2");
FirstStringList.Insert("3");
FirstStringList.Insert("4");
FirstStringList.Insert("5");
FirstStringList.Insert("6");
Console.WriteLine(FirstStringList.ToString());

Console.WriteLine("_Delete(4)");
FirstStringList.Delete(4);
Console.WriteLine(FirstStringList.ToString());

Console.WriteLine("_Search(\"3\")");
Console.WriteLine(FirstStringList.Search("3"));

Console.WriteLine("_Update(1, \"7\")");
FirstStringList.Update(1, "7");
Console.WriteLine(FirstStringList.ToString());

Console.WriteLine("_GetAt(0)");
Console.WriteLine(FirstStringList.GetAt(0));


Console.WriteLine("\nPress <Enter>");
Console.ReadLine();

class StringList
{
    public int size;
    string[] masstr;
    public StringList()
    {
        size = 0;
        masstr = new string[100];
    }
    public void Insert(string s)
    {
        if (size < 100)
        {
            masstr[size] = s;
            size++;
        }
        else throw new Exception();
    }
    public void Delete(int n)
    {
        if (n >= 0 && n < size)
        {
            for (int i = n; i < size - 2; i++)
                masstr[i] = masstr[i + 1];
            masstr[size - 1] = null;
            size--;
        }
        else throw new Exception(); ;
    }
    public int Search(string s)
    {
        for (int i = 0; i < size; i++)
            if (masstr[i] == s) return i;
        return -1;
    }
    public void Update(int n, string s)
    {
        if (n >= 0 && n < size) masstr[n] = s;
        else throw new Exception();
    }
    public string GetAt(int n)
    {
        if (n >= 0 && n < size) return masstr[n];
        else throw new Exception();
    }
    public override string ToString()
    {
        string s = "";
        for (int i = 0; i < size; i++)
            s += ($"Индекс {i}, Значение: {masstr[i]}, Размер: {size}");
        return s;
    }
}
