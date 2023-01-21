/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на чётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/
void FillArr(int []arr)
{
    for(int i = 0; i<arr.Length; i++)
    {
        arr [i] = new Random().Next(1,1000);
    }
}
void Printarr (int []arr)
{
    for(int i = 0; i<arr.Length; i++)
    {
        Console.WriteLine("I Равно: " + i);
        Console.WriteLine(arr[i]);
    }
}
void SumOfEvenNum(int[]col)
{
    int i = 0;
    int result = 0;
    while (i<col.Length)
        {
            if(i%2==0)
        {
            result = result + col[i];
        }
        i++;
        }
    Console.WriteLine($"Сумма элементов, стоящих на четных позициях: {result}"); 
}        
       

int[]col = new int [10];
FillArr (col);
Printarr (col);
SumOfEvenNum(col);
