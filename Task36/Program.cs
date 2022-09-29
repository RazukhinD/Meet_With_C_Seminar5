using static System.Console;
Clear();
Write("Введите размер массива: ");
int lenght = int.Parse(ReadLine()!);
Write("Введите мин значение массива: ");
int min = int.Parse(ReadLine()!);
Write("Введите макс значение массива: ");
int max = int.Parse(ReadLine()!);
int[] array = GetArray(lenght, min, max);
WriteLine($"[{String.Join(" | ", array)}]");
int summ = SummofUnevenElements(array);
WriteLine($"Сумма элементов стоящих на нечетной позиции:{summ}");




int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+1);
    }
    return result;
}


int SummofUnevenElements (int [] array)
{
    int result = 0;
    for (int i=0;i<array.Length;i++)
    {
        if (i%2 == 0)
        {
            result += array[i];
        }
    }
    return result;
}