using static System.Console;
Clear();
Write("Введите размер массива: ");
int lenght = int.Parse(ReadLine()!);
Write("Введите мин значение массива: ");
int min = int.Parse(ReadLine()!);
Write("Введите макс значение массива: ");
int max = int.Parse(ReadLine()!);
int[] array = GetArray(lenght, min, max);
// int[] array1=new int[lenght];
// FillArray1(array1,min,max);

//string strArray=String.Join(" ",array);
WriteLine($"[{String.Join(" ", array)}]");

int positiveSum = 0;
int negativeSum = 0;

foreach (int element in array)
{
    positiveSum += element > 0 ? element : 0;
    negativeSum += element < 0 ? element : 0;
    // if(element>0)
    // {
    //     positiveSum+=element;
    // }
    // if(element<0)
    // {
    //     negativeSum+=element;
    // }
}
WriteLine($"NegativeSum={negativeSum}, positiveSum={positiveSum}");





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

// void FillArray1(int[] inArray, int minValue, int maxValue)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         inArray[i] = rnd.Next(minValue, maxValue+1);
//     }
//    // return result;
// }
