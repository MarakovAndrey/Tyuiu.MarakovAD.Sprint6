int[,] arrayalues = { { 1, 4, 5 }, { 2, 8, 6 } };

for (int i = 0; i < rows - 1; i++)
{
    for (int j = i + 1; j < columns; j++)
    {
        if (arrayalues[i, 2] % 4 == 0)
        {
            arrayalues[i, 2] = 4;
        }
    }
}