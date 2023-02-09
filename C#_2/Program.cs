// Циклы и не только While

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }
Console.Clear();
// string Method5(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// // string res = Method5(10, "Text");
// // Console.WriteLine(res);

// // Вывод таблицы умножения на экран
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }
// Замена пробелов на черточки, буквы к на К, большие С на с
// 1 пункт: какой текст, текст ли, кирилица итд

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// strig s = "qwerty"
//            012345
// s[3] // r
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }


    return result;
}
// string newText = Replace(text, ' ', '_');
// newText = Replace(newText, 'к', 'К');
// newText = Replace(newText, 'с', 'з');
// Console.WriteLine(newText);

// Упорядочить алгоритм методом сортировки Минимакса
int[] arr = { 1, 5, 4, 3, 6, 9, 7, 8, 3, 2 };

// подзадача для вывода массива на экран
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        // int minPosition = i;
        // // цикл поиска минимального значения 
        // for (int j = i + 1; j < array.Length; j++)
        // {
        //     if (array[j] < array[minPosition]) minPosition = j;
        // }
        int maxPosition = i;
        // цикл поиска минимального значения 
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        //       свап (смена элементов местами)
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);