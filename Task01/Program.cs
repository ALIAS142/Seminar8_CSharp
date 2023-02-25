// Задача 1(52): Задайте двумерный массив. Программа меняет первую и последнюю строку массива.


int[,] Massiv = GetMatrix (4, 4, 1, 10);
Print(Massiv);
Console.WriteLine();
Reverse(Massiv);
Print(Massiv);


// Рандомный int массив
int [,] GetMatrix (int rows, int columns, int min, int max)
{
int [,] matrix = new int [rows, columns];
for (int i = 0; i < rows; i++)
{
for (int l = 0; l < columns; l++)
{
matrix [i, l] = new Random().Next(min, max + 1);
}
}
return matrix;
}

// Печать массива

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write(matrix[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}

void Reverse (int[,] matrix)
{

//     int[] array = new int [matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(1); i++)
// {
//     array[i] = matrix[0, i];
// }
for (int i = 0; i < matrix.GetLength(1); i++)
{
 int temp = matrix[0, i];
 matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
 matrix[matrix.GetLength(0) - 1, i] = temp;
}

}