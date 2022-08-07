/*
программа задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] fillingArray(int number)
{
    int[] Arr = new int[number];
    Random rnd = new Random();

    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = rnd.Next(0, 100);
    }
    return Arr;
}

Console.WriteLine("Введите длину массива:");
int size = int.Parse(Console.ReadLine());

int[] array = fillingArray(size);

for (int j = 0; j < array.Length; j++)
{
    if (j < array.Length - 1)
    {
        Console.Write(array[j] + ", ");
    }
    else
    {
        Console.Write(array[j] + " ");
    }
}