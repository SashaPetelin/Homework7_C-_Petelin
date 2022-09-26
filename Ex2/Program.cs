Console.WriteLine("Введите номер строки ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца ");
int coloumn = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[11, 11];

CreatArray(array);
Console.WriteLine();
GetNumOnPosition(array, line, coloumn);

void CreatArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 101);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetNumOnPosition (int [,] array, int line, int coloumn)
{
int i = line;
int j = coloumn;
if (line >= 0 && line < array.GetLength(0) && coloumn >= 0 && coloumn < array.GetLength(1))
{
    Console.Write("Число на данной позиции равно ");
    Console.WriteLine (array[i,j]);
}
else 
{
    Console.WriteLine("Число на данной позиции отсутствует");
}
}