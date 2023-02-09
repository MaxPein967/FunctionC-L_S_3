Console.Clear();
// Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}
//Method1(); // Add Method 

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("text of msg");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("text of msg", 4);
//Method21(msg: "text of msg",count: 4);
//Method21(count: 4, msg: "New text");

//Вид3 с типом данных которые должны вывести

int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);

// Вид4 Методы которые что-то принимают и что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "qwe");
Console.WriteLine(res);