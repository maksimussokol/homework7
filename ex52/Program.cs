Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
}


Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);

double[] srar = new double[matrix.GetLength(1)];
for (int i = 0, k = 0; i < matrix.GetLength(0); i++)
{
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];
    }
    srar[k] = sum / matrix.GetLength(0);
    Console.WriteLine("Среднее арифметическое столбца " + (i + 1) + " равно: " + srar[k]);
    k++;
}
