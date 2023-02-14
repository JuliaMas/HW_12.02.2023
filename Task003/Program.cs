// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
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

int[,] FindSmallElement(int[,] matrix, int[,] possition)
{
    int temp = matrix[0,0];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] <= temp)
            {
                possition[0,0] = i;
                possition[0,1] = j;
                temp = matrix[i,j];
            }
        }
    }
    return possition;
} 

void Delete(int[,] matrix, int[,] PossitioSmallEl, int[,] newMatrix)
{
    int k = 0;
    int l = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(PossitioSmallEl[0,0] != i && PossitioSmallEl[0,1] != j)
            {
                newMatrix[k,l] = matrix[i,j];
                l++;
            }
        }
        l = 0;
        if(PossitioSmallEl[0,0] != i)
        {
            k++;
        }
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

//выводим индекс наименьшего элемента
int[,] PossitioSmallEl = new int[1,2];
PossitioSmallEl = FindSmallElement(matrix, PossitioSmallEl);
Print(PossitioSmallEl);
Console.WriteLine();

//печатаем новый массив
int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
Delete(matrix, PossitioSmallEl, newMatrix);
Print(newMatrix);

