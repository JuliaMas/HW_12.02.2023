// Составить частотный словарь элементов двумерного массива
void Fill(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
    }
}
void Print(int[,] arr)
{
	for(int i = 0; i < arr.GetLength(0); i++)
	{
		for(int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write($"{arr[i,j]} ");
		}
		Console.WriteLine();
	}
}


Console.Write("Введите количество строк маттрицы n: ");
int n = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов маттрицы m: ");
int m = int.Parse(Console.ReadLine() ?? "");

int[,] matrix = new int [n,m];
Fill(matrix);
Print(matrix);
Console.WriteLine();

var count = new Dictionary<int, int>();
 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (count.ContainsKey(matrix[i, j]))
        {
            count[matrix[i, j]]=++count[matrix[i, j]];
        }
        else
        {
            count.Add(matrix[i, j], 1);
        }
    }
}
foreach (var r in count)
{
    Console.WriteLine($"число {r.Key} встречается {r.Value} раз");
}
 


