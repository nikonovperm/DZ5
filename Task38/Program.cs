/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double [] GetArrayOfNumbers (int length)
{
    double[] randomArray = new double [length];
    for (int i = 0; i < length; i++)
    {
        randomArray[i] = new Random().Next(-100,100);
    }
    return randomArray;
}

void PrintArray (double[] arrayOfNumbers)
{
    Console.Write("[");
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        {        
            Console.Write(arrayOfNumbers[i]);
            if (i < arrayOfNumbers.Length-1)
            {
                Console.Write("; ");
            }   
        }
        
    }
    Console.WriteLine("]");
}

void DifferenceOfMaxAndMinElements (double[] arrayOfNumbers)
{
    double difference = 0;
    double min = arrayOfNumbers[0];
    double max = arrayOfNumbers[0];        
    for (int i = 1; i < arrayOfNumbers.Length; i++)
    {
        if (arrayOfNumbers[i] > max)
        {
            max = arrayOfNumbers[i];
        }
        else
        {
            if (arrayOfNumbers[i] < min)
            {
                min = arrayOfNumbers[i];
            }
        }
    }
    difference = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");
}

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] arrayOfNumbers = GetArrayOfNumbers (length);
Console.WriteLine();
PrintArray (arrayOfNumbers);
Console.WriteLine();
DifferenceOfMaxAndMinElements (arrayOfNumbers);