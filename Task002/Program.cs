// Найти произведение двух матриц
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
void Multiplay(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for(int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for(int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum = sum + (firstMatrix[i,k] * secondMatrix[k,j]); 
            }
            resultMatrix[i,j] = sum;
        }
    }
}

Console.Write("Введите количество строк первой матрицы n: ");
int n = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов первой мвтрицы (= количеству строк второй матрицы) m: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов второй матрицы l: ");
int l = int.Parse(Console.ReadLine() ?? "");

int [,] firstMatrix = new int [n,m];
Fill(firstMatrix);
Print(firstMatrix);
Console.WriteLine();

int[,] secondMatrix = new int[m,l];
Fill(secondMatrix);
Print(secondMatrix);
Console.WriteLine();

int [,] resultMatrix = new int[m,l];
Multiplay(firstMatrix, secondMatrix, resultMatrix);
Print(resultMatrix);





