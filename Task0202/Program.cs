 int[,] ChangeArray(int[,] array)
{
int[,] result = new int[array.GetLength(0), array.GetLength(1)];
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
result[j, i] = array[i, j];
}
}
return result;
}