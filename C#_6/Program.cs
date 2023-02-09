// Задача 35: 
//Задайте одномерный массив из 123 
//случайных чисел. Найдите количество 
//элементов массива, значения которых 
//лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 
//элементов. В своём решении сделайте
// для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] numbers = new int[123];

// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = new Random().Next(0, 150);
// }
// Console.WriteLine(string.Join(",", numbers));
// int Count = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] >= 10 && numbers[i] < 100) Count += 1;
// }
// Console.WriteLine(Count);

// Задача 37: 
//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний 
//элемент, второй и предпоследний и т.д. Результат запишите 
//в новом массиве.
// [1 2 3 4 5] -> 5 8 3

Console.WriteLine("Размер массива: "); 
int n; 
n = Convert.ToInt32(Console.ReadLine()); 
int[] ar = new int[n]; 
var rand = new Random(); 
       
for(int i = 0; i < ar.Length; i++) 
ar[i] = rand.Next(-50, 50); 
Console.Write("Значения элементов массива: "); 
foreach(var item in ar) 
Console.Write("{0} ", item); 
Console.WriteLine(); 
for(int i = 0; i < ar.Length / 2; i++) 
Console.WriteLine("элемент {0} * элемент {1}, {2} * {3}  = {4}", i, ar.Length - i - 1, ar[i], ar[ar.Length - i - 1], ar[i] * ar[ar.Length - i - 1]); 
return; 

