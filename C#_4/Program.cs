// Задача 32: 
//Напишите программу замена элементов
//массива: положительные элементы замените
//на соответствующие отрицательные, и 
//наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

//int[] numbers = { -4, -8, 8, 2 };
Console.Clear();
int[] numbers = new int[12];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(-9, 10);
}
Console.WriteLine(string.Join(" ", numbers));
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = numbers[i] * -1; // numbers[i]*=-1
}
Console.WriteLine(string.Join(" ",numbers));