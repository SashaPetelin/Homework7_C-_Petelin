int n = new Random().Next(3, 7);
int m = new Random().Next(3, 7);
double [,] array = new double [n, m];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().NextDouble()*100;
        Console.Write($"{Math.Round(array[i, j],2)}  ");
    }
    Console.WriteLine();
}
