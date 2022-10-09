// Группа 1 - не принимает и не возвращает
void Method1()
{
    Console.WriteLine("Автор : ");
}

Method1();

// Группа 2 - принимает и не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21(msg: "Текст", count: 4); // если мы именуем переменные, то можем писать аргменты не по порядку)

// Группа 3 - не принимает и возвращает
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Группа 4 - принимает и возвращает
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; // так принято указывать, что строка result пустая

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "deodkeo ");
// Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z ");
Console.WriteLine(res);