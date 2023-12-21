//  Дано натуральное 
// число в диапазоне от 1 до 100 000. Создайте массив, 
// состоящий из цифр этого числа. Старший разряд 
// числа должен располагаться на 0-м индексе 
// массива, младший – на последнем. Размер массива 
// должен быть равен количеству цифр.

// Пример
// 425 => [4 2 5]
// 8741 => [8 7 4 1]
// 4 => [4]


// Программа написана для введения числа и размера массива вручную

int [] array = new int[5];
int number = 97345;

for (int i = 0; i < array.Length; i++)
{
    array[i] = number % 10;
    number /= 10;
}

int temp = 0;

for (int i = 0; i < array.Length /2; i++)
{
    temp = array[i];
    array[i] = array[array.Length-1-i];
    array[array.Length-1-i] = temp;
}
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]+" ");
}
Console.Write("]");