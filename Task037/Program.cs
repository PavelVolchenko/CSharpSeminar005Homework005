/*  Задача 37: Найдите произведение пар чисел в одномерном массиве. 
    Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
    Результат запишите в новом массиве.
    [1 2 3 4 5] -> 5 8 3
    [6 7 3 6] -> 36 21                                                    */

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

int[] productOfNumbersArray(int[] currentArray, int length)
{
    int[] productOfNumbersArray = new int[length / 2];
    for (int i = 0; i < length / 2; i++)
    {
        productOfNumbersArray[i] = currentArray[i] * currentArray[length - i - 1];
    }
    return productOfNumbersArray;
}

Console.Write("Задайте длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] currentArray = getRandomArray(length, 1, 10);
printArray(currentArray);
int[] resultProductOfNumbersArray = productOfNumbersArray(currentArray, length);
printArray(resultProductOfNumbersArray);