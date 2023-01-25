// Задан рисунок в виде матрицы из 0 и 1, нужно его закрасить

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++) //GetLength обращение к элементу 0, т е число строк
    {
        for (int j = 0; j < image.GetLength(1); j++) //GetLength обращение к элементу 1, число стц
        {
            //Console.Write($" {image[i, j]} ");
            if(image[i, j] == 0) Console.Write(" ");
            else Console.Write($" + ");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);

    }
}

PrintImage(pic);
FillImage(13, 13); // точка, с которой начинается цикл (покраска)
PrintImage(pic);