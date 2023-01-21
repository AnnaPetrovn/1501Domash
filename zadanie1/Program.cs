/*Задача 34: Задайте массив заполненный случайными положительными
 трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

void CountEvenNum(int n)
{
    int k=0;
    int[] arr = new int [n];
    for(int i = 0; i<n; i++)
    {
        Random b = new Random();
        arr[i] = b.Next(100,999);
        if (arr[i]%2==0)
        {
            Console.WriteLine(arr[i]);
            k++;  
        }
    }
    Console.WriteLine($"Количество четных цифер в массиве " + k);
}
CountEvenNum(9);