// Задача 2(53) - Программа заменяет строки на столбцы.


int[,] Massiv = GetMatrix (4, 4, 1, 10);
Print(Massiv);
Console.WriteLine();
Reverse2(Massiv);
Print(Massiv);


while(true)
{
    if(Massiv.GetLength(0) == Massiv.GetLength(1))
    break;

    else
    {
        Console.WriteLine("Wrong enter");
    }
}


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

void Reverse2 (int[,]matrix)
{
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {  

      for(int j = i + 1; j < matrix.GetLength(1); j++)
      {
        temp = matrix[i, j];
        matrix[i, j] = matrix[j,i];
        matrix[j,i] = temp;
      }
}
    }

    