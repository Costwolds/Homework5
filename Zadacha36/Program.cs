// 36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите количество чисел");
int size = int.Parse(Console.ReadLine());

int[] GeneratArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(5, 20);
    }

    return array;
}

int[] newarray = GeneratArray(size);
Console.WriteLine(String.Join(" ", newarray));

int SumOdd(int[] newarray)
{
    int sum = 0;

    for (int i = 1; i < newarray.Length; i = i + 2)
    {
        sum = sum + newarray[i];
    }

    return sum;
}

int sumodd = SumOdd(newarray);
Console.WriteLine(sumodd);