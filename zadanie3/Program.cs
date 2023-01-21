/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/
int MinOfNumbers(int[] col)
{ int min = col[0];
  for (int i=0; i<col.Length; i++)
  {
    if(min>col[i])
    {
        min=col[i];
    }
  }
  Console.WriteLine("Минимальное число массива " + min);
  return(min);
}
int MaxOfNumbers(int[] kol)
{ int max = kol[0];
  for (int i=0; i<kol.Length; i++)
  {
    if(max<kol[i])
    {
        max=kol[i];
    }
  }
  Console.WriteLine("Максимальное число массива " + max);
  return(max);
}
void DiffOfMaxAndMin(int h1, int h2)
{
    int diff = h1 - h2;
    Console.WriteLine( "Разница между максимальным и минимальным числами массива " + diff);
}

      int [] col = {234,567, 76, 900, 786};
      DiffOfMaxAndMin(MaxOfNumbers(col), MinOfNumbers(col));
      