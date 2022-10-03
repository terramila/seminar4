/*Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B. */


Console.Write("Введите число a  : ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите степень b: ");
int b = int.Parse(Console.ReadLine());
int res = 1;
for (int i = 0; i < b; i++)
{
    res *= a;
}
Console.WriteLine($"{a} ^ {b} = {res}");
Console.ReadKey();
return 0;




