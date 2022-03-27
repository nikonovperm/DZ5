/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными
 числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] GetArrayOfNumbers (int length)
{
    int[] randomArray = new int [length];
    for (int i = 0; i < length; i++)
    {
        randomArray[i] = new Random().Next(100,999);
    }
    return randomArray;
}

void PrintArray (int[] arrayOfNumbers)
{
    Console.Write("[");
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        {        
            Console.Write(arrayOfNumbers[i]);
            if (i < arrayOfNumbers.Length-1)
            {
                Console.Write(", ");
            }   
        }
        
    }
    Console.WriteLine("]");
}

void CountOfEven (int[] arrayOfNumbers)
{
    int count = 0;
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        if (arrayOfNumbers[i] % 2 == 0)
        {
            count+=1;   
        }
    }
    System.Console.WriteLine($"Количество чётных элементов в массиве: {count}");
}

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arrayOfNumbers = GetArrayOfNumbers (length);
Console.WriteLine();
PrintArray (arrayOfNumbers);
Console.WriteLine();
CountOfEven (arrayOfNumbers);
