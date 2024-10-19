int[,] numbers =
{
    {1,3,44,7 },
    {7,9,11,5 },
    {21,25,56,7 },
    {34,6,8,26 }
};
int sum = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if (i <= j)
        {
            sum += numbers[i, j];
        }
    }
}

Console.WriteLine(sum);
