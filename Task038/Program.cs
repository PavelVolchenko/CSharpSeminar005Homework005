/*  Задача 38: Задайте массив вещественных чисел. Найдите разницу 
    между максимальным и минимальным элементов массива.
    [3 7 22 2 78] -> 76                                        */


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

double diffBetweenMaxAndMinNumbersInArray(int[] currentArray)
{
    int max = currentArray[0];
    int min = currentArray[0];
    for (int i = 1; i < currentArray.Length; i++)
    {
        if (currentArray[i] < min)
        {
            min = currentArray[i];
        }
        if (currentArray[i] > max)
        {
            max = currentArray[i];
        }
    }
    return max - min;
}

Console.Write("Задайте длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] currentArray = getRandomArray(length, 1, 99);
printArray(currentArray);

double diffResult = diffBetweenMaxAndMinNumbersInArray(currentArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {diffResult}");
