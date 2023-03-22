//38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


Console.WriteLine("Введите количество элементов массива");
int size = int.Parse(Console.ReadLine());


double[] CreatArray(int size)
{
    double[] array = new double[size];
    Random num = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = num.Next(1, 100);
    }

    return array;
}

double[] newarray = CreatArray(size);

Console.WriteLine();

Console.WriteLine(String.Join(" ", newarray));

Console.WriteLine();

double MaxI(double[] newarray)
{
    double max = newarray[0];

    for (int i = 0; i < newarray.Length; i++)
    {
        if (newarray[i] > max)
            max = newarray[i];
    }

    return max;
}

double maxim = MaxI(newarray);
Console.WriteLine("Максимальное число " + maxim);

double MinI(double[] newarray)
{
    double min = newarray[0];

    for (int i = 0; i < newarray.Length; i++)
    {
        if (newarray[i] < min)
            min = newarray[i];
    }
    return min;
}

double minim = MinI(newarray);
Console.WriteLine("Минимальное число " + minim);
Console.WriteLine();

double difference = (maxim - minim);

Console.WriteLine("Разница между максимальным и минимальным числами массива равна " + difference);
Console.WriteLine();
