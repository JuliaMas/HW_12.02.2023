// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
Console.Write("Введите количество строк маттрицы n: ");
int n = int.Parse(Console.ReadLine() ?? "");

void FillMatrix(int[,] PascalTr)
{
  for (int k = 0; k < PascalTr.GetLength(0); k++)
  {
    PascalTr[k, 0] = 1;
  }
  for (int i = 1; i < PascalTr.GetLength(0); i++)
  {
    for (int j = 1; j < i + 1; j++)
    {
      PascalTr[i, j] = PascalTr[i - 1, j] + PascalTr[i - 1, j - 1];
    }
  }
}
void WriteMatrix(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] != 0)
      {
          Console.Write($"{array[i, j]} ");
      }
      else Console.Write("  ");
    }
    Console.WriteLine();
  }
}
void TransformMatrix(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int count = 0;
    for (int j = array.GetLength(1) - 1; j >= 0; j--)
    {
      if (array[i, j] != 0)
      {
        array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
        array[i, j] = 0;
        count++;
      }
    }
  }
  array[array.GetLength(0) - 1, 0] = 1;
}

int[,] PascalTr = new int[n + 1, 2 * n + 1];

FillMatrix(PascalTr);

Console.WriteLine();
WriteMatrix(PascalTr);

TransformMatrix(PascalTr);

Console.WriteLine();
WriteMatrix(PascalTr);