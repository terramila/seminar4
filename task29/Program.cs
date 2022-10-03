/*Напишите программу, которая задаёт массив из 8 элементов и выводит
 их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int arrayLength = 8;

int[] array = new int[arrayLength];
Random randGenerator = new Random();

FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(0, 100);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}