// ex50

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

void findNumber(int[,] matrix, int i, int j)
{
    Console.WriteLine($"eto iskal? : {matrix[i, j]}");
}



Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);

Console.WriteLine("kakaya stroka?");
int i = Convert.ToInt32(Console.ReadLine()) - 1;
if (i > matrix.GetLength(0)) Console.WriteLine("net tut stolko strochek");
else
    Console.WriteLine("kakoi stolbec?");
int j = Convert.ToInt32(Console.ReadLine()) - 1;
if (j > matrix.GetLength(1)) Console.WriteLine("net tut stolko stolbikov");


findNumber(matrix, i, j);