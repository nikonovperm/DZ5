/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] GetArrayOfNumbers (int length)
{
    int[] randomArray = new int [length];
    for (int i = 0; i < length; i++)
    {
        randomArray[i] = new Random().Next(-100,100);
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

void SumOfOddNumbers (int[] arrayOfNumbers)
{
    int sum = 0;
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += arrayOfNumbers[i]; 
        }
    }
    System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");
}

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arrayOfNumbers = GetArrayOfNumbers (length);
Console.WriteLine();
PrintArray (arrayOfNumbers);
Console.WriteLine();
SumOfOddNumbers (arrayOfNumbers);