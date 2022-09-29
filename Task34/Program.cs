 //Задайте массив заполненный случайными положительными трёхзначными числами. 
 //Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


using static System.Console;
Clear();
Write("Введите размер массива: ");
int lenght = int.Parse(ReadLine()!);
int[] array = GetArray(lenght);
WriteLine($"[{String.Join(" | ", array)}]");
HowManyEven(array);







int [] GetArray (int size)
{
    Random rnd = new Random();
    int [] result = new int [size];
    for (int i=0;i<result.Length;i++)
    {
        result[i] = rnd.Next(100,1000);
    }
return result;
}

void HowManyEven (int [] array)
{
    int count = 0;
    for (int i=0;i<array.Length;i++)
    {
        if (array[i]%2 == 0)
        {
            count+=1;
        }
    }
    WriteLine($"Количество четных элементов массива: {count}");
}



