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

ChangeToOpposite(array);

WriteLine($"[{String.Join(" | ", array)}]");

Write("Введите число для поиска: ");
int look_up = int.Parse(ReadLine()!);

bool resultLook_Up = LookUp(array, look_up);
WriteLine($"{resultLook_Up}");



bool LookUp (int [] arr, int lookup)
{
    foreach (var element in array)
    {
        if (element == lookup)
        {
            return true;
        }
    }
    return false;
}


void ChangeToOpposite(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]=-array[i];
    }
}







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

