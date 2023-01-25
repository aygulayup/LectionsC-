// string[,] table = new string[2, 5];
// table [1, 2] = "слово"; // обращение к элементу

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colomns = 0; colomns < 5; colomns++)
//     {
//         Console.WriteLine($"-{table[rows, colomns]}-");
//     }
// }

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //GetLength обращение к элементу 0, т е число строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) //GetLength обращение к элементу 1, число стц
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // интервал в скобках [1; 10)
        }
    }
}

int[,] matrix = new int[3, 4];// инициализация массива
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);