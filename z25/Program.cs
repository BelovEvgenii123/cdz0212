// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//НЕ ИСПОЛЬЗОВАТЬ MATH.POW
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
Console.WriteLine("Напишите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int b = int.Parse(Console.ReadLine());
int result =1;
int [] arr = new int [b];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = a;
}
for (int j = 0; j < arr.Length; j++)
{
result*=arr[j];
}
Console.WriteLine(result);

