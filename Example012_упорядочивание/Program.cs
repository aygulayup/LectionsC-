// 1.Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные элементы

int[] arr = {1, 4, 3, 6, 2, 5, 7, 1, 1};

// метод вывода массива на экран

void PrintAray(int[] array) 
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine(" ");
}

// Метод упорядочивания массива

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        //ищем минимальное

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        // меняем местами swap

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintAray(arr);
SelectionSort(arr);

PrintAray(arr);