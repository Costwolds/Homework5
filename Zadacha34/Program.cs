//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите количество чисел"); 
int size = int.Parse(Console.ReadLine()); 

int[] GetArray(int size) 
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int[] newarray = GetArray(size); //вызов функции
Console.WriteLine(String.Join(" ", newarray));

int CountEven(int[] newarray)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (newarray[i] % 2 == 0)
            count++;
    }
    return count;
}

int even = CountEven(newarray);
Console.Write("Количество чётных чисел - ");
Console.WriteLine(even);
