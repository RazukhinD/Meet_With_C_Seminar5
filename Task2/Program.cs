//**Задача 35:** Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

//**Задача 37:** Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

using static System.Console;
Clear();
Write("Введите размер массива: ");
int lenght = int.Parse(ReadLine()!);
Write("Введите мин значение массива: ");
int min = int.Parse(ReadLine()!);
Write("Введите макс значение массива: ");
int max = int.Parse(ReadLine()!);
int[] array = GetArray(lenght,min, max);
WriteLine($"[{String.Join(" | ", array)}]");
int count = 0;
for (int i=0; i<array.Length; i++)
{
    if (array[i]>=10 && array[i]<=99)
    {
        count +=1;
    }
}

WriteLine($"Количество элементов от [10;99] = {count}");







int[] GetArray(int size,int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+1);
    }
    return result;
}

