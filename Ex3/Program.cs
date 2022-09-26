int n = new Random().Next(4, 8);
int m = new Random().Next(4, 8);
int [,] array = new int [n, m];

CreatArray(array);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого из столбцов по порядку");
GetAverage(array);

void CreatArray(int [,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1,50);
        Console.Write($"{array[i, j],2}  ");
    }
    Console.WriteLine();
}
}

void GetAverage(int [,] array)
{
for (int j=0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i=0; i < array.GetLength(0); i++)
    {
        sum+=array[i,j];
    }
    sum=sum/array.GetLength(0);
    Console.Write($"{Math.Round(sum,2)}"+"  ");
}
}


