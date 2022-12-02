// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
Console.WriteLine("Напишите число");
int a = int.Parse(Console.ReadLine());
int s =0;
while (a>0)
{
s+=a%10;
a/=10;
}
Console.WriteLine(s);

