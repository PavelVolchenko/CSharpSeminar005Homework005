/*  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    Напишите программу, которая покажет количество чётных чисел в массиве.
    [345, 897, 568, 234] -> 2                                                          */

int[] getRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}

void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int countOfEvenNumbersInArray(int[] currentArray)
{
    int count = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

Console.Write("Задайте длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] currentArray = getRandomArray(length, 100, 999);
printArray(currentArray);

int countOfEvenNumbers = countOfEvenNumbersInArray(currentArray);
Console.WriteLine($"Количество четных чисел в массиве = {countOfEvenNumbers}");
