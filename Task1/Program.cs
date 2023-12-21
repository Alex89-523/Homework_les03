// Задайте одномерный массив из 10 целых 
// чисел от 1 до 100. Найдите количество элементов 
// массива, значения которых лежат в отрезке [20,90]. 
// Пример
// массив [10 21 14 93 23] => 2


// ВАРИАНТ с автоматическим вводом 10 целых чисел

int[] array = new int[10];
for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(1,101);
}

int count = 0;

for (int i = 0; i < array.Length; i++) {
    while (i < array.Length) {
        if (array [i] > 19 && array[i] < 91)
        {
            count = count + 1;
        }
        i++;
    }
    Console.Write(count);
}


// ВАРИАНТ с вводом 10 целых чисел через консоль

// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++) 
// {
//     Console.WriteLine ("Введите числа массива");     
//     array[i] = Convert.ToInt32(Console.ReadLine()); 
// }

// int count = 0;

// for (int i = 0; i < array.Length; i++) {
//     while (i < array.Length) {
//         if (array [i] > 19 && array[i] < 91)
//         {
//             count = count + 1;
//         }
//         i++;
//     }
//     Console.Write(count);
// }