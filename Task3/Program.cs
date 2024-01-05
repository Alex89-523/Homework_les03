//  Задайте массив из вещественных чисел с 
// ненулевой дробной частью. Найдите разницу между 
// максимальным и минимальным элементов массива.
// Пример
// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28

// Random rand = new Random();

// Варианты генерации разных чисел, оставлять только одну из строк

// int number = rand.Next(0, 10); // генерация случайных ЦЕЛЫХ чисел
// double number = rand.NextDouble(); // генерация случайных ВЕЩЕСТВЕННЫХ (дробных) чисел, НО от 0.0 до 1.0 (только 0 целое число), добавлять в скобки программа ничего не даст
// double number = rand.Next(0, 10) + rand.NextDouble(); // генерация случайных ВЕЩЕСТВЕННЫХ (дробных) чисел + добавляем промежуток целых чисел к которым добавляется вещественное
// double number = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 3); // генерация случайных ВЕЩЕСТВЕННЫХ (дробных) чисел + добавляем промежуток целых чисел к которым добавляется вещественное + добавляем математический класс, который определяет сколько после запятой знаков оставить в генерируемом числе

// System.Console.WriteLine(number);


double[] GenerateArray(int size, int leftRange, int rightRange)
{
    double[] array = new double[size];
    Random rand = new Random();
    
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 3);
    }

    return array;
}

void PrintArray(double[] arrayForPrint)
{
    System.Console.Write("[ ");
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + " ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int FindMinInArray(double[] array)
{
    int indexMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < array[indexMin])
        {
            indexMin = i;
        }
    }
    return indexMin;
}

int FindMaxInArray(double[] array)
{
    int indexMax = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > array[indexMax])
        {
            indexMax = i;
        }
    }
    return indexMax;
}




//--------------------------
int N = ReadInt("Введите размер массива: ");


double[] myArray = GenerateArray(N, 0, 9);
PrintArray(myArray);

int iMin = FindMinInArray(myArray);
int iMax = FindMaxInArray(myArray);

System.Console.WriteLine($"Разница между {myArray[iMin]} и {myArray[iMax]} равна: {myArray[iMax] - myArray[iMin]}");

// System.Console.WriteLine(myArray.Max() - myArray.Min()); // другой вариант вывода результата задачи (помимо заполнение остальной части нашего массива)