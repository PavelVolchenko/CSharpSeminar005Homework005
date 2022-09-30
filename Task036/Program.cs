/*  Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    Найдите сумму элементов, стоящих на нечётных позициях.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0                                               */

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

int sumOfElementsInOddPosition(int[] currentArray)
{
    int result = 0;
    for (int i = 1; i < currentArray.Length; i += 2)
    {
        result += currentArray[i];
    }
    return result;
}

Console.Write("Задайте длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] currentArray = getRandomArray(length, -99, 99);
printArray(currentArray);

int sumOfElements = sumOfElementsInOddPosition(currentArray);
Console.WriteLine($"Сумма элементов на нечетных позициях = {sumOfElements}");