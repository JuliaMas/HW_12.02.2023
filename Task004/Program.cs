//Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите z: ");
int z = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine();

void FillArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
        number = temp[i];
      }
    }
  }
  int count = 0;
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

void PrintArray(int[,,] array3D, bool coords = true)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
        for (int k = 0; k < array3D.GetLength(2); k++)
      {
        string text = coords ? array3D[i, j, k] + $"({i},{j},{k})" : array3D[i, j, k]!.ToString()!;
        Console.Write($"{text}\t");
      }
      Console.WriteLine();
    }
  }
}

int[,,] array3D = new int[x, y, z];
FillArray(array3D);
PrintArray(array3D);