// Задача 33: 
//Задайте массив. Напишите программу, 
//которая определяет, присутствует ли 
//заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
int[] numbers = new int[10];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(-20, 20);
}
Console.WriteLine(string.Join(" ", numbers));
int find = 10;
String Ans = "No";
for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] == find)
    {
        Ans = "Yes";
        break;
    }
}
Console.WriteLine(Ans);
    

