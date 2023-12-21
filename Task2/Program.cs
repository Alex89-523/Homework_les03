// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет 
// количество чётных чисел в массиве.
// Пример
// массив [6 7 19 34 3 1 4 7 9 1] => 3 
// массив [1 8 43 4 55 60 3 2 1 3] => 4


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
//         if (array[i] % 2 == 0){
//             count = count + 1;
//         }
//         i++;
//     }
//     Console.Write(count);
// }



// ВАРИАНТ с автоматическим вводом 10 целых чисел

int[] array = new int[10];
for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next();
}

int count = 0;

for (int i = 0; i < array.Length; i++) {
    while (i < array.Length) {
        if (array[i] % 2 == 0){
            count = count + 1;
        }
        i++;
    }
    Console.Write(count);
}