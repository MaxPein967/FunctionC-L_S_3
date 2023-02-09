//
// void SayLang()
// {
//     Console.WriteLine("Hello,World!");
// }
// SayLang();
// SayLang();
// SayLang();
// SayLang();
// SayLang();

/// Работа со строками
// Console.Clear();
// string s1 = "Hello";
// string s2 = "world!";
// string s3 = s1 + s2;

// Console.WriteLine(s3.Length);

// Зеркальный метод джойн и сплит
// string s = "1, 2, 3, 4, 5, 6, 7.";
// string[] nums = s.Split(new char[]{' ',',','.'}, StringSplitOptions.RemoveEmptyEntries);
// int[] n = nums.Select(Int32.Parse).ToArray();
// // foreach (var item in nums)
// // {
// //     Console.WriteLine(item);
// // }
// // Вместо s можно использовать Console.ReadLine()
// int[] num = Array.ConvertAll(s.Split(), int.Parse);

//Задача 31:
//Задайте массив из 12 элементов, 
//заполненный случайными числами из 
//промежутка [-9, 9]. Найдите сумму 
//отрицательных и положительных элементов 
//массива.
//Например, в массиве
// [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
//сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

// int[] array = new int[12];
// Random rand = new Random();
// for (int y = 0; y < 12; y++)
// {
//      array[y] = rand.Next(1, 11);
// }
int[] numbers = new int[12];

//Console.WriteLine(string.Join(" ", numbers));
int SumPositive = 0;
int SumNegative = 0;
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(-9, 10);
    if (numbers[i] > 0) SumPositive += numbers[i];
    else SumNegative += numbers[i];
}
Console.WriteLine(string.Join(",", numbers));
Console.WriteLine($"положительные {SumPositive} отрицательные {SumNegative}");